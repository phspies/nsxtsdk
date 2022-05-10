using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using nsxtsdk;
using nsxtsdk.PolicyModels;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace sdktesting
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            NSXTClient nsxtsdk = new NSXTClient("10.0.100.14", "admin", "VMware1!VMware1!", false);

            var managementPlaneconfig = (await nsxtsdk.ManagerEngine.ManagementPlaneModuleModule.ReadManagementPlaneConfiguration());
            var clusterStatuc = (await nsxtsdk.ManagerEngine.ClusterManagementModule.ReadClusterStatus());
            var tnnodes = (await nsxtsdk.ManagerEngine.TransportNodeLcmModule.ListTransportNodesWithDeploymentInfo());
            var tzones = (await nsxtsdk.ManagerEngine.TransportZoneModule.ListTransportZones());

            var tier0Name = "TestCodeTier0";
            var tier0 = new NSXTInfraType()
            {
                Children = new List<NSXTChildPolicyConfigResourceType>() {
                    new NSXTChildTier0Type() {
                        ResourceType = "ChildTier0",
                        Tier0 =  new NSXTTier0Type() {
                            HaMode = NSXTTier0HaModeEnumType.ACTIVEACTIVE,
                            ResourceType = "Tier0",
                            DisplayName = "TestCodeTier0",
                            AdvancedConfig = new NSXTTier0AdvancedConfigType()
                            {
                                ForwardingUpTimer = 0
                            },
                            Id = tier0Name,
                            Children = new List<NSXTChildPolicyConfigResourceType>() {
                                new NSXTChildLocaleServicesType() {
                                    LocaleServices = new NSXTLocaleServicesType() {
                                        Id = "default",
                                        ResourceType = "LocaleServices"
                                    },
                                    ResourceType= "ChildLocaleServices"
                                },
                            }
                        }
                    }
                },
                ResourceType = "Infra"
            };

            var segment = new NSXTSegmentType()
            {
                Id = "TestCodeSegmentCreation",
                DisplayName= "TestCodeSegmentCreation",
                ReplicationMode = NSXTSegmentReplicationModeEnumType.MTEP,
                TransportZonePath = $"/infra/sites/default/enforcement-points/default/transport-zones/{tzones.Results.Single(x => x.DisplayName == "nsx-overlay-transportzone").Id}",
                AdminState = NSXTSegmentAdminStateEnumType.UP,
                ConnectivityPath = $"/infra/tier-0s/{tier0Name}",
                AdvancedConfig = new NSXTSegmentAdvancedConfigType()
                {
                    AddressPoolPaths = new List<string>(),
                    Multicast = true,
                    UrpfMode = NSXTSegmentAdvancedConfigUrpfModeEnumType.STRICT,
                    Connectivity = NSXTConnectivityAdvancedConfigConnectivityEnumType.ON
                },
                Subnets = new List<NSXTSegmentSubnetType>()
                {
                    new NSXTSegmentSubnetType() { GatewayAddress = "10.0.0.1/24"}
                }



            };
   

            var json = JsonConvert.SerializeObject(segment, Formatting.None, new JsonSerializerSettings
            {
                DefaultValueHandling = DefaultValueHandling.Include,
                TypeNameHandling = TypeNameHandling.Auto,
                NullValueHandling = NullValueHandling.Ignore,
                Formatting = Formatting.None,
                ConstructorHandling = ConstructorHandling.Default,
                Converters = new List<JsonConverter>() { new Newtonsoft.Json.Converters.StringEnumConverter() }
            });

            await nsxtsdk.PolicyEngine.PolicyModule.PatchInfra(tier0, EnforceRevisionCheck: true);

            var segmentResponse = await nsxtsdk.PolicyEngine.PolicyConnectivityModule.CreateOrReplaceInfraSegment(segment.Id, segment);

            await nsxtsdk.LogoutAsync();
        }
    }
}