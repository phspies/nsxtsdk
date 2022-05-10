# C# SDK for NSX-T 3.2

SDK compatable with .net 6.0 for NSX-T 3.2 Manager and Policy engins. It uses RestSharp as the transport and uses Newtonsoft.Json for JSON handeling.

## Modules

The Manager and Policy modules are accesible from the same SDK root object in the following manner:

```dotnet
		NSXTClient nsxtClient = new NSXTClient("192.168.0.100", "admin", "password");

		var clusterStatus = nsxtClient.ManagerEngine.ClusterManagementModule.ReadClusterNodesAggregateStatus();

		var infraObject = nsxtClient.PolicyEngine.PolicyModule.ReadInfra("/infra/domains/default");
```

All Types and Enums are prefixed with NSXT to avoid collisions in your projects.

## Custom JsonSerializerSettings

You can pass your own serialization settings as part of the client init code

```dotnet
		NSXTClient nsxtClient = new NSXTClient("192.168.0.100", "admin", "password", false, new Newtonsoft.Json.JsonSerializerSettings() {  Formatting = Newtonsoft.Json.Formatting.None });
```

##Example Tier0/Tier1/Segment Creation Code

```dotnet
 NSXTClient nsxtsdk = new NSXTClient("10.0.100.14", "admin", "VMware1!VMware1!", false);

            var managementPlaneconfig = (await nsxtsdk.ManagerEngine.ManagementPlaneModuleModule.ReadManagementPlaneConfiguration());
            var clusterStatuc = (await nsxtsdk.ManagerEngine.ClusterManagementModule.ReadClusterStatus());
            var tnnodes = (await nsxtsdk.ManagerEngine.TransportNodeLcmModule.ListTransportNodesWithDeploymentInfo());
            var tzones = (await nsxtsdk.ManagerEngine.TransportZoneModule.ListTransportZones());

            var tier0Name = "TestCodeTier0";
            var tier1Name = "TestCodeTier1";
            var tier0_1 = new NSXTInfraType()
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
                    },
                    new NSXTChildTier1Type() {
                        ResourceType = "ChildTier1",
                        Tier1 =  new NSXTTier1Type() {
                             RouteAdvertisementTypes = new List<string>() {"TIER1_IPSEC_LOCAL_ENDPOINT"},
                            ResourceType = "Tier1",
                            DisplayName = tier1Name,
                            Id = tier1Name,
                            Tier0Path = $"/infra/tier-0s/{tier0Name}",
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
                DisplayName = "TestCodeSegmentCreation",
                ReplicationMode = NSXTSegmentReplicationModeEnumType.MTEP,
                TransportZonePath = $"/infra/sites/default/enforcement-points/default/transport-zones/{tzones.Results.Single(x => x.DisplayName == "nsx-overlay-transportzone").Id}",
                AdminState = NSXTSegmentAdminStateEnumType.UP,
                ConnectivityPath = $"/infra/tier-1s/{tier1Name}",
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
            await nsxtsdk.PolicyEngine.PolicyModule.PatchInfra(tier0_1, EnforceRevisionCheck: true);
            var segmentResponse = await nsxtsdk.PolicyEngine.PolicyConnectivityModule.CreateOrReplaceInfraSegment(segment.Id, segment);
            await nsxtsdk.LogoutAsync();

```