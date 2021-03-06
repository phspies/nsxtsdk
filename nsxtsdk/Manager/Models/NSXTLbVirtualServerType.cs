using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLbVirtualServerType : NSXTManagedResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "access_list_control")]
        public NSXTLbAccessListControlType AccessListControl { get; set; }
        /// <summary>
        /// Assigned Internet Protocol in IP header, TCP, UDP are supported.
        /// </summary>
        [JsonProperty(PropertyName = "ip_protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbVirtualServerIpProtocolEnumType? IpProtocol { get; set; }
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
        /// If default_pool_member_ports are configured, both
        /// default_pool_member_port and default_pool_member_ports in the response
        /// payload would include port settings, notice that the value of
        /// default_pool_member_port is the first element of
        /// default_pool_member_ports.
        /// </summary>
        [JsonProperty(PropertyName = "default_pool_member_ports")]
        public IList<string> DefaultPoolMemberPorts { get; set; }
        /// <summary>
        /// Persistence profile is used to allow related client connections to be
        /// sent to the same backend server.
        /// </summary>
        [JsonProperty(PropertyName = "persistence_profile_id")]
        public string? PersistenceProfileId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "server_ssl_profile_binding")]
        public NSXTServerSslProfileBindingType ServerSslProfileBinding { get; set; }
        /// <summary>
        /// The application profile defines the application protocol characteristics.
        /// It is used to influence how load balancing is performed. Currently,
        /// LbFastTCPProfile, LbFastUDPProfile and
        /// LbHttpProfile, etc are supported.
        /// </summary>
        [JsonProperty(PropertyName = "application_profile_id", Required = Required.AllowNull)]
        public string ApplicationProfileId { get; set; }
        /// <summary>
        /// The server pool(LbPool) contains backend servers. Server pool
        /// consists of one or more servers, also referred to as pool members, that
        /// are similarly configured and are running the same application.
        /// </summary>
        [JsonProperty(PropertyName = "pool_id")]
        public string? PoolId { get; set; }
        /// <summary>
        /// Whether access log is enabled
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
        /// Load balancer rules allow customization of load balancing behavior using
        /// match/action rules. Currently, load balancer rules are supported for
        /// only layer 7 virtual servers with LbHttpProfile.
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "rule_ids")]
        public IList<string> RuleIds { get; set; }
        /// <summary>
        /// To ensure one virtual server does not over consume resources,
        /// connections to a member can be rate limited.
        /// If it is not specified, it means that connection rate is unlimited.
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "max_new_connection_rate")]
        public long? MaxNewConnectionRate { get; set; }
        /// <summary>
        /// When load balancer can not select a backend server to serve the
        /// request in default pool or pool in rules, the request would be served
        /// by sorry server pool.
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "sorry_pool_id")]
        public string? SorryPoolId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_ssl_profile_binding")]
        public NSXTClientSslProfileBindingType ClientSslProfileBinding { get; set; }
        /// <summary>
        /// This is a deprecated property, please use 'default_pool_member_ports'
        /// instead.
        /// If default_pool_member_port is configured and default_pool_member_ports
        /// are not specified, both default_pool_member_port
        /// and default_pool_member_ports in response payload would return the same
        /// port value.
        /// If both are specified, default_pool_member_ports setting would take
        /// effect with higher priority.
        /// </summary>
        [JsonProperty(PropertyName = "default_pool_member_port")]
        public string? DefaultPoolMemberPort { get; set; }
        /// <summary>
        /// virtual server IP address
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        public string IpAddress { get; set; }
        /// <summary>
        /// This is a deprecated property, please use 'ports' instead.
        /// Port setting could be single port for both L7 mode and L4 mode.
        /// For L4 mode, a single port range is also supported.
        /// The port setting could be a single port or port range such as
        /// "80", "1234-1236".
        /// If port is configured and ports are not specified, both port and
        /// ports in response payload would return the same port value.
        /// If both port and ports are configured, ports setting would take effect
        /// with higher priority.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public string? Port { get; set; }
        /// <summary>
        /// whether the virtual server is enabled
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Port setting could be a single port for both L7 mode and L4 mode.
        /// For L4 mode, multiple ports or port ranges are also supported such
        /// as "80", "443", "1234-1236".
        /// If ports is configured, both port and ports in the response payload
        /// would include port settings, notice that the port field value is the
        /// first element of ports.
        /// </summary>
        [JsonProperty(PropertyName = "ports")]
        public IList<string> Ports { get; set; }
    }
}
