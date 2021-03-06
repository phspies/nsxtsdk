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
    public class NSXTLBPoolType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// In case of active healthchecks, load balancer itself initiates new
        /// connections (or sends ICMP ping) to the servers periodically to check
        /// their health, completely independent of any data traffic. Active
        /// healthchecks are disabled by default and can be enabled for a server
        /// pool by binding a health monitor to the pool. If multiple active
        /// monitors are configured, the pool member status is UP only when the
        /// health check status for all the monitors are UP.
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "active_monitor_paths")]
        public IList<string> ActiveMonitorPaths { get; set; }
        /// <summary>
        /// TCP multiplexing allows the same TCP connection between load balancer
        /// and the backend server to be used for sending multiple client requests
        /// from different client TCP connections.
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_multiplexing_enabled")]
        public bool? TcpMultiplexingEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "snat_translation")]
        public NSXTLBSnatTranslationType SnatTranslation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "member_group")]
        public NSXTLBPoolMemberGroupType MemberGroup { get; set; }
        /// <summary>
        /// Load Balancing algorithm chooses a server for each new connection by going
        /// through the list of servers in the pool. Currently, following load balancing
        /// algorithms are supported with ROUND_ROBIN as the default.
        /// ROUND_ROBIN means that a server is selected in a round-robin fashion. The
        /// weight would be ignored even if it is configured.
        /// WEIGHTED_ROUND_ROBIN means that a server is selected in a weighted
        /// round-robin fashion. Default weight of 1 is used if weight is not configured.
        /// LEAST_CONNECTION means that a server is selected when it has the least
        /// number of connections. The weight would be ignored even if it is configured.
        /// Slow start would be enabled by default.
        /// WEIGHTED_LEAST_CONNECTION means that a server is selected in a weighted
        /// least connection fashion. Default weight of 1 is used if weight is not
        /// configured. Slow start would be enabled by default.
        /// IP_HASH means that consistent hash is performed on the source IP address of
        /// the incoming connection. This ensures that the same client IP address will
        /// always reach the same server as long as no server goes down or up. It may
        /// be used on the Internet to provide a best-effort stickiness to clients
        /// which refuse session cookies.
        /// </summary>
        [JsonProperty(PropertyName = "algorithm")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbpoolAlgorithmEnumType? Algorithm { get; set; }
        /// <summary>
        /// The maximum number of TCP connections per pool that are idly kept alive
        /// for sending future client requests.
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_multiplexing_number")]
        public long? TcpMultiplexingNumber { get; set; }
        /// <summary>
        /// Server pool consists of one or more pool members. Each pool member
        /// is identified, typically, by an IP address and a port.
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<NSXTLBPoolMemberType> Members { get; set; }
        /// <summary>
        /// Passive healthchecks are disabled by default and can be enabled by
        /// attaching a passive health monitor to a server pool.
        /// Each time a client connection to a pool member fails, its failed count
        /// is incremented. For pools bound to L7 virtual servers, a connection is
        /// considered to be failed and failed count is incremented if any TCP
        /// connection errors (e.g. TCP RST or failure to send data) or SSL
        /// handshake failures occur. For pools bound to L4 virtual servers, if no
        /// response is received to a TCP SYN sent to the pool member or if a TCP
        /// RST is received in response to a TCP SYN, then the pool member is
        /// considered to have failed and the failed count is incremented.
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "passive_monitor_path")]
        public string? PassiveMonitorPath { get; set; }
        /// <summary>
        /// A pool is considered active if there are at least certain
        /// minimum number of members.
        /// </summary>
        [JsonProperty(PropertyName = "min_active_members")]
        public long? MinActiveMembers { get; set; }
    }
}
