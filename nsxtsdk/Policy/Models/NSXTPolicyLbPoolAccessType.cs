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
    public class NSXTPolicyLbPoolAccessType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Port for LoadBalancer to send connections to the PolicyLbPoolAccess's
        /// Group. Pool_port could be optional, if it is not specified, LB will use
        /// PolicyLbVirtualServer port to connect to backend servers. If the
        /// PolicyLbMonitorProfile is configured in PolicyLbPoolAccess and active
        /// monitor IP protocol is TCP/UDP(which requires TCP or UDP port number),
        /// monitor_port should be specified if pool_port is unset.
        /// </summary>
        [JsonProperty(PropertyName = "pool_port")]
        [NSXTProperty(IsRequired: false, Description: @"Port for LoadBalancer to send connections to the PolicyLbPoolAccess&apos;sGroup. Pool_port could be optional, if it is not specified, LB will usePolicyLbVirtualServer port to connect to backend servers. If thePolicyLbMonitorProfile is configured in PolicyLbPoolAccess and activemonitor IP protocol is TCP/UDP(which requires TCP or UDP port number),monitor_port should be specified if pool_port is unset.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(65535)]
        public long? PoolPort { get; set; }
        /// <summary>
        /// IP Port list for applications within the Group to allow
        /// for non-uniform port usage by applications
        /// </summary>
        [JsonProperty(PropertyName = "ip_port_list")]
        [NSXTProperty(IsRequired: false, Description: @"IP Port list for applications within the Group to allowfor non-uniform port usage by applications")]
        public IList<NSXTIPAddressPortPairType> IpPortList { get; set; }
        /// <summary>
        /// Depending on the topology, Source NAT (SNAT) may be required to ensure
        /// traffic from the server destined to the client is received by the load
        /// balancer. SNAT can be enabled per pool. If SNAT is not enabled for a
        /// pool, then load balancer uses the client IP and port (spoofing) while
        /// establishing connections to the servers. This is referred to as no-SNAT
        /// or TRANSPARENT mode.  SNAT is enabled by default and will use the
        /// load balancer interface IP and an ephemeral port as the source IP and
        /// port of the server side connection.
        /// </summary>
        [JsonProperty(PropertyName = "source_nat")]
        [NSXTProperty(IsRequired: false, Description: @"Depending on the topology, Source NAT (SNAT) may be required to ensuretraffic from the server destined to the client is received by the loadbalancer. SNAT can be enabled per pool. If SNAT is not enabled for apool, then load balancer uses the client IP and port (spoofing) whileestablishing connections to the servers. This is referred to as no-SNATor TRANSPARENT mode.  SNAT is enabled by default and will use theload balancer interface IP and an ephemeral port as the source IP andport of the server side connection.")]
        [NSXTDefaultProperty(Default: "ENABLED")]
        public NSXTPolicyLbPoolAccessSourceNatEnumType? SourceNat { get; set; }
        /// <summary>
        /// Load balanding algorithm controls how the incoming
        /// connections are distributed among the members.
        /// - ROUND_ROBIN - requests to the application servers are distributed
        /// in a round-robin fashion,
        /// - LEAST_CONNECTION - next request is assigned to the server with the
        /// least number of active connections
        /// </summary>
        [JsonProperty(PropertyName = "algorithm")]
        [NSXTProperty(IsRequired: false, Description: @"Load balanding algorithm controls how the incomingconnections are distributed among the members.- ROUND_ROBIN - requests to the application servers are distributedin a round-robin fashion,- LEAST_CONNECTION - next request is assigned to the server with theleast number of active connections")]
        [NSXTDefaultProperty(Default: "ROUND_ROBIN")]
        public NSXTPolicyLbPoolAccessAlgorithmEnumType? Algorithm { get; set; }
        /// <summary>
        /// Path of the PolicyLbMonitorProfile to actively monitor the
        /// PolicyLbPoolAccess's Group
        /// </summary>
        [JsonProperty(PropertyName = "lb_monitor_profile")]
        [NSXTProperty(IsRequired: false, Description: @"Path of the PolicyLbMonitorProfile to actively monitor thePolicyLbPoolAccess&apos;s Group")]
        public string? LbMonitorProfile { get; set; }
    }
}
