using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTALBVirtualServiceType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_auth")]
        public NSXTALBHTTPClientAuthenticationParamsType ClientAuth { get; set; }
        /// <summary>
        /// The pool is an object that contains destination servers and
        /// related attributes such as load-balancing and persistence.
        /// It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "pool_path")]
        public string? PoolPath { get; set; }
        /// <summary>
        /// Select SSL Profile based on client IP address match.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_profile_selectors")]
        public IList<NSXTALBSSLProfileSelectorType> SslProfileSelectors { get; set; }
        /// <summary>
        /// The pool group is an object that contains pools.
        /// It is a reference to an object of type PoolGroup.
        /// </summary>
        [JsonProperty(PropertyName = "pool_group_path")]
        public string? PoolGroupPath { get; set; }
        /// <summary>
        /// Service discovery specific data including fully qualified
        /// domain name, type and Time-To-Live of the DNS record.
        /// Note that only one of fqdn and dns_info setting is allowed.
        /// Maximum of 1000 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "dns_info")]
        public IList<NSXTALBDnsInfoType> DnsInfo { get; set; }
        /// <summary>
        /// Criteria for flow distribution among SEs.
        /// Enum options - LOAD_AWARE,
        /// CONSISTENT_HASH_SOURCE_IP_ADDRESS,
        /// CONSISTENT_HASH_SOURCE_IP_ADDRESS_AND_PORT.
        /// Allowed in Basic(Allowed values- LOAD_AWARE) edition,
        /// Essentials(Allowed values- LOAD_AWARE) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as LOAD_AWARE.
        /// </summary>
        [JsonProperty(PropertyName = "flow_dist")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbvirtualServiceFlowDistEnumType? FlowDist { get; set; }
        /// <summary>
        /// Determines the set of SSL versions and ciphers to accept
        /// for SSL/TLS terminated connections.
        /// It is a reference to an object of type SSLProfile.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_profile_path")]
        public string? SslProfilePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "content_rewrite")]
        public NSXTALBContentRewriteProfileType ContentRewrite { get; set; }
        /// <summary>
        /// Select the algorithm for QoS fairness.
        /// This determines how multiple Virtual Services sharing the
        /// same Service Engines will prioritize traffic over a
        /// congested network.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "delay_fairness")]
        public bool? DelayFairness { get; set; }
        /// <summary>
        /// List of Virtual Service IPs.
        /// While creating a 'Shared VS',please use vsvip_ref to point
        /// to the shared entities.
        /// </summary>
        [JsonProperty(PropertyName = "vip")]
        public IList<NSXTALBVipType> Vip { get; set; }
        /// <summary>
        /// NAT'ted floating source IP Address(es) for upstream
        /// connection to servers.
        /// Maximum of 32 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "snat_ip")]
        public IList<NSXTALBIpAddrType> SnatIp { get; set; }
        /// <summary>
        /// Creator name.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// The name of the Contract/Graph associated with the Virtual
        /// Service.
        /// Should be in the <Contract name> <Graph name> format.
        /// This is applicable only for Service Integration mode with
        /// Cisco APIC Controller.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "apic_contract_graph")]
        public string? ApicContractGraph { get; set; }
        /// <summary>
        /// Virtual Routing Context that the Virtual Service is bound
        /// to.
        /// This is used to provide the isolation of the set of
        /// networks the application is attached to.
        /// It is a reference to an object of type VrfContext.
        /// </summary>
        [JsonProperty(PropertyName = "vrf_context_name")]
        public string? VrfContextName { get; set; }
        /// <summary>
        /// Enable Route Health Injection for Source NAT'ted floating
        /// IP Address using the BGP Config in the vrf context.
        /// </summary>
        [JsonProperty(PropertyName = "enable_rhi_snat")]
        public bool? EnableRhiSnat { get; set; }
        /// <summary>
        /// Determines network settings such as protocol, TCP or UDP,
        /// and related options for the protocol.
        /// It is a reference to an object of type NetworkProfile.
        /// Special default for Essentials edition is
        /// System-TCP-Fast-Path.
        /// </summary>
        [JsonProperty(PropertyName = "network_profile_path")]
        public string? NetworkProfilePath { get; set; }
        /// <summary>
        /// Metadata pertaining to the Service provided by this virtual
        /// service.
        /// In Openshift/Kubernetes environments, egress pod info is
        /// stored.
        /// Any user input to this field will be overwritten by Avi
        /// Vantage.
        /// </summary>
        [JsonProperty(PropertyName = "service_metadata")]
        public string? ServiceMetadata { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "sideband_profile")]
        public NSXTALBSidebandProfileType SidebandProfile { get; set; }
        /// <summary>
        /// Server network or list of servers for cloning traffic.
        /// It is a reference to an object of type TrafficCloneProfile.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "traffic_clone_profile_path")]
        public string? TrafficCloneProfilePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "requests_rate_limit")]
        public NSXTALBRateProfileType RequestsRateLimit { get; set; }
        /// <summary>
        /// (This is a beta feature).
        /// Sync Key-Value cache to the new SEs when VS is scaled out.
        /// For ex  SSL sessions are stored using VS's Key-Value cache.
        /// When the VS is scaled out, the SSL session information is
        /// synced to the new SE, allowing existing SSL sessions to be
        /// reused on the new SE.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "bulk_sync_kvcache")]
        public bool? BulkSyncKvcache { get; set; }
        /// <summary>
        /// The SSO Policy attached to the virtualservice.
        /// It is a reference to an object of type SSOPolicy.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "sso_policy_path")]
        public string? SsoPolicyPath { get; set; }
        /// <summary>
        /// Enum options - CLOUD_NONE, CLOUD_VCENTER, CLOUD_OPENSTACK,
        /// CLOUD_AWS, CLOUD_VCA, CLOUD_APIC, CLOUD_MESOS,
        /// CLOUD_LINUXSERVER, CLOUD_DOCKER_UCP, CLOUD_RANCHER,
        /// CLOUD_OSHIFT_K8S, CLOUD_AZURE, CLOUD_GCP, CLOUD_NSXT.
        /// Allowed in Basic(Allowed values- CLOUD_NONE,CLOUD_NSXT)
        /// edition, Essentials(Allowed values-
        /// CLOUD_NONE,CLOUD_VCENTER) edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as CLOUD_NONE.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbvirtualServiceCloudTypeEnumType? CloudType { get; set; }
        /// <summary>
        /// The Quality of Service weight to assign to traffic
        /// transmitted from this Virtual Service.
        /// A higher weight will prioritize traffic versus other
        /// Virtual Services sharing the same Service Engines.
        /// Allowed values are 1-128.
        /// Allowed in Basic(Allowed values- 1) edition,
        /// Essentials(Allowed values- 1) edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public long? Weight { get; set; }
        /// <summary>
        /// The exact name requested from the client's SNI-enabled TLS
        /// hello domain name field.
        /// If this is a match, the parent VS will forward the
        /// connection to this child VS.
        /// </summary>
        [JsonProperty(PropertyName = "vh_domain_name")]
        public IList<string> VhDomainName { get; set; }
        /// <summary>
        /// Keep advertising Virtual Service via BGP even if it is
        /// marked down by health monitor.
        /// This setting takes effect for future Virtual Service flaps.
        /// To advertise current VSes that are down, please disable and
        /// re-enable the Virtual Service.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "advertise_down_vs")]
        public bool? AdvertiseDownVs { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "saml_sp_config")]
        public NSXTALBSAMLSPConfigType SamlSpConfig { get; set; }
        /// <summary>
        /// Mostly used during the creation of Shared VS, this field
        /// refers to entities that can be shared across Virtual
        /// Services.
        /// It is a reference to an object of type VsVip.
        /// </summary>
        [JsonProperty(PropertyName = "vsvip_path")]
        public string? VsvipPath { get; set; }
        /// <summary>
        /// Topology Policies applied on the dns traffic of the Virtual
        /// Service based onGSLB Topology algorithm.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "topology_policies")]
        public IList<NSXTALBDnsPoliciesType> TopologyPolicies { get; set; }
        /// <summary>
        /// Minimum number of UP pools to mark VS up.
        /// </summary>
        [JsonProperty(PropertyName = "min_pools_up")]
        public long? MinPoolsUp { get; set; }
        /// <summary>
        /// Maximum connections per second per client IP.
        /// Allowed values are 10-1000.
        /// Special values are 0- 'unlimited'.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "max_cps_per_client")]
        public long? MaxCpsPerClient { get; set; }
        /// <summary>
        /// Network security policies for the Virtual Service.
        /// It is a reference to an object of type
        /// NetworkSecurityPolicy.
        /// </summary>
        [JsonProperty(PropertyName = "network_security_policy_path")]
        public string? NetworkSecurityPolicyPath { get; set; }
        /// <summary>
        /// Checksum of cloud configuration for VS.
        /// Internally set by cloud connector.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_config_cksum")]
        public string? CloudConfigCksum { get; set; }
        /// <summary>
        /// Knob to enable the Virtual Service traffic on its assigned
        /// service engines.
        /// This setting is effective only when the enabled flag is set
        /// to True.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "traffic_enabled")]
        public bool? TrafficEnabled { get; set; }
        /// <summary>
        /// (internal-use)Applicable for Azure only.
        /// Azure Availability set to which this VS is associated.
        /// Internally set by the cloud connector.
        /// </summary>
        [JsonProperty(PropertyName = "azure_availability_set")]
        public string? AzureAvailabilitySet { get; set; }
        /// <summary>
        /// Expected number of SSL session cache entries (may be
        /// exceeded).
        /// Allowed values are 1024-16383.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1024.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_sess_cache_avg_size")]
        public long? SslSessCacheAvgSize { get; set; }
        /// <summary>
        /// Datascripts applied on the data traffic of the Virtual
        /// Service.
        /// </summary>
        [JsonProperty(PropertyName = "vs_datascripts")]
        public IList<NSXTALBVSDataScriptsType> VsDatascripts { get; set; }
        /// <summary>
        /// L4 Policies applied to the data traffic of the Virtual
        /// Service.
        /// </summary>
        [JsonProperty(PropertyName = "l4_policies")]
        public IList<NSXTALBL4PoliciesType> L4Policies { get; set; }
        /// <summary>
        /// Use Bridge IP as VIP on each Host in Mesos deployments.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "use_bridge_ip_as_vip")]
        public bool? UseBridgeIpAsVip { get; set; }
        /// <summary>
        /// Process request even if invalid client certificate is
        /// presented.
        /// Datascript APIs need to be used for processing of such
        /// requests.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "allow_invalid_client_cert")]
        public bool? AllowInvalidClientCert { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "performance_limits")]
        public NSXTALBPerformanceLimitsType PerformanceLimits { get; set; }
        /// <summary>
        /// HTTP Policies applied on the data traffic of the Virtual
        /// Service.
        /// </summary>
        [JsonProperty(PropertyName = "http_policies")]
        public IList<NSXTALBHTTPPoliciesType> HttpPolicies { get; set; }
        /// <summary>
        /// WAF policy for the Virtual Service.
        /// It is a reference to an object of type WafPolicy.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "waf_policy_path")]
        public string? WafPolicyPath { get; set; }
        /// <summary>
        /// GSLB pools used to manage site-persistence functionality.
        /// Each site-persistence pool contains the virtualservices in
        /// all the other sites, that is auto-generated by the GSLB
        /// manager.
        /// This is a read-only field for the user.
        /// It is a reference to an object of type Pool.
        /// </summary>
        [JsonProperty(PropertyName = "sp_pool_paths")]
        public IList<string> SpPoolPaths { get; set; }
        /// <summary>
        /// This configuration only applies if the VirtualService is in
        /// Legacy Active Standby HA mode and Load Distribution among
        /// Active Standby is enabled.
        /// This field is used to tag the VirtualService so that
        /// VirtualServices with the same tag will share the same Active
        /// ServiceEngine.
        /// VirtualServices with different tags will have different
        /// Active ServiceEngines.
        /// If one of the ServiceEngine's in the ServiceEngineGroup
        /// fails, all VirtualServices will end up using the same Active
        /// ServiceEngine.
        /// Redistribution of the VirtualServices can be either manual
        /// or automated when the failed ServiceEngine recovers.
        /// Redistribution is based on the auto redistribute property
        /// of the ServiceEngineGroup.
        /// Enum options - ACTIVE_STANDBY_SE_1, ACTIVE_STANDBY_SE_2.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as ACTIVE_STANDBY_SE_1.
        /// </summary>
        [JsonProperty(PropertyName = "active_standby_se_tag")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbvirtualServiceActiveStandbySeTagEnumType? ActiveStandbySeTag { get; set; }
        /// <summary>
        /// Select or create one or two certificates, EC and/or RSA,
        /// that will be presented to SSL/TLS terminated connections.
        /// It is a reference to an object of type
        /// SSLKeyAndCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_key_and_certificate_paths")]
        public IList<string> SslKeyAndCertificatePaths { get; set; }
        /// <summary>
        /// It is a reference to an object of type Cloud.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_name")]
        public string? CloudName { get; set; }
        /// <summary>
        /// Translate the host name sent to the servers to this value.
        /// Translate the host name sent from servers back to the value
        /// used by the client.
        /// </summary>
        [JsonProperty(PropertyName = "host_name_xlate")]
        public string? HostNameXlate { get; set; }
        /// <summary>
        /// Select BGP peers, using peer label, for VsVip
        /// advertisement.
        /// Maximum of 128 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "bgp_peer_labels")]
        public IList<string> BgpPeerLabels { get; set; }
        /// <summary>
        /// Use the Virtual IP as the SNAT IP for health monitoring and
        /// sending traffic to the backend servers instead of the
        /// Service Engine interface IP.
        /// The caveat of enabling this option is that the
        /// VirtualService cannot be configured in an Active-Active HA
        /// mode.
        /// DNS based Multi VIP solution has to be used for HA &
        /// Non-disruptive Upgrade purposes.
        /// Allowed in Essentials(Allowed values- false) edition,
        /// Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "use_vip_as_snat")]
        public bool? UseVipAsSnat { get; set; }
        /// <summary>
        /// Enable application layer specific features for the Virtual
        /// Service.
        /// It is a reference to an object of type ApplicationProfile.
        /// Special default for Essentials edition is
        /// System-L4-Application.
        /// </summary>
        [JsonProperty(PropertyName = "application_profile_path")]
        public string? ApplicationProfilePath { get; set; }
        /// <summary>
        /// Specifies the Virtual Service acting as Virtual Hosting
        /// (SNI) parent.
        /// </summary>
        [JsonProperty(PropertyName = "vh_parent_vs_uuid")]
        public string? VhParentVsUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "connections_rate_limit")]
        public NSXTALBRateProfileType ConnectionsRateLimit { get; set; }
        /// <summary>
        /// The Service Engine Group to use for this Virtual Service.
        /// Moving to a new SE Group is disruptive to existing
        /// connections for this VS.
        /// It is a reference to an object of type ServiceEngineGroup.
        /// </summary>
        [JsonProperty(PropertyName = "se_group_name")]
        public string? SeGroupName { get; set; }
        /// <summary>
        /// Ignore Pool servers network reachability constraints for
        /// Virtual Service placement.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "ign_pool_net_reach")]
        public bool? IgnPoolNetReach { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
        /// <summary>
        /// Force placement on all SE's in service group (Mesos mode
        /// only).
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "east_west_placement")]
        public bool? EastWestPlacement { get; set; }
        /// <summary>
        /// Error Page Profile to be used for this virtualservice.This
        /// profile is used to send the custom error page to the client
        /// generated by the proxy.
        /// It is a reference to an object of type ErrorPageProfile.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "error_page_profile_path")]
        public string? ErrorPageProfilePath { get; set; }
        /// <summary>
        /// Limit potential DoS attackers who exceed max_cps_per_client
        /// significantly to a fraction of max_cps_per_client for a
        /// while.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "limit_doser")]
        public bool? LimitDoser { get; set; }
        /// <summary>
        /// Select pool based on destination port.
        /// </summary>
        [JsonProperty(PropertyName = "service_pool_select")]
        public IList<NSXTALBServicePoolSelectorType> ServicePoolSelect { get; set; }
        /// <summary>
        /// close client connection on vs config update.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "close_client_conn_on_config_update")]
        public bool? CloseClientConnOnConfigUpdate { get; set; }
        /// <summary>
        /// Specify if this is a normal Virtual Service, or if it is
        /// the parent or child of an SNI-enabled virtual hosted Virtual
        /// Service.
        /// Enum options - VS_TYPE_NORMAL, VS_TYPE_VH_PARENT,
        /// VS_TYPE_VH_CHILD.
        /// Allowed in Basic(Allowed values-
        /// VS_TYPE_NORMAL,VS_TYPE_VH_PARENT) edition,
        /// Essentials(Allowed values- VS_TYPE_NORMAL) edition,
        /// Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as VS_TYPE_NORMAL.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbvirtualServiceTypeEnumType? Type { get; set; }
        /// <summary>
        /// Response traffic to clients will be sent back to the source
        /// MAC address of the connection, rather than statically sent
        /// to a default gateway.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Special default for Basic edition is false, Essentials
        /// edition is false, Enterprise is True.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enable_autogw")]
        public bool? EnableAutogw { get; set; }
        /// <summary>
        /// A list of NSX Groups representing the Clients which can
        /// access the Virtual IP of the Virtual Service.
        /// </summary>
        [JsonProperty(PropertyName = "group_paths")]
        public IList<string> GroupPaths { get; set; }
        /// <summary>
        /// Enable or disable the Virtual Service.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Remove listening port if VirtualService is down.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "remove_listening_port_on_vs_down")]
        public bool? RemoveListeningPortOnVsDown { get; set; }
        /// <summary>
        /// DNS resolvable, fully qualified domain name of the
        /// virtualservice.
        /// Only one of 'fqdn' and 'dns_info' configuration is allowed.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string? Fqdn { get; set; }
        /// <summary>
        /// DNS Policies applied on the dns traffic of the Virtual
        /// Service.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "dns_policies")]
        public IList<NSXTALBDnsPoliciesType> DnsPolicies { get; set; }
        /// <summary>
        /// List of static DNS records applied to this Virtual Service.
        /// These are static entries and no health monitoring is
        /// performed against the IP addresses.
        /// Maximum of 1000 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "static_dns_records")]
        public IList<NSXTALBDnsRecordType> StaticDnsRecords { get; set; }
        /// <summary>
        /// List of Services defined for this Virtual Service.
        /// Maximum of 2048 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public IList<NSXTALBServiceType> Services { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "analytics_policy")]
        public NSXTALBAnalyticsPolicyType AnalyticsPolicy { get; set; }
        /// <summary>
        /// Enable Route Health Injection using the BGP Config in the
        /// vrf context.
        /// </summary>
        [JsonProperty(PropertyName = "enable_rhi")]
        public bool? EnableRhi { get; set; }
        /// <summary>
        /// Determines the network settings profile for the server side
        /// of TCP proxied connections.
        /// Leave blank to use the same settings as the client to VS
        /// side of the connection.
        /// It is a reference to an object of type NetworkProfile.
        /// </summary>
        [JsonProperty(PropertyName = "server_network_profile_path")]
        public string? ServerNetworkProfilePath { get; set; }
        /// <summary>
        /// Specifies settings related to analytics.
        /// It is a reference to an object of type AnalyticsProfile.
        /// </summary>
        [JsonProperty(PropertyName = "analytics_profile_path")]
        public string? AnalyticsProfilePath { get; set; }
        /// <summary>
        /// Security policy applied on the traffic of the Virtual
        /// Service.
        /// This policy is used to perform security actions such as
        /// Distributed Denial of Service (DDoS) attack mitigation, etc.
        /// It is a reference to an object of type SecurityPolicy.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "security_policy_path")]
        public string? SecurityPolicyPath { get; set; }
        /// <summary>
        /// Criteria for flow labelling.
        /// Enum options - NO_LABEL, APPLICATION_LABEL, SERVICE_LABEL.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as NO_LABEL.
        /// </summary>
        [JsonProperty(PropertyName = "flow_label_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbvirtualServiceFlowLabelTypeEnumType? FlowLabelType { get; set; }
    }
}
