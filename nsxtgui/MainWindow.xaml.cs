using Newtonsoft.Json;
using nsxtapi;
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
        private void connectNSX_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                statusListControl.Items.Clear();
                Mouse.OverrideCursor = Cursors.Wait;
                nsxtClient = new NSXTClient(nsxtConnectionHost.Text, nsxtConnectionUsername.Text, nsxtConnectionPassword.Password, (bool)nsxtConnectionValidateCertificate.IsChecked, new Newtonsoft.Json.JsonSerializerSettings() {  Formatting = Newtonsoft.Json.Formatting.None });
                var status = nsxtClient.ManagerEngine.ClusterManagementModule.ReadClusterNodesAggregateStatus();
                var cluster = nsxtClient.ManagerEngine.ClusterManagementModule.ReadClusterStatus();
                var tnnodes = nsxtClient.ManagerEngine.TransportNodeLcmModule.ListTransportNodesWithDeploymentInfo();
                var tier0s = nsxtClient.PolicyEngine.PolicyConnectivityModule.ListTier0s().Results;
                var tier1s = nsxtClient.PolicyEngine.PolicyConnectivityModule.ListTier1().Results;
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
                    Parallel.ForEach(tnnodes.Results, node =>
                    {
                        nodeInformation.Add(new Tuple<nsxtsdk.ManagerModels.NSXTTransportNodeType, nsxtsdk.ManagerModels.NSXTTransportNodeStateType>(node, nsxtClient.ManagerEngine.TransportNodeLcmModule.GetTransportNodeStateWithDeploymentInfo(node.Id)));
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
                    dfwSectionsControl.ItemsSource = nsxtClient.PolicyEngine.DfwSecurityPolicyModule.ListSecurityPoliciesForDomain("default").Results as List<NSXTSecurityPolicyType>;
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


        private void dfwSectionsControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            try
            {
                var selectedPolicy = e.AddedItems[0] as NSXTSecurityPolicyType;
                var test = nsxtClient.PolicyEngine.DfwSecurityPolicyModule.ListSecurityRules("default", selectedPolicy.Id);
                dfwRulesControl.ItemsSource = nsxtClient.PolicyEngine.DfwSecurityPolicyModule.ListSecurityRules("default", selectedPolicy.Id).Results;
            }
            catch (Exception ex)
            {

            }
            Mouse.OverrideCursor = Cursors.Arrow;
        }
        private void dfwRulesControl_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Wait;
            if (e.AddedItems != null)
            {
                var selectedRule = e.AddedItems[0] as NSXTRuleType;
                selectedDFWRule = nsxtClient.PolicyEngine.DfwSecurityPolicyModule.ReadSecurityRule("default", selectedRule.ParentPath.Split("/").Last(), selectedRule.Id);
                rawJsonView.Text = JsonConvert.SerializeObject(selectedDFWRule, Formatting.Indented);


                Mouse.OverrideCursor = Cursors.Arrow;
                if (selectedDFWRule == null)
                {
                    MessageBox.Show("Rule Does not Exist", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }

        private void createDFWButton_Click(object sender, RoutedEventArgs e)
        {
            NSXTInfraType infraObject = new NSXTInfraType();
            infraObject.Children.Add(new NSXTChildPolicyConfigResourceType() { ResourceType = "ChildDomain", Id = "default", });
            nsxtClient.PolicyEngine.PolicyModule.PatchInfra(infraObject);

        }
    }
}
