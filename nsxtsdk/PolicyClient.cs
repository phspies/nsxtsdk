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
using System.Threading;

namespace nsxtsdk
{
    public class PolicyEngine
    {
        JsonSerializerSettings defaultSerializationSettings;
        RestClient restClient;
        private CancellationToken cancellationToken;
        private int timeout;
        private int retry;
        public PolicyEngine(RestClient RestClient, JsonSerializerSettings DefaultSerializationSettings, CancellationToken _cancellationToken = default(CancellationToken), int Port = 443, int _timeout = 5, int _retry = 2)
        {
            cancellationToken = _cancellationToken;
            timeout = _timeout;
            retry = _retry;
            restClient = RestClient;
            restClient.BaseUrl = new Uri($"{restClient.BaseUrl.GetLeftPart(System.UriPartial.Authority)}/policy/api/v1");
            defaultSerializationSettings = DefaultSerializationSettings;
        }
        public PolicyRealizedState PolicyRealizedStateModule => new PolicyRealizedState(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyConnectivityStatistics PolicyConnectivityStatisticsModule => new PolicyConnectivityStatistics(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyOspf PolicyOspfModule => new PolicyOspf(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyAdvancedLoadBalancer PolicyAdvancedLoadBalancerModule => new PolicyAdvancedLoadBalancer(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyConnectivity PolicyConnectivityModule => new PolicyConnectivity(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyMonitoringProfileBinding PolicyMonitoringProfileBindingModule => new PolicyMonitoringProfileBinding(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyFirewallConfiguration PolicyFirewallConfigurationModule => new PolicyFirewallConfiguration(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicySha PolicyShaModule => new PolicySha(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyLoadBalancer PolicyLoadBalancerModule => new PolicyLoadBalancer(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyNAT PolicyNATModule => new PolicyNAT(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ClusterControlPlane ClusterControlPlaneModule => new ClusterControlPlane(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyGroupRealization PolicyGroupRealizationModule => new PolicyGroupRealization(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyDNSStatistics PolicyDNSStatisticsModule => new PolicyDNSStatistics(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyVPNStatistics PolicyVPNStatisticsModule => new PolicyVPNStatistics(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyGatewayProfileBinding PolicyGatewayProfileBindingModule => new PolicyGatewayProfileBinding(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyDiscoveryProfileBinding PolicyDiscoveryProfileBindingModule => new PolicyDiscoveryProfileBinding(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyIDSGateway PolicyIDSGatewayModule => new PolicyIDSGateway(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyForwarding PolicyForwardingModule => new PolicyForwarding(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyIPFIXDFW PolicyIPFIXDFWModule => new PolicyIPFIXDFW(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyLayer2VPN PolicyLayer2VPNModule => new PolicyLayer2VPN(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyVpnIPSecVpn PolicyVpnIPSecVpnModule => new PolicyVpnIPSecVpn(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyEnforcementPointManagement PolicyEnforcementPointManagementModule => new PolicyEnforcementPointManagement(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyFirewallCPUMemThresholdsProfileBinding PolicyFirewallCPUMemThresholdsProfileBindingModule => new PolicyFirewallCPUMemThresholdsProfileBinding(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyIdentity PolicyIdentityModule => new PolicyIdentity(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyHostTransportNodeProfile PolicyHostTransportNodeProfileModule => new PolicyHostTransportNodeProfile(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyMulticast PolicyMulticastModule => new PolicyMulticast(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyMacDiscovery PolicyMacDiscoveryModule => new PolicyMacDiscovery(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyAntreaMonitoring PolicyAntreaMonitoringModule => new PolicyAntreaMonitoring(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicySegmentSecurity PolicySegmentSecurityModule => new PolicySegmentSecurity(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyCapacityDashboard PolicyCapacityDashboardModule => new PolicyCapacityDashboard(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyIDS PolicyIDSModule => new PolicyIDS(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyVpnLayer2VPN PolicyVpnLayer2VPNModule => new PolicyVpnLayer2VPN(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Search SearchModule => new Search(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyForwardingStats PolicyForwardingStatsModule => new PolicyForwardingStats(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyFirewallSessionTimerProfile PolicyFirewallSessionTimerProfileModule => new PolicyFirewallSessionTimerProfile(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyCertificate PolicyCertificateModule => new PolicyCertificate(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ClusterRestore ClusterRestoreModule => new ClusterRestore(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyHeatmap PolicyHeatmapModule => new PolicyHeatmap(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicySecurityProfileBinding PolicySecurityProfileBindingModule => new PolicySecurityProfileBinding(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyTlsPolicy PolicyTlsPolicyModule => new PolicyTlsPolicy(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyServiceInsertion PolicyServiceInsertionModule => new PolicyServiceInsertion(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyEdgeFirewall PolicyEdgeFirewallModule => new PolicyEdgeFirewall(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyLatency PolicyLatencyModule => new PolicyLatency(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyL2Vpn PolicyL2VpnModule => new PolicyL2Vpn(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicySiteGM PolicySiteGMModule => new PolicySiteGM(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyMetadataProxy PolicyMetadataProxyModule => new PolicyMetadataProxy(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyNvdsUpgradeReadinessCheck PolicyNvdsUpgradeReadinessCheckModule => new PolicyNvdsUpgradeReadinessCheck(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicySpoofGuard PolicySpoofGuardModule => new PolicySpoofGuard(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public L7AccessProfile L7AccessProfileModule => new L7AccessProfile(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Policy PolicyModule => new Policy(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyCloudNative PolicyCloudNativeModule => new PolicyCloudNative(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public DfwSecurityPolicy DfwSecurityPolicyModule => new DfwSecurityPolicy(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyTask PolicyTaskModule => new PolicyTask(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyDfw PolicyDfwModule => new PolicyDfw(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyFirewallSessionTimerProfileBinding PolicyFirewallSessionTimerProfileBindingModule => new PolicyFirewallSessionTimerProfileBinding(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyIpam PolicyIpamModule => new PolicyIpam(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyLabel PolicyLabelModule => new PolicyLabel(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyALBControllerDeployment PolicyALBControllerDeploymentModule => new PolicyALBControllerDeployment(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public VMTagReplicationPolicy VMTagReplicationPolicyModule => new VMTagReplicationPolicy(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyBaseHostSwitchProfile PolicyBaseHostSwitchProfileModule => new PolicyBaseHostSwitchProfile(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyDnsForwarder PolicyDnsForwarderModule => new PolicyDnsForwarder(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyIDSStats PolicyIDSStatsModule => new PolicyIDSStats(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyLBStatistics PolicyLBStatisticsModule => new PolicyLBStatistics(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyAuthz PolicyAuthzModule => new PolicyAuthz(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public LdapIdentitySources LdapIdentitySourcesModule => new LdapIdentitySources(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyL3Vpn PolicyL3VpnModule => new PolicyL3Vpn(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyProfile PolicyProfileModule => new PolicyProfile(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyFullSync PolicyFullSyncModule => new PolicyFullSync(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public NsxDashboard NsxDashboardModule => new NsxDashboard(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyHostTransportNode PolicyHostTransportNodeModule => new PolicyHostTransportNode(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyTlsState PolicyTlsStateModule => new PolicyTlsState(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public AAA AAAModule => new AAA(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyQoSProfileBinding PolicyQoSProfileBindingModule => new PolicyQoSProfileBinding(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyShaAppliance PolicyShaApplianceModule => new PolicyShaAppliance(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyCloudNativeCommonAgent PolicyCloudNativeCommonAgentModule => new PolicyCloudNativeCommonAgent(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Tasks TasksModule => new Tasks(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyContextProfile PolicyContextProfileModule => new PolicyContextProfile(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyPortMirroring PolicyPortMirroringModule => new PolicyPortMirroring(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyIDSMetrics PolicyIDSMetricsModule => new PolicyIDSMetrics(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicySitesSpan PolicySitesSpanModule => new PolicySitesSpan(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyCloudNativePlatform PolicyCloudNativePlatformModule => new PolicyCloudNativePlatform(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public BackupConfiguration BackupConfigurationModule => new BackupConfiguration(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public HostTransportNodeCollection HostTransportNodeCollectionModule => new HostTransportNodeCollection(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyQoS PolicyQoSModule => new PolicyQoS(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyGuestIntrospection PolicyGuestIntrospectionModule => new PolicyGuestIntrospection(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyUrlCategorization PolicyUrlCategorizationModule => new PolicyUrlCategorization(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyCloudNativeUpgradeCoordinator PolicyCloudNativeUpgradeCoordinatorModule => new PolicyCloudNativeUpgradeCoordinator(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyIPSecVpn PolicyIPSecVpnModule => new PolicyIPSecVpn(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyGroupStatistics PolicyGroupStatisticsModule => new PolicyGroupStatistics(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyTlsConfigProfile PolicyTlsConfigProfileModule => new PolicyTlsConfigProfile(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyTransportZoneProfile PolicyTransportZoneProfileModule => new PolicyTransportZoneProfile(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyReaction PolicyReactionModule => new PolicyReaction(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public EULA EULAModule => new EULA(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyTransportZone PolicyTransportZoneModule => new PolicyTransportZone(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyFirewallScheduler PolicyFirewallSchedulerModule => new PolicyFirewallScheduler(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyAntiMalware PolicyAntiMalwareModule => new PolicyAntiMalware(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyDraft PolicyDraftModule => new PolicyDraft(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyCompliance PolicyComplianceModule => new PolicyCompliance(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyTag PolicyTagModule => new PolicyTag(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyFirewallFloodProtectionProfileBinding PolicyFirewallFloodProtectionProfileBindingModule => new PolicyFirewallFloodProtectionProfileBinding(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ErrorResolver ErrorResolverModule => new ErrorResolver(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public FederationObservability FederationObservabilityModule => new FederationObservability(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyFirewallDnsSecurityProfileBinding PolicyFirewallDnsSecurityProfileBindingModule => new PolicyFirewallDnsSecurityProfileBinding(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicySystemConfig PolicySystemConfigModule => new PolicySystemConfig(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyIPFIXSwitch PolicyIPFIXSwitchModule => new PolicyIPFIXSwitch(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyGatewaySecurityFeature PolicyGatewaySecurityFeatureModule => new PolicyGatewaySecurityFeature(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public Batch BatchModule => new Batch(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyTlsActionProfile PolicyTlsActionProfileModule => new PolicyTlsActionProfile(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public VersionWhitelist VersionWhitelistModule => new VersionWhitelist(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyConstraints PolicyConstraintsModule => new PolicyConstraints(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyIpDiscovery PolicyIpDiscoveryModule => new PolicyIpDiscovery(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyFineTuning PolicyFineTuningModule => new PolicyFineTuning(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public ConfigManagement ConfigManagementModule => new ConfigManagement(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyLldpInterface PolicyLldpInterfaceModule => new PolicyLldpInterface(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyIdfwLoginLogoutEvents PolicyIdfwLoginLogoutEventsModule => new PolicyIdfwLoginLogoutEvents(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public RegistrationTokenEndPoint RegistrationTokenEndPointModule => new RegistrationTokenEndPoint(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyStaticMimeContent PolicyStaticMimeContentModule => new PolicyStaticMimeContent(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicySiteOffboarding PolicySiteOffboardingModule => new PolicySiteOffboarding(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
        public PolicyOperations PolicyOperationsModule => new PolicyOperations(restClient, defaultSerializationSettings, cancellationToken, timeout, retry);
    }
}