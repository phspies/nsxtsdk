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
    public class NSXTLBVirtualServerType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Path to optional object that enables persistence on a virtual server
        /// allowing related client connections to be sent to the same backend
        /// server. Persistence is disabled by default.
        /// </summary>
        [JsonProperty(PropertyName = "lb_persistence_profile_path")]
        public string? LbPersistenceProfilePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "access_list_control")]
        public NSXTLBAccessListControlType AccessListControl { get; set; }
        /// <summary>
        /// The server pool(LBPool) contains backend servers. Server pool
        /// consists of one or more servers, also referred to as pool members, that
        /// are similarly configured and are running the same application.
        /// </summary>
        [JsonProperty(PropertyName = "pool_path")]
        public string? PoolPath { get; set; }
        /// <summary>
        /// The property log_significant_event_only can take effect only when
        /// access_log_enabled is true. If log_significant_event_only is true,
        /// significant events are logged in access log.
        /// For L4 virtual server, significant event means unsuccessful(error or
        /// dropped) TCP/UDP connections.
        /// For L7 virtual server, significant event means unsuccessful connections
        /// or HTTP/HTTPS requests which have error response code(e.g. 4xx, 5xx).
        /// </summary>
        [JsonProperty(PropertyName = "log_significant_event_only")]
        public bool? LogSignificantEventOnly { get; set; }
        /// <summary>
        /// Load balancer rules allow customization of load balancing behavior using
        /// match/action rules. Currently, load balancer rules are supported for
        /// only layer 7 virtual servers with LBHttpProfile. The property is
        /// deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTLBRuleType> Rules { get; set; }
        /// <summary>
        /// Default pool member ports when member port is not defined.
        /// </summary>
        [JsonProperty(PropertyName = "default_pool_member_ports")]
        public IList<string> DefaultPoolMemberPorts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "server_ssl_profile_binding")]
        public NSXTLBServerSslProfileBindingType ServerSslProfileBinding { get; set; }
        /// <summary>
        /// The application profile defines the application protocol characteristics.
        /// It is used to influence how load balancing is performed. Currently,
        /// LBFastTCPProfile, LBFastUDPProfile and
        /// LBHttpProfile, etc are supported.
        /// </summary>
        [JsonProperty(PropertyName = "application_profile_path", Required = Required.AllowNull)]
        public string ApplicationProfilePath { get; set; }
        /// <summary>
        /// If access log is enabled, all HTTP requests sent to L7 virtual server
        /// are logged to the access log file. Both successful returns information
        /// responses(1xx), successful responses(2xx), redirection messages(3xx) and
        /// unsuccessful requests, backend server returns 4xx or 5xx, are logged to
        /// access log, if enabled. All L4 virtual server connections are also
        /// logged to the access log if enabled. The non-significant events such as
        /// successful requests are not logged if log_significant_event_only is set
        /// to true.
        /// </summary>
        [JsonProperty(PropertyName = "access_log_enabled")]
        public bool? AccessLogEnabled { get; set; }
        /// <summary>
        /// To ensure one virtual server does not over consume resources,
        /// affecting other applications hosted on the same LBS, connections
        /// to a virtual server can be capped.
        /// If it is not specified, it means that connections are unlimited.
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "max_concurrent_connections")]
        public long? MaxConcurrentConnections { get; set; }
        /// <summary>
        /// To ensure one virtual server does not over consume resources,
        /// connections to a member can be rate limited.
        /// If it is not specified, it means that connection rate is unlimited.
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "max_new_connection_rate")]
        public long? MaxNewConnectionRate { get; set; }
        /// <summary>
        /// virtual servers can be associated to LBService(which is
        /// similar to physical/virtual load balancer), LB virtual servers,
        /// pools and other entities could be defined independently, the LBService
        /// identifier list here would be used to maintain the relationship of
        /// LBService and other LB entities.
        /// </summary>
        [JsonProperty(PropertyName = "lb_service_path")]
        public string? LbServicePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ssl_profile_binding")]
        public NSXTLBClientSslProfileBindingType ClientSslProfileBinding { get; set; }
        /// <summary>
        /// When load balancer can not select a backend server to serve the
        /// request in default pool or pool in rules, the request would be served
        /// by sorry server pool. The property is deprecated as NSX-T Load Balancer
        /// is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "sorry_pool_path")]
        public string? SorryPoolPath { get; set; }
        /// <summary>
        /// Configures the IP address of the LBVirtualServer where it
        /// receives all client connections and distributes them among the
        /// backend servers.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        public string IpAddress { get; set; }
        /// <summary>
        /// Ports contains a list of at least one port or port range such as "80",
        /// "1234-1236". Each port element in the list should be a single port or a
        /// single port range.
        /// </summary>
        [JsonProperty(PropertyName = "ports", Required = Required.AllowNull)]
        public IList<string> Ports { get; set; }
        /// <summary>
        /// Flag to enable the load balancer virtual server.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
    }
}
