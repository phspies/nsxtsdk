// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTALBPoolType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The load balancing algorithm will pick a server within the
        /// pool's list of available servers.
        /// Values LB_ALGORITHM_NEAREST_SERVER and
        /// LB_ALGORITHM_TOPOLOGY are only allowed for GSLB pool.
        /// Enum options - LB_ALGORITHM_LEAST_CONNECTIONS,
        /// LB_ALGORITHM_ROUND_ROBIN, LB_ALGORITHM_FASTEST_RESPONSE,
        /// LB_ALGORITHM_CONSISTENT_HASH, LB_ALGORITHM_LEAST_LOAD,
        /// LB_ALGORITHM_FEWEST_SERVERS, LB_ALGORITHM_RANDOM,
        /// LB_ALGORITHM_FEWEST_TASKS, LB_ALGORITHM_NEAREST_SERVER,
        /// LB_ALGORITHM_CORE_AFFINITY, LB_ALGORITHM_TOPOLOGY.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// LB_ALGORITHM_LEAST_CONNECTIONS.
        /// </summary>
        [JsonProperty(PropertyName = "lb_algorithm")]
        [NSXTProperty(IsRequired: false, Description: @"The load balancing algorithm will pick a server within thepool&apos;s list of available servers.Values LB_ALGORITHM_NEAREST_SERVER andLB_ALGORITHM_TOPOLOGY are only allowed for GSLB pool.Enum options - LB_ALGORITHM_LEAST_CONNECTIONS,LB_ALGORITHM_ROUND_ROBIN, LB_ALGORITHM_FASTEST_RESPONSE,LB_ALGORITHM_CONSISTENT_HASH, LB_ALGORITHM_LEAST_LOAD,LB_ALGORITHM_FEWEST_SERVERS, LB_ALGORITHM_RANDOM,LB_ALGORITHM_FEWEST_TASKS, LB_ALGORITHM_NEAREST_SERVER,LB_ALGORITHM_CORE_AFFINITY, LB_ALGORITHM_TOPOLOGY.Default value when not specified in API or module isinterpreted by ALB Controller asLB_ALGORITHM_LEAST_CONNECTIONS.")]
        [NSXTDefaultProperty(Default: "LB_ALGORITHM_LEAST_CONNECTIONS")]
        public NSXTAlbpoolLbAlgorithmEnumType? LbAlgorithm { get; set; }
        /// <summary>
        /// Do not translate the client's destination port when sending
        /// the connection to the server.
        /// The pool or servers specified service port will still be
        /// used for health monitoring.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "use_service_port")]
        [NSXTProperty(IsRequired: false, Description: @"Do not translate the client&apos;s destination port when sendingthe connection to the server.The pool or servers specified service port will still beused for health monitoring.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? UseServicePort { get; set; }
        /// <summary>
        /// Rewrite incoming Host Header to server name of the server
        /// to which the request is proxied.
        /// Enabling this feature rewrites Host Header for requests to
        /// all servers in the pool.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "rewrite_host_header_to_server_name")]
        [NSXTProperty(IsRequired: false, Description: @"Rewrite incoming Host Header to server name of the serverto which the request is proxied.Enabling this feature rewrites Host Header for requests toall servers in the pool.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? RewriteHostHeaderToServerName { get; set; }
        /// <summary>
        /// Enable common name check for server certificate.
        /// If enabled and no explicit domain name is specified, Avi
        /// will use the incoming host header to do the match.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "host_check_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Enable common name check for server certificate.If enabled and no explicit domain name is specified, Aviwill use the incoming host header to do the match.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? HostCheckEnabled { get; set; }
        /// <summary>
        /// Connnection pool properties.
        /// </summary>
        [JsonProperty(PropertyName = "conn_pool_properties")]
        [NSXTProperty(IsRequired: false, Description: @"Connnection pool properties.")]
        public NSXTALBConnPoolPropertiesType ConnPoolProperties { get; set; }
        /// <summary>
        /// If SNI server name is specified, rewrite incoming host
        /// header to the SNI server name.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "rewrite_host_header_to_sni")]
        [NSXTProperty(IsRequired: false, Description: @"If SNI server name is specified, rewrite incoming hostheader to the SNI server name.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? RewriteHostHeaderToSni { get; set; }
        /// <summary>
        /// Indicates whether existing IPs are disabled(false) or
        /// deleted(true) on dns hostname refreshDetail -- On a dns
        /// refresh, some IPs set on pool may no longer be returned by
        /// the resolver.
        /// These IPs are deleted from the pool when this knob is set
        /// to true.
        /// They are disabled, if the knob is set to false.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "delete_server_on_dns_refresh")]
        [NSXTProperty(IsRequired: false, Description: @"Indicates whether existing IPs are disabled(false) ordeleted(true) on dns hostname refreshDetail -- On a dnsrefresh, some IPs set on pool may no longer be returned bythe resolver.These IPs are deleted from the pool when this knob is setto true.They are disabled, if the knob is set to false.Default value when not specified in API or module isinterpreted by ALB Controller as true.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? DeleteServerOnDnsRefresh { get; set; }
        /// <summary>
        /// Inline estimation of capacity of servers.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "capacity_estimation")]
        [NSXTProperty(IsRequired: false, Description: @"Inline estimation of capacity of servers.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? CapacityEstimation { get; set; }
        /// <summary>
        /// Rate Limit connections to each server.
        /// </summary>
        [JsonProperty(PropertyName = "max_conn_rate_per_server")]
        [NSXTProperty(IsRequired: false, Description: @"Rate Limit connections to each server.")]
        public NSXTALBRateProfileType MaxConnRatePerServer { get; set; }
        /// <summary>
        /// The pool directs load balanced traffic to this list of
        /// destination servers.
        /// The servers can be configured by IP address, name, network
        /// or via IP Address Group.
        /// Maximum of 5000 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "servers")]
        [NSXTProperty(IsRequired: false, Description: @"The pool directs load balanced traffic to this list ofdestination servers.The servers can be configured by IP address, name, networkor via IP Address Group.Maximum of 5000 items allowed.")]
        public IList<NSXTALBServerType> Servers { get; set; }
        /// <summary>
        /// Periodicity of feedback for fewest tasks server selection
        /// algorithm.
        /// Allowed values are 1-300.
        /// Unit is SEC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 10.
        /// </summary>
        [JsonProperty(PropertyName = "fewest_tasks_feedback_delay")]
        [NSXTProperty(IsRequired: false, Description: @"Periodicity of feedback for fewest tasks server selectionalgorithm.Allowed values are 1-300.Unit is SEC.Default value when not specified in API or module isinterpreted by ALB Controller as 10.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(300)]
        [NSXTDefaultProperty(Default: "")]
        public long? FewestTasksFeedbackDelay { get; set; }
        /// <summary>
        /// Use list of servers from Ip Address Group.
        /// It is a reference to an object of type IpAddrGroup.
        /// </summary>
        [JsonProperty(PropertyName = "ipaddrgroup_path")]
        [NSXTProperty(IsRequired: false, Description: @"Use list of servers from Ip Address Group.It is a reference to an object of type IpAddrGroup.")]
        public string? IpaddrgroupPath { get; set; }
        /// <summary>
        /// Creator name.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        [NSXTProperty(IsRequired: false, Description: @"Creator name.")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// The maximum time-to-first-byte of a server.
        /// Allowed values are 1-5000.
        /// Special values are 0 - 'Automatic'.
        /// Unit is MILLISECONDS.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "capacity_estimation_ttfb_thresh")]
        [NSXTProperty(IsRequired: false, Description: @"The maximum time-to-first-byte of a server.Allowed values are 1-5000.Special values are 0 - &apos;Automatic&apos;.Unit is MILLISECONDS.Default value when not specified in API or module isinterpreted by ALB Controller as 0.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(5000)]
        [NSXTDefaultProperty(Default: "")]
        public long? CapacityEstimationTtfbThresh { get; set; }
        /// <summary>
        /// Minimum number of servers in UP state for marking the pool
        /// UP.
        /// </summary>
        [JsonProperty(PropertyName = "min_servers_up")]
        [NSXTProperty(IsRequired: false, Description: @"Minimum number of servers in UP state for marking the poolUP.")]
        public long? MinServersUp { get; set; }
        /// <summary>
        /// Enable an action - Close Connection, HTTP Redirect or Local
        /// HTTP Response - when a pool failure happens.
        /// By default, a connection will be closed, in case the pool
        /// experiences a failure.
        /// </summary>
        [JsonProperty(PropertyName = "fail_action")]
        [NSXTProperty(IsRequired: false, Description: @"Enable an action - Close Connection, HTTP Redirect or LocalHTTP Response - when a pool failure happens.By default, a connection will be closed, in case the poolexperiences a failure.")]
        public NSXTALBFailActionType FailAction { get; set; }
        /// <summary>
        /// Allow server lookup by name.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "lookup_server_by_name")]
        [NSXTProperty(IsRequired: false, Description: @"Allow server lookup by name.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? LookupServerByName { get; set; }
        /// <summary>
        /// (internal-use) Networks designated as containing servers
        /// for this pool.
        /// The servers may be further narrowed down by a filter.
        /// This field is used internally by Avi, not editable by the
        /// user.
        /// </summary>
        [JsonProperty(PropertyName = "networks")]
        [NSXTProperty(IsRequired: false, Description: @"(internal-use) Networks designated as containing serversfor this pool.The servers may be further narrowed down by a filter.This field is used internally by Avi, not editable by theuser.")]
        public IList<NSXTALBNetworkFilterType> Networks { get; set; }
        /// <summary>
        /// Criteria used as a key for determining the hash between the
        /// client and  server.
        /// Enum options -
        /// LB_ALGORITHM_CONSISTENT_HASH_SOURCE_IP_ADDRESS,
        /// LB_ALGORITHM_CONSISTENT_HASH_SOURCE_IP_ADDRESS_AND_PORT,
        /// LB_ALGORITHM_CONSISTENT_HASH_URI,
        /// LB_ALGORITHM_CONSISTENT_HASH_CUSTOM_HEADER,
        /// LB_ALGORITHM_CONSISTENT_HASH_CUSTOM_STRING,
        /// LB_ALGORITHM_CONSISTENT_HASH_CALLID.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// LB_ALGORITHM_CONSISTENT_HASH_SOURCE_IP_ADDRESS.
        /// </summary>
        [JsonProperty(PropertyName = "lb_algorithm_hash")]
        [NSXTProperty(IsRequired: false, Description: @"Criteria used as a key for determining the hash between theclient and  server.Enum options -LB_ALGORITHM_CONSISTENT_HASH_SOURCE_IP_ADDRESS,LB_ALGORITHM_CONSISTENT_HASH_SOURCE_IP_ADDRESS_AND_PORT,LB_ALGORITHM_CONSISTENT_HASH_URI,LB_ALGORITHM_CONSISTENT_HASH_CUSTOM_HEADER,LB_ALGORITHM_CONSISTENT_HASH_CUSTOM_STRING,LB_ALGORITHM_CONSISTENT_HASH_CALLID.Default value when not specified in API or module isinterpreted by ALB Controller asLB_ALGORITHM_CONSISTENT_HASH_SOURCE_IP_ADDRESS.")]
        [NSXTDefaultProperty(Default: "LB_ALGORITHM_CONSISTENT_HASH_SOURCE_IP_ADDRESS")]
        public NSXTAlbpoolLbAlgorithmHashEnumType? LbAlgorithmHash { get; set; }
        /// <summary>
        /// Metadata pertaining to the service provided by this Pool.
        /// In Openshift/Kubernetes environments, app metadata info is
        /// stored.
        /// Any user input to this field will be overwritten by Avi
        /// Vantage.
        /// </summary>
        [JsonProperty(PropertyName = "service_metadata")]
        [NSXTProperty(IsRequired: false, Description: @"Metadata pertaining to the service provided by this Pool.In Openshift/Kubernetes environments, app metadata info isstored.Any user input to this field will be overwritten by AviVantage.")]
        public string? ServiceMetadata { get; set; }
        /// <summary>
        /// Enable TLS SNI for server connections.
        /// If disabled, Avi will not send the SNI extension as part of
        /// the handshake.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "sni_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Enable TLS SNI for server connections.If disabled, Avi will not send the SNI extension as part ofthe handshake.Default value when not specified in API or module isinterpreted by ALB Controller as true.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? SniEnabled { get; set; }
        /// <summary>
        /// Fully qualified DNS hostname which will be used in the TLS
        /// SNI extension in server connections if SNI is enabled.
        /// If no value is specified, Avi will use the incoming host
        /// header instead.
        /// </summary>
        [JsonProperty(PropertyName = "server_name")]
        [NSXTProperty(IsRequired: false, Description: @"Fully qualified DNS hostname which will be used in the TLSSNI extension in server connections if SNI is enabled.If no value is specified, Avi will use the incoming hostheader instead.")]
        public string? ServerName { get; set; }
        /// <summary>
        /// This tier1_lr field should be set same as VirtualService
        /// associated for NSX-T.
        /// </summary>
        [JsonProperty(PropertyName = "tier1_path")]
        [NSXTProperty(IsRequired: false, Description: @"This tier1_lr field should be set same as VirtualServiceassociated for NSX-T.")]
        public string? Tier1Path { get; set; }
        /// <summary>
        /// Comma separated list of domain names which will be used to
        /// verify the common names or subject alternative names
        /// presented by server certificates.
        /// It is performed only when common name check
        /// host_check_enabled is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "domain_name")]
        [NSXTProperty(IsRequired: false, Description: @"Comma separated list of domain names which will be used toverify the common names or subject alternative namespresented by server certificates.It is performed only when common name checkhost_check_enabled is enabled.")]
        public IList<string> DomainName { get; set; }
        /// <summary>
        /// Enable HTTP/2 for traffic from VirtualService to all
        /// backend servers in this pool.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enable_http2")]
        [NSXTProperty(IsRequired: false, Description: @"Enable HTTP/2 for traffic from VirtualService to allbackend servers in this pool.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? EnableHttp2 { get; set; }
        /// <summary>
        /// Synchronize Cisco APIC EPG members with pool servers.
        /// </summary>
        [JsonProperty(PropertyName = "apic_epg_name")]
        [NSXTProperty(IsRequired: false, Description: @"Synchronize Cisco APIC EPG members with pool servers.")]
        public string? ApicEpgName { get; set; }
        /// <summary>
        /// Server reselect configuration for HTTP requests.
        /// </summary>
        [JsonProperty(PropertyName = "server_reselect")]
        [NSXTProperty(IsRequired: false, Description: @"Server reselect configuration for HTTP requests.")]
        public NSXTALBHTTPServerReselectType ServerReselect { get; set; }
        /// <summary>
        /// If configured then Avi will trigger orchestration of pool
        /// server creation and deletion.
        /// It is a reference to an object of type
        /// AutoScaleLaunchConfig.
        /// </summary>
        [JsonProperty(PropertyName = "autoscale_launch_config_path")]
        [NSXTProperty(IsRequired: false, Description: @"If configured then Avi will trigger orchestration of poolserver creation and deletion.It is a reference to an object of typeAutoScaleLaunchConfig.")]
        public string? AutoscaleLaunchConfigPath { get; set; }
        /// <summary>
        /// Minimum number of health monitors in UP state to mark
        /// server UP.
        /// </summary>
        [JsonProperty(PropertyName = "min_health_monitors_up")]
        [NSXTProperty(IsRequired: false, Description: @"Minimum number of health monitors in UP state to markserver UP.")]
        public long? MinHealthMonitorsUp { get; set; }
        /// <summary>
        /// Degree of non-affinity for core affinity based server
        /// selection.
        /// Allowed values are 1-65535.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 2.
        /// </summary>
        [JsonProperty(PropertyName = "lb_algorithm_core_nonaffinity")]
        [NSXTProperty(IsRequired: false, Description: @"Degree of non-affinity for core affinity based serverselection.Allowed values are 1-65535.Default value when not specified in API or module isinterpreted by ALB Controller as 2.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(65535)]
        [NSXTDefaultProperty(Default: "")]
        public long? LbAlgorithmCoreNonaffinity { get; set; }
        /// <summary>
        /// Inherited config from VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "east_west")]
        [NSXTProperty(IsRequired: false, Description: @"Inherited config from VirtualService.")]
        public bool? EastWest { get; set; }
        /// <summary>
        /// The Passive monitor will monitor client to server
        /// connections and requests and adjust traffic load to servers
        /// based on successful responses.
        /// This may alter the expected behavior of the LB method, such
        /// as Round Robin.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "inline_health_monitor")]
        [NSXTProperty(IsRequired: false, Description: @"The Passive monitor will monitor client to serverconnections and requests and adjust traffic load to serversbased on successful responses.This may alter the expected behavior of the LB method, suchas Round Robin.Default value when not specified in API or module isinterpreted by ALB Controller as true.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? InlineHealthMonitor { get; set; }
        /// <summary>
        /// Traffic sent to servers will use this destination server
        /// port unless overridden by the server's specific port
        /// attribute.
        /// The SSL checkbox enables Avi to server encryption.
        /// Allowed values are 1-65535.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 80.
        /// </summary>
        [JsonProperty(PropertyName = "default_server_port")]
        [NSXTProperty(IsRequired: false, Description: @"Traffic sent to servers will use this destination serverport unless overridden by the server&apos;s specific portattribute.The SSL checkbox enables Avi to server encryption.Allowed values are 1-65535.Default value when not specified in API or module isinterpreted by ALB Controller as 80.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(65535)]
        [NSXTDefaultProperty(Default: "")]
        public long? DefaultServerPort { get; set; }
        /// <summary>
        /// Minimum number of requests to be queued when pool is full.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 128.
        /// </summary>
        [JsonProperty(PropertyName = "request_queue_depth")]
        [NSXTProperty(IsRequired: false, Description: @"Minimum number of requests to be queued when pool is full.Default value when not specified in API or module isinterpreted by ALB Controller as 128.")]
        [NSXTDefaultProperty(Default: "")]
        public long? RequestQueueDepth { get; set; }
        /// <summary>
        /// Used to gracefully disable a server.
        /// Virtual service waits for the specified time before
        /// terminating the existing connections  to the servers that
        /// are disabled.
        /// Allowed values are 1-7200.
        /// Special values are 0 - 'Immediate', -1 - 'Infinite'.
        /// Unit is MIN.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1.
        /// </summary>
        [JsonProperty(PropertyName = "graceful_disable_timeout")]
        [NSXTProperty(IsRequired: false, Description: @"Used to gracefully disable a server.Virtual service waits for the specified time beforeterminating the existing connections  to the servers thatare disabled.Allowed values are 1-7200.Special values are 0 - &apos;Immediate&apos;, -1 - &apos;Infinite&apos;.Unit is MIN.Default value when not specified in API or module isinterpreted by ALB Controller as 1.")]
        //[System.ComponentModel.DataAnnotations.MinLength(-1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(7200)]
        [NSXTDefaultProperty(Default: "")]
        public long? GracefulDisableTimeout { get; set; }
        /// <summary>
        /// Enable to do routing when this pool is selected to send
        /// traffic.
        /// No servers present in routing pool.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "routing_pool")]
        [NSXTProperty(IsRequired: false, Description: @"Enable to do routing when this pool is selected to sendtraffic.No servers present in routing pool.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? RoutingPool { get; set; }
        /// <summary>
        /// When enabled, Avi re-encrypts traffic to the backend
        /// servers.
        /// The specific SSL profile defines which ciphers and SSL
        /// versions will be supported.
        /// It is a reference to an object of type SSLProfile.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_profile_path")]
        [NSXTProperty(IsRequired: false, Description: @"When enabled, Avi re-encrypts traffic to the backendservers.The specific SSL profile defines which ciphers and SSLversions will be supported.It is a reference to an object of type SSLProfile.")]
        public string? SslProfilePath { get; set; }
        /// <summary>
        /// Verify server health by applying one or more health
        /// monitors.
        /// Active monitors generate synthetic traffic from each
        /// Service Engine and mark a server up or down based on the
        /// response.
        /// The Passive monitor listens only to client to server
        /// communication.
        /// It raises or lowers the ratio of traffic destined to a
        /// server based on successful responses.
        /// It is a reference to an object of type HealthMonitor.
        /// Maximum of 50 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "health_monitor_paths")]
        [NSXTProperty(IsRequired: false, Description: @"Verify server health by applying one or more healthmonitors.Active monitors generate synthetic traffic from eachService Engine and mark a server up or down based on theresponse.The Passive monitor listens only to client to servercommunication.It raises or lowers the ratio of traffic destined to aserver based on successful responses.It is a reference to an object of type HealthMonitor.Maximum of 50 items allowed.")]
        public IList<string> HealthMonitorPaths { get; set; }
        /// <summary>
        /// Specifies settings related to analytics.
        /// It is a reference to an object of type AnalyticsProfile.
        /// </summary>
        [JsonProperty(PropertyName = "analytics_profile_path")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies settings related to analytics.It is a reference to an object of type AnalyticsProfile.")]
        public string? AnalyticsProfilePath { get; set; }
        /// <summary>
        /// Server timeout value specifies the time within which a
        /// server connection needs to be established and a
        /// request-response exchange completes between AVI and the
        /// server.
        /// Value of 0 results in using default timeout of 60 minutes.
        /// Allowed values are 0-3600000.
        /// Unit is MILLISECONDS.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "server_timeout")]
        [NSXTProperty(IsRequired: false, Description: @"Server timeout value specifies the time within which aserver connection needs to be established and arequest-response exchange completes between AVI and theserver.Value of 0 results in using default timeout of 60 minutes.Allowed values are 0-3600000.Unit is MILLISECONDS.Default value when not specified in API or module isinterpreted by ALB Controller as 0.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(3600000)]
        [NSXTDefaultProperty(Default: "")]
        public long? ServerTimeout { get; set; }
        /// <summary>
        /// Enable request queue when pool is full.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "request_queue_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Enable request queue when pool is full.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? RequestQueueEnabled { get; set; }
        /// <summary>
        /// Reference to Server Autoscale Policy.
        /// It is a reference to an object of type
        /// ServerAutoScalePolicy.
        /// </summary>
        [JsonProperty(PropertyName = "autoscale_policy_path")]
        [NSXTProperty(IsRequired: false, Description: @"Reference to Server Autoscale Policy.It is a reference to an object of typeServerAutoScalePolicy.")]
        public string? AutoscalePolicyPath { get; set; }
        /// <summary>
        /// The maximum number of concurrent connections allowed to
        /// each server within the pool.
        /// NOTE  applied value will be no less than the number of
        /// service engines that the pool is placed on.
        /// If set to 0, no limit is applied.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 0.
        /// </summary>
        [JsonProperty(PropertyName = "max_concurrent_connections_per_server")]
        [NSXTProperty(IsRequired: false, Description: @"The maximum number of concurrent connections allowed toeach server within the pool.NOTE  applied value will be no less than the number ofservice engines that the pool is placed on.If set to 0, no limit is applied.Default value when not specified in API or module isinterpreted by ALB Controller as 0.")]
        [NSXTDefaultProperty(Default: "")]
        public long? MaxConcurrentConnectionsPerServer { get; set; }
        /// <summary>
        /// Avi will validate the SSL certificate present by a server
        /// against the selected PKI Profile.
        /// It is a reference to an object of type PKIProfile.
        /// </summary>
        [JsonProperty(PropertyName = "pki_profile_path")]
        [NSXTProperty(IsRequired: false, Description: @"Avi will validate the SSL certificate present by a serveragainst the selected PKI Profile.It is a reference to an object of type PKIProfile.")]
        public string? PkiProfilePath { get; set; }
        /// <summary>
        /// A list of NSX Groups where the Servers for the Pool are
        /// created .
        /// </summary>
        [JsonProperty(PropertyName = "group_paths")]
        [NSXTProperty(IsRequired: false, Description: @"A list of NSX Groups where the Servers for the Pool arecreated .")]
        public IList<string> GroupPaths { get; set; }
        /// <summary>
        /// Enable or disable the pool.
        /// Disabling will terminate all open connections and pause
        /// health monitors.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Enable or disable the pool.Disabling will terminate all open connections and pausehealth monitors.Default value when not specified in API or module isinterpreted by ALB Controller as true.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Network Ids for the launch configuration.
        /// </summary>
        [JsonProperty(PropertyName = "autoscale_networks")]
        [NSXTProperty(IsRequired: false, Description: @"Network Ids for the launch configuration.")]
        public IList<string> AutoscaleNetworks { get; set; }
        /// <summary>
        /// HTTP header name to be used for the hash key.
        /// </summary>
        [JsonProperty(PropertyName = "lb_algorithm_consistent_hash_hdr")]
        [NSXTProperty(IsRequired: false, Description: @"HTTP header name to be used for the hash key.")]
        public string? LbAlgorithmConsistentHashHdr { get; set; }
        /// <summary>
        /// Duration for which new connections will be gradually ramped
        /// up to a server recently brought online.
        /// Useful for LB algorithms that are least connection based.
        /// Allowed values are 1-300.
        /// Special values are 0 - 'Immediate'.
        /// Unit is MIN.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 10.
        /// </summary>
        [JsonProperty(PropertyName = "connection_ramp_duration")]
        [NSXTProperty(IsRequired: false, Description: @"Duration for which new connections will be gradually rampedup to a server recently brought online.Useful for LB algorithms that are least connection based.Allowed values are 1-300.Special values are 0 - &apos;Immediate&apos;.Unit is MIN.Default value when not specified in API or module isinterpreted by ALB Controller as 10.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(300)]
        [NSXTDefaultProperty(Default: "")]
        public long? ConnectionRampDuration { get; set; }
        /// <summary>
        /// Checksum of cloud configuration for Pool.
        /// Internally set by cloud connector.
        /// </summary>
        [JsonProperty(PropertyName = "cloud_config_cksum")]
        [NSXTProperty(IsRequired: false, Description: @"Checksum of cloud configuration for Pool.Internally set by cloud connector.")]
        public string? CloudConfigCksum { get; set; }
        /// <summary>
        /// Determines analytics settings for the pool.
        /// </summary>
        [JsonProperty(PropertyName = "analytics_policy")]
        [NSXTProperty(IsRequired: false, Description: @"Determines analytics settings for the pool.")]
        public NSXTALBPoolAnalyticsPolicyType AnalyticsPolicy { get; set; }
        /// <summary>
        /// Names of external auto-scale groups for pool servers.
        /// Currently available only for AWS and Azure.
        /// </summary>
        [JsonProperty(PropertyName = "external_autoscale_groups")]
        [NSXTProperty(IsRequired: false, Description: @"Names of external auto-scale groups for pool servers.Currently available only for AWS and Azure.")]
        public IList<string> ExternalAutoscaleGroups { get; set; }
        /// <summary>
        /// Persistence will ensure the same user sticks to the same
        /// server for a desired duration of time.
        /// It is a reference to an object of type
        /// ApplicationPersistenceProfile.
        /// </summary>
        [JsonProperty(PropertyName = "application_persistence_profile_path")]
        [NSXTProperty(IsRequired: false, Description: @"Persistence will ensure the same user sticks to the sameserver for a desired duration of time.It is a reference to an object of typeApplicationPersistenceProfile.")]
        public string? ApplicationPersistenceProfilePath { get; set; }
        /// <summary>
        /// Ignore the server port in building the load balancing
        /// state.Applicable only for consistent hash load balancing
        /// algorithm or Disable Port translation (use_service_port) use
        /// cases.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "ignore_server_port")]
        [NSXTProperty(IsRequired: false, Description: @"Ignore the server port in building the load balancingstate.Applicable only for consistent hash load balancingalgorithm or Disable Port translation (use_service_port) usecases.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? IgnoreServerPort { get; set; }
        /// <summary>
        /// Manually select the networks and subnets used to provide
        /// reachability to the pool's servers.
        /// Specify the Subnet using the following syntax  10-1-1-0/24.
        /// Use static routes in VRF configuration when pool servers
        /// are not directly connected but routable from the service
        /// engine.
        /// </summary>
        [JsonProperty(PropertyName = "placement_networks")]
        [NSXTProperty(IsRequired: false, Description: @"Manually select the networks and subnets used to providereachability to the pool&apos;s servers.Specify the Subnet using the following syntax  10-1-1-0/24.Use static routes in VRF configuration when pool serversare not directly connected but routable from the serviceengine.")]
        public IList<NSXTALBPlacementNetworkType> PlacementNetworks { get; set; }
        /// <summary>
        /// Service Engines will present a client SSL certificate to
        /// the server.
        /// It is a reference to an object of type
        /// SSLKeyAndCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_key_and_certificate_path")]
        [NSXTProperty(IsRequired: false, Description: @"Service Engines will present a client SSL certificate tothe server.It is a reference to an object of typeSSLKeyAndCertificate.")]
        public string? SslKeyAndCertificatePath { get; set; }
        /// <summary>
        /// Indicates if the pool is a site-persistence pool.
        /// </summary>
        [JsonProperty(PropertyName = "gslb_sp_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Indicates if the pool is a site-persistence pool.")]
        public bool? GslbSpEnabled { get; set; }
    }
}