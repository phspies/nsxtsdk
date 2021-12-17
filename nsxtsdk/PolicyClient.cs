// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>

using System;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers.NewtonsoftJson;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using nsxtapi.PolicyModules;
using nsxtsdk;

namespace nsxtapi
{
    public class PolicyEngine
    {
        JsonSerializerSettings defaultSerializationSettings;
        RestClient restClient;
        public PolicyEngine(RestClient RestClient, JsonSerializerSettings DefaultSerializationSettings)
        {
            restClient = RestClient;
            restClient.BaseUrl = new Uri($"{restClient.BaseUrl.GetLeftPart(System.UriPartial.Authority)}/policy/api/v1");
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        public PolicyRealizedState PolicyRealizedStateModule => new PolicyRealizedState(restClient, defaultSerializationSettings);
        public PolicyConnectivityStatistics PolicyConnectivityStatisticsModule => new PolicyConnectivityStatistics(restClient, defaultSerializationSettings);
        public PolicyOspf PolicyOspfModule => new PolicyOspf(restClient, defaultSerializationSettings);
        public PolicyAdvancedLoadBalancer PolicyAdvancedLoadBalancerModule => new PolicyAdvancedLoadBalancer(restClient, defaultSerializationSettings);
        public PolicyConnectivity PolicyConnectivityModule => new PolicyConnectivity(restClient, defaultSerializationSettings);
        public PolicyMonitoringProfileBinding PolicyMonitoringProfileBindingModule => new PolicyMonitoringProfileBinding(restClient, defaultSerializationSettings);
        public PolicyFirewallConfiguration PolicyFirewallConfigurationModule => new PolicyFirewallConfiguration(restClient, defaultSerializationSettings);
        public PolicySha PolicyShaModule => new PolicySha(restClient, defaultSerializationSettings);
        public PolicyLoadBalancer PolicyLoadBalancerModule => new PolicyLoadBalancer(restClient, defaultSerializationSettings);
        public PolicyNAT PolicyNATModule => new PolicyNAT(restClient, defaultSerializationSettings);
        public ClusterControlPlane ClusterControlPlaneModule => new ClusterControlPlane(restClient, defaultSerializationSettings);
        public PolicyGroupRealization PolicyGroupRealizationModule => new PolicyGroupRealization(restClient, defaultSerializationSettings);
        public PolicyDNSStatistics PolicyDNSStatisticsModule => new PolicyDNSStatistics(restClient, defaultSerializationSettings);
        public PolicyVPNStatistics PolicyVPNStatisticsModule => new PolicyVPNStatistics(restClient, defaultSerializationSettings);
        public PolicyGatewayProfileBinding PolicyGatewayProfileBindingModule => new PolicyGatewayProfileBinding(restClient, defaultSerializationSettings);
        public PolicyDiscoveryProfileBinding PolicyDiscoveryProfileBindingModule => new PolicyDiscoveryProfileBinding(restClient, defaultSerializationSettings);
        public PolicyIDSGateway PolicyIDSGatewayModule => new PolicyIDSGateway(restClient, defaultSerializationSettings);
        public PolicyForwarding PolicyForwardingModule => new PolicyForwarding(restClient, defaultSerializationSettings);
        public PolicyIPFIXDFW PolicyIPFIXDFWModule => new PolicyIPFIXDFW(restClient, defaultSerializationSettings);
        public PolicyLayer2VPN PolicyLayer2VPNModule => new PolicyLayer2VPN(restClient, defaultSerializationSettings);
        public PolicyVpnIPSecVpn PolicyVpnIPSecVpnModule => new PolicyVpnIPSecVpn(restClient, defaultSerializationSettings);
        public PolicyEnforcementPointManagement PolicyEnforcementPointManagementModule => new PolicyEnforcementPointManagement(restClient, defaultSerializationSettings);
        public PolicyFirewallCPUMemThresholdsProfileBinding PolicyFirewallCPUMemThresholdsProfileBindingModule => new PolicyFirewallCPUMemThresholdsProfileBinding(restClient, defaultSerializationSettings);
        public PolicyIdentity PolicyIdentityModule => new PolicyIdentity(restClient, defaultSerializationSettings);
        public PolicyHostTransportNodeProfile PolicyHostTransportNodeProfileModule => new PolicyHostTransportNodeProfile(restClient, defaultSerializationSettings);
        public PolicyMulticast PolicyMulticastModule => new PolicyMulticast(restClient, defaultSerializationSettings);
        public PolicyMacDiscovery PolicyMacDiscoveryModule => new PolicyMacDiscovery(restClient, defaultSerializationSettings);
        public PolicyAntreaMonitoring PolicyAntreaMonitoringModule => new PolicyAntreaMonitoring(restClient, defaultSerializationSettings);
        public PolicySegmentSecurity PolicySegmentSecurityModule => new PolicySegmentSecurity(restClient, defaultSerializationSettings);
        public PolicyCapacityDashboard PolicyCapacityDashboardModule => new PolicyCapacityDashboard(restClient, defaultSerializationSettings);
        public PolicyIDS PolicyIDSModule => new PolicyIDS(restClient, defaultSerializationSettings);
        public PolicyVpnLayer2VPN PolicyVpnLayer2VPNModule => new PolicyVpnLayer2VPN(restClient, defaultSerializationSettings);
        public Search SearchModule => new Search(restClient, defaultSerializationSettings);
        public PolicyForwardingStats PolicyForwardingStatsModule => new PolicyForwardingStats(restClient, defaultSerializationSettings);
        public PolicyFirewallSessionTimerProfile PolicyFirewallSessionTimerProfileModule => new PolicyFirewallSessionTimerProfile(restClient, defaultSerializationSettings);
        public PolicyCertificate PolicyCertificateModule => new PolicyCertificate(restClient, defaultSerializationSettings);
        public ClusterRestore ClusterRestoreModule => new ClusterRestore(restClient, defaultSerializationSettings);
        public PolicyHeatmap PolicyHeatmapModule => new PolicyHeatmap(restClient, defaultSerializationSettings);
        public PolicySecurityProfileBinding PolicySecurityProfileBindingModule => new PolicySecurityProfileBinding(restClient, defaultSerializationSettings);
        public PolicyTlsPolicy PolicyTlsPolicyModule => new PolicyTlsPolicy(restClient, defaultSerializationSettings);
        public PolicyServiceInsertion PolicyServiceInsertionModule => new PolicyServiceInsertion(restClient, defaultSerializationSettings);
        public PolicyEdgeFirewall PolicyEdgeFirewallModule => new PolicyEdgeFirewall(restClient, defaultSerializationSettings);
        public PolicyLatency PolicyLatencyModule => new PolicyLatency(restClient, defaultSerializationSettings);
        public PolicyL2Vpn PolicyL2VpnModule => new PolicyL2Vpn(restClient, defaultSerializationSettings);
        public PolicySiteGM PolicySiteGMModule => new PolicySiteGM(restClient, defaultSerializationSettings);
        public PolicyMetadataProxy PolicyMetadataProxyModule => new PolicyMetadataProxy(restClient, defaultSerializationSettings);
        public PolicyNvdsUpgradeReadinessCheck PolicyNvdsUpgradeReadinessCheckModule => new PolicyNvdsUpgradeReadinessCheck(restClient, defaultSerializationSettings);
        public PolicySpoofGuard PolicySpoofGuardModule => new PolicySpoofGuard(restClient, defaultSerializationSettings);
        public L7AccessProfile L7AccessProfileModule => new L7AccessProfile(restClient, defaultSerializationSettings);
        public Policy PolicyModule => new Policy(restClient, defaultSerializationSettings);
        public PolicyCloudNative PolicyCloudNativeModule => new PolicyCloudNative(restClient, defaultSerializationSettings);
        public DfwSecurityPolicy DfwSecurityPolicyModule => new DfwSecurityPolicy(restClient, defaultSerializationSettings);
        public PolicyTask PolicyTaskModule => new PolicyTask(restClient, defaultSerializationSettings);
        public PolicyDfw PolicyDfwModule => new PolicyDfw(restClient, defaultSerializationSettings);
        public PolicyFirewallSessionTimerProfileBinding PolicyFirewallSessionTimerProfileBindingModule => new PolicyFirewallSessionTimerProfileBinding(restClient, defaultSerializationSettings);
        public PolicyIpam PolicyIpamModule => new PolicyIpam(restClient, defaultSerializationSettings);
        public PolicyLabel PolicyLabelModule => new PolicyLabel(restClient, defaultSerializationSettings);
        public PolicyALBControllerDeployment PolicyALBControllerDeploymentModule => new PolicyALBControllerDeployment(restClient, defaultSerializationSettings);
        public VMTagReplicationPolicy VMTagReplicationPolicyModule => new VMTagReplicationPolicy(restClient, defaultSerializationSettings);
        public PolicyBaseHostSwitchProfile PolicyBaseHostSwitchProfileModule => new PolicyBaseHostSwitchProfile(restClient, defaultSerializationSettings);
        public PolicyDnsForwarder PolicyDnsForwarderModule => new PolicyDnsForwarder(restClient, defaultSerializationSettings);
        public PolicyIDSStats PolicyIDSStatsModule => new PolicyIDSStats(restClient, defaultSerializationSettings);
        public PolicyLBStatistics PolicyLBStatisticsModule => new PolicyLBStatistics(restClient, defaultSerializationSettings);
        public PolicyAuthz PolicyAuthzModule => new PolicyAuthz(restClient, defaultSerializationSettings);
        public LdapIdentitySources LdapIdentitySourcesModule => new LdapIdentitySources(restClient, defaultSerializationSettings);
        public PolicyL3Vpn PolicyL3VpnModule => new PolicyL3Vpn(restClient, defaultSerializationSettings);
        public PolicyProfile PolicyProfileModule => new PolicyProfile(restClient, defaultSerializationSettings);
        public PolicyFullSync PolicyFullSyncModule => new PolicyFullSync(restClient, defaultSerializationSettings);
        public NsxDashboard NsxDashboardModule => new NsxDashboard(restClient, defaultSerializationSettings);
        public PolicyHostTransportNode PolicyHostTransportNodeModule => new PolicyHostTransportNode(restClient, defaultSerializationSettings);
        public PolicyTlsState PolicyTlsStateModule => new PolicyTlsState(restClient, defaultSerializationSettings);
        public AAA AAAModule => new AAA(restClient, defaultSerializationSettings);
        public PolicyQoSProfileBinding PolicyQoSProfileBindingModule => new PolicyQoSProfileBinding(restClient, defaultSerializationSettings);
        public PolicyShaAppliance PolicyShaApplianceModule => new PolicyShaAppliance(restClient, defaultSerializationSettings);
        public PolicyCloudNativeCommonAgent PolicyCloudNativeCommonAgentModule => new PolicyCloudNativeCommonAgent(restClient, defaultSerializationSettings);
        public Tasks TasksModule => new Tasks(restClient, defaultSerializationSettings);
        public PolicyContextProfile PolicyContextProfileModule => new PolicyContextProfile(restClient, defaultSerializationSettings);
        public PolicyPortMirroring PolicyPortMirroringModule => new PolicyPortMirroring(restClient, defaultSerializationSettings);
        public PolicyIDSMetrics PolicyIDSMetricsModule => new PolicyIDSMetrics(restClient, defaultSerializationSettings);
        public PolicySitesSpan PolicySitesSpanModule => new PolicySitesSpan(restClient, defaultSerializationSettings);
        public PolicyCloudNativePlatform PolicyCloudNativePlatformModule => new PolicyCloudNativePlatform(restClient, defaultSerializationSettings);
        public BackupConfiguration BackupConfigurationModule => new BackupConfiguration(restClient, defaultSerializationSettings);
        public HostTransportNodeCollection HostTransportNodeCollectionModule => new HostTransportNodeCollection(restClient, defaultSerializationSettings);
        public PolicyQoS PolicyQoSModule => new PolicyQoS(restClient, defaultSerializationSettings);
        public PolicyGuestIntrospection PolicyGuestIntrospectionModule => new PolicyGuestIntrospection(restClient, defaultSerializationSettings);
        public PolicyUrlCategorization PolicyUrlCategorizationModule => new PolicyUrlCategorization(restClient, defaultSerializationSettings);
        public PolicyCloudNativeUpgradeCoordinator PolicyCloudNativeUpgradeCoordinatorModule => new PolicyCloudNativeUpgradeCoordinator(restClient, defaultSerializationSettings);
        public PolicyIPSecVpn PolicyIPSecVpnModule => new PolicyIPSecVpn(restClient, defaultSerializationSettings);
        public PolicyGroupStatistics PolicyGroupStatisticsModule => new PolicyGroupStatistics(restClient, defaultSerializationSettings);
        public PolicyTlsConfigProfile PolicyTlsConfigProfileModule => new PolicyTlsConfigProfile(restClient, defaultSerializationSettings);
        public PolicyTransportZoneProfile PolicyTransportZoneProfileModule => new PolicyTransportZoneProfile(restClient, defaultSerializationSettings);
        public PolicyReaction PolicyReactionModule => new PolicyReaction(restClient, defaultSerializationSettings);
        public EULA EULAModule => new EULA(restClient, defaultSerializationSettings);
        public PolicyTransportZone PolicyTransportZoneModule => new PolicyTransportZone(restClient, defaultSerializationSettings);
        public PolicyFirewallScheduler PolicyFirewallSchedulerModule => new PolicyFirewallScheduler(restClient, defaultSerializationSettings);
        public PolicyAntiMalware PolicyAntiMalwareModule => new PolicyAntiMalware(restClient, defaultSerializationSettings);
        public PolicyDraft PolicyDraftModule => new PolicyDraft(restClient, defaultSerializationSettings);
        public PolicyCompliance PolicyComplianceModule => new PolicyCompliance(restClient, defaultSerializationSettings);
        public PolicyTag PolicyTagModule => new PolicyTag(restClient, defaultSerializationSettings);
        public PolicyFirewallFloodProtectionProfileBinding PolicyFirewallFloodProtectionProfileBindingModule => new PolicyFirewallFloodProtectionProfileBinding(restClient, defaultSerializationSettings);
        public ErrorResolver ErrorResolverModule => new ErrorResolver(restClient, defaultSerializationSettings);
        public FederationObservability FederationObservabilityModule => new FederationObservability(restClient, defaultSerializationSettings);
        public PolicyFirewallDnsSecurityProfileBinding PolicyFirewallDnsSecurityProfileBindingModule => new PolicyFirewallDnsSecurityProfileBinding(restClient, defaultSerializationSettings);
        public PolicySystemConfig PolicySystemConfigModule => new PolicySystemConfig(restClient, defaultSerializationSettings);
        public PolicyIPFIXSwitch PolicyIPFIXSwitchModule => new PolicyIPFIXSwitch(restClient, defaultSerializationSettings);
        public PolicyGatewaySecurityFeature PolicyGatewaySecurityFeatureModule => new PolicyGatewaySecurityFeature(restClient, defaultSerializationSettings);
        public Batch BatchModule => new Batch(restClient, defaultSerializationSettings);
        public PolicyTlsActionProfile PolicyTlsActionProfileModule => new PolicyTlsActionProfile(restClient, defaultSerializationSettings);
        public VersionWhitelist VersionWhitelistModule => new VersionWhitelist(restClient, defaultSerializationSettings);
        public PolicyConstraints PolicyConstraintsModule => new PolicyConstraints(restClient, defaultSerializationSettings);
        public PolicyIpDiscovery PolicyIpDiscoveryModule => new PolicyIpDiscovery(restClient, defaultSerializationSettings);
        public PolicyFineTuning PolicyFineTuningModule => new PolicyFineTuning(restClient, defaultSerializationSettings);
        public ConfigManagement ConfigManagementModule => new ConfigManagement(restClient, defaultSerializationSettings);
        public PolicyLldpInterface PolicyLldpInterfaceModule => new PolicyLldpInterface(restClient, defaultSerializationSettings);
        public PolicyIdfwLoginLogoutEvents PolicyIdfwLoginLogoutEventsModule => new PolicyIdfwLoginLogoutEvents(restClient, defaultSerializationSettings);
        public RegistrationTokenEndPoint RegistrationTokenEndPointModule => new RegistrationTokenEndPoint(restClient, defaultSerializationSettings);
        public PolicyStaticMimeContent PolicyStaticMimeContentModule => new PolicyStaticMimeContent(restClient, defaultSerializationSettings);
        public PolicySiteOffboarding PolicySiteOffboardingModule => new PolicySiteOffboarding(restClient, defaultSerializationSettings);
        public PolicyOperations PolicyOperationsModule => new PolicyOperations(restClient, defaultSerializationSettings);
    }
}