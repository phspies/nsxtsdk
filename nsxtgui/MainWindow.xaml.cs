using Newtonsoft.Json;
using nsxtapi;
using nsxtsdk;
using nsxtsdk.PolicyModels;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace nsxtgui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NSXTClient nsxtClient;
        public NSXTRuleType selectedDFWRule { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }
        private async Task connectNSX_ClickAsync(object sender, RoutedEventArgs e)
        {
            try
            {
                statusListControl.Items.Clear();
                Mouse.OverrideCursor = Cursors.Wait;
                nsxtClient = new NSXTClient(nsxtConnectionHost.Text, nsxtConnectionUsername.Text, nsxtConnectionPassword.Password, (bool)nsxtConnectionValidateCertificate.IsChecked);
                var status = (await nsxtClient.ManagerEngine.ClusterManagementModule.ReadClusterNodesAggregateStatus());
                var cluster = (await nsxtClient.ManagerEngine.ClusterManagementModule.ReadClusterStatus());
                var tnnodes = (await nsxtClient.ManagerEngine.TransportNodeLcmModule.ListTransportNodesWithDeploymentInfo());

                //use policy engine to get Tier0's and Tier1's
                var tier0s = (await nsxtClient.PolicyEngine.PolicyConnectivityModule.ListTier0s()).Results;
                var tier1s = (await nsxtClient.PolicyEngine.PolicyConnectivityModule.ListTier1()).Results;
                if (status != null || cluster != null || tnnodes != null)
                {
                    string httpsLeader = cluster.DetailedClusterStatus.Groups.FirstOrDefault(x => x.GroupType == nsxtsdk.ManagerModels.NSXTClusterGroupStatusGroupTypeEnumType.HTTPS).Leaders.First().LeaderUuid;
                    statusListControl.Items.Add($"Cluster ID: {cluster.ClusterId}");
                    statusListControl.Items.Add($"Cluster Status: {cluster.ControlClusterStatus.Status}");
                    statusListControl.Items.Add($"Cluster Leader: {cluster.DetailedClusterStatus.Groups.FirstOrDefault(x => x.GroupType == nsxtsdk.ManagerModels.NSXTClusterGroupStatusGroupTypeEnumType.HTTPS).Members.First(x => x.MemberUuid == httpsLeader).MemberIp}");
                    foreach (var node in status.ManagementCluster)
                    {
                        statusListControl.Items.Add($"Cluster Node IP: {node.RoleConfig.ApiListenAddr.IpAddress}");
                        statusListControl.Items.Add($"\tVersion: {node.NodeStatus.Version}");
                        statusListControl.Items.Add($"\tResources: CPU: {node.NodeStatusProperties.First().CpuCores}, Memory: {node.NodeStatusProperties.First().MemTotal / 1024 / 1024}GB");
                    }
                    ConcurrentBag<Tuple<nsxtsdk.ManagerModels.NSXTTransportNodeType, nsxtsdk.ManagerModels.NSXTTransportNodeStateType>> nodeInformation = new ConcurrentBag<Tuple<nsxtsdk.ManagerModels.NSXTTransportNodeType, nsxtsdk.ManagerModels.NSXTTransportNodeStateType>>();
                    Parallel.ForEach(tnnodes.Results, async node =>
                    {
                        nodeInformation.Add(new Tuple<nsxtsdk.ManagerModels.NSXTTransportNodeType, nsxtsdk.ManagerModels.NSXTTransportNodeStateType>(node, await nsxtClient.ManagerEngine.TransportNodeLcmModule.GetTransportNodeStateWithDeploymentInfo(node.Id)));
                    });
                    foreach (var thisnode in nodeInformation)
                    {
                        statusListControl.Items.Add($"Transport Node: {thisnode.Item1.NodeDeploymentInfo.DisplayName}");
                        statusListControl.Items.Add($"\tID: {thisnode.Item1.Id}");
                        statusListControl.Items.Add($"\tType: {thisnode.Item1.NodeDeploymentInfo.ResourceType}");
                        statusListControl.Items.Add($"\tStatus: {thisnode.Item2.NodeDeploymentState.State}");
                        statusListControl.Items.Add($"\tFailure Message: {thisnode.Item2.FailureMessage}");
                    }
                    foreach (var tier0 in tier0s)
                    {
                        statusListControl.Items.Add($"Tier 0: {tier0.DisplayName}");
                        statusListControl.Items.Add($"\tHA Mode: {tier0.HaMode}");
                    }
                    foreach (var tier1 in tier1s)
                    {
                        statusListControl.Items.Add($"Tier 1: {tier1.DisplayName}");
                        statusListControl.Items.Add($"\tTier 0 Path: {tier1.Tier0Path}");
                        statusListControl.Items.Add($"\tFailover Mode: {tier1.FailoverMode}");
                        statusListControl.Items.Add($"\tPool Allocation: {tier1.PoolAllocation}");
                    }
                    //Load Firewall Sections and rules
                    dfwSectionsControl.ItemsSource = (await nsxtClient.PolicyEngine.DfwSecurityPolicyModule.ListSecurityPoliciesForDomain("default")).Results as List<NSXTSecurityPolicyType>;
                }
                else

                {
                    statusListControl.Items.Add($"Returned objects are nill");
                }


            }
            catch (Exception ex)
            {
                statusListControl.Items.Add($"Error Connecting: {ex.Message}");
            }
            Mouse.OverrideCursor = Cursors.Arrow;
        }

        private async Task dfwSectionsControl_SelectionChangedAsync(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            try
            {
                var selectedPolicy = e.AddedItems[0] as NSXTSecurityPolicyType;
                var test = nsxtClient.PolicyEngine.DfwSecurityPolicyModule.ListSecurityRules("default", selectedPolicy.Id);
                dfwRulesControl.ItemsSource = (await nsxtClient.PolicyEngine.DfwSecurityPolicyModule.ListSecurityRules("default", selectedPolicy.Id)).Results;
            }
            catch (Exception ex)
            {

            }
            Mouse.OverrideCursor = Cursors.Arrow;
        }
        private async Task dfwRulesControl_SelectionChangedAsync(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            if (e.AddedItems != null)
            {
                var selectedRule = e.AddedItems[0] as NSXTRuleType;
                selectedDFWRule = (await nsxtClient.PolicyEngine.DfwSecurityPolicyModule.ReadSecurityRule("default", selectedRule.ParentPath.Split("/").Last(), selectedRule.Id));
                rawJsonView.Text = JsonConvert.SerializeObject(selectedDFWRule, Formatting.Indented);


                Mouse.OverrideCursor = Cursors.Arrow;
                if (selectedDFWRule == null)
                {
                    MessageBox.Show("Rule Does not Exist", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private async Task createDFWButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            NSXTSecurityPolicyType selectedPolicy = dfwSectionsControl.SelectedItem as NSXTSecurityPolicyType;
            NSXTRuleType selectedRule = dfwRulesControl.SelectedItem as NSXTRuleType;
            var id = (new Random()).Next(10000, 20000).ToString();
            NSXTInfraType test = await nsxtClient.PolicyEngine.PolicyModule.ReadInfra("/infra/domains/default");
            //NSXTInfraType rule = new NSXTInfraType()
            //{
            //    Children = new List<NSXTChildPolicyConfigResourceType>() { new NSXTChildPolicyConfigResourceType() { Id = "default", ResourceType = "Domain"} }
            //}
            //nsxtClient.PolicyEngine.DfwSecurityPolicyModule.PatchSecurityRule(
            //    selectedRule.ParentPath.Split("/")[2], 
            //    selectedRule.ParentPath.Split("/").Last(),
            //    id, 
            //    new NSXTRuleType() {
            //        DisplayName = $"{id}rule",
            //        ResourceType = "SecurityPolicy",
                    
            //        IpProtocol =  NSXTBaseRuleIpProtocolEnumType.IPV4IPV6,
            //        Action = NSXTRuleActionEnumType.ALLOW,
            //        Direction = NSXTBaseRuleDirectionEnumType.INOUT,
            //        Profiles = new List<string> { "ANY" },
            //        DestinationGroups = new List<string> { "ANY" },
            //        SourceGroups = new List<string> { "ANY" },
            //        Services = new List<string> { "ANY" },
            //        Scope = new List<string> { "ANY" }
            //    }
            //    );
            dfwRulesControl.ItemsSource = (await nsxtClient.PolicyEngine.DfwSecurityPolicyModule.ListSecurityRules("default", selectedPolicy.Id)).Results;

        }
    }
}
