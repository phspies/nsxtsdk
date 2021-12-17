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
    public class NSXTLBPoolType : NSXTPolicyConfigResourceType
    {
        public NSXTLBPoolType()
        {
            Algorithm = test
            TcpMultiplexingNumber = test
            MinActiveMembers = test
        }
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
        [NSXTProperty(IsRequired: false, Description: @"In case of active healthchecks, load balancer itself initiates newconnections (or sends ICMP ping) to the servers periodically to checktheir health, completely independent of any data traffic. Activehealthchecks are disabled by default and can be enabled for a serverpool by binding a health monitor to the pool. If multiple activemonitors are configured, the pool member status is UP only when thehealth check status for all the monitors are UP.The property is deprecated as NSX-T Load Balancer is deprecated.")]
        public IList<string> ActiveMonitorPaths { get; set; }
        /// <summary>
        /// TCP multiplexing allows the same TCP connection between load balancer
        /// and the backend server to be used for sending multiple client requests
        /// from different client TCP connections.
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_multiplexing_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"TCP multiplexing allows the same TCP connection between load balancerand the backend server to be used for sending multiple client requestsfrom different client TCP connections.The property is deprecated as NSX-T Load Balancer is deprecated.")]
        public bool? TcpMultiplexingEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "snat_translation")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTLBSnatTranslationType SnatTranslation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "member_group")]
        [NSXTProperty(IsRequired: false, Description: @"")]
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
        [NSXTProperty(IsRequired: false, Description: @"Load Balancing algorithm chooses a server for each new connection by goingthrough the list of servers in the pool. Currently, following load balancingalgorithms are supported with ROUND_ROBIN as the default.ROUND_ROBIN means that a server is selected in a round-robin fashion. Theweight would be ignored even if it is configured.WEIGHTED_ROUND_ROBIN means that a server is selected in a weightedround-robin fashion. Default weight of 1 is used if weight is not configured.LEAST_CONNECTION means that a server is selected when it has the leastnumber of connections. The weight would be ignored even if it is configured.Slow start would be enabled by default.WEIGHTED_LEAST_CONNECTION means that a server is selected in a weightedleast connection fashion. Default weight of 1 is used if weight is notconfigured. Slow start would be enabled by default.IP_HASH means that consistent hash is performed on the source IP address ofthe incoming connection. This ensures that the same client IP address willalways reach the same server as long as no server goes down or up. It maybe used on the Internet to provide a best-effort stickiness to clientswhich refuse session cookies.")]
        public NSXTLbpoolAlgorithmEnumType? Algorithm { get; set; }
        /// <summary>
        /// The maximum number of TCP connections per pool that are idly kept alive
        /// for sending future client requests.
        /// The property is deprecated as NSX-T Load Balancer is deprecated.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_multiplexing_number")]
        [NSXTProperty(IsRequired: false, Description: @"The maximum number of TCP connections per pool that are idly kept alivefor sending future client requests.The property is deprecated as NSX-T Load Balancer is deprecated.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(2147483647)]
        public long? TcpMultiplexingNumber { get; set; }
        /// <summary>
        /// Server pool consists of one or more pool members. Each pool member
        /// is identified, typically, by an IP address and a port.
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        [NSXTProperty(IsRequired: false, Description: @"Server pool consists of one or more pool members. Each pool memberis identified, typically, by an IP address and a port.")]
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
        [NSXTProperty(IsRequired: false, Description: @"Passive healthchecks are disabled by default and can be enabled byattaching a passive health monitor to a server pool.Each time a client connection to a pool member fails, its failed countis incremented. For pools bound to L7 virtual servers, a connection isconsidered to be failed and failed count is incremented if any TCPconnection errors (e.g. TCP RST or failure to send data) or SSLhandshake failures occur. For pools bound to L4 virtual servers, if noresponse is received to a TCP SYN sent to the pool member or if a TCPRST is received in response to a TCP SYN, then the pool member isconsidered to have failed and the failed count is incremented.The property is deprecated as NSX-T Load Balancer is deprecated.")]
        public string? PassiveMonitorPath { get; set; }
        /// <summary>
        /// A pool is considered active if there are at least certain
        /// minimum number of members.
        /// </summary>
        [JsonProperty(PropertyName = "min_active_members")]
        [NSXTProperty(IsRequired: false, Description: @"A pool is considered active if there are at least certainminimum number of members.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(2147483647)]
        public long? MinActiveMembers { get; set; }
    }
}
