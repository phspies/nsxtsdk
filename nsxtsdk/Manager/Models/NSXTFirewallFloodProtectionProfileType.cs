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
    public class NSXTFirewallFloodProtectionProfileType : NSXTBaseFirewallProfileType
    {
        /// <summary>
        /// The maximum limit of active icmp connections. If this property is omitted, or set to null, then there is no limit on
        /// active icmp connections for those components if it's applied to ESX components (such as segment, segment port, virtual
        /// machine, etc); on the other side, if it's applied to EDGE components (such as, gateway), it will be set to default limit
        /// (10,000) on the specific components.
        /// </summary>
        [JsonProperty(PropertyName = "icmp_active_flow_limit")]
        public long? IcmpActiveFlowLimit { get; set; }
        /// <summary>
        /// The maximum limit of other active connections besides udp, icmp and half open tcp connections. If this property is
        /// omitted, or set to null, then there is no limit on other active connections besides udp, icmp and tcp half open
        /// connections for those components if it's applied to ESX components (such as segment, segment port, virtual machine,
        /// etc); on the other side, if it's applied to EDGE components (such as, gateway), it will be set to default limit (10,000)
        /// on the specific components.
        /// </summary>
        [JsonProperty(PropertyName = "other_active_conn_limit")]
        public long? OtherActiveConnLimit { get; set; }
        /// <summary>
        /// The flag to indicate syncache is enabled or not. This option does not apply to EDGE components.
        /// </summary>
        [JsonProperty(PropertyName = "enable_syncache")]
        public bool? EnableSyncache { get; set; }
        /// <summary>
        /// The flag to indicate RST spoofing is enabled or not. This option does not apply to EDGE components. This can be enabled
        /// only if syncache is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enable_rst_spoofing")]
        public bool? EnableRstSpoofing { get; set; }
        /// <summary>
        /// The maximum limit of tcp half open connections. If this property is omitted, or set to null, then there is no limit on
        /// active tcp half open connections for those components if it's applied to ESX components (such as segment, segment port,
        /// virtual machine, etc); on the other side, if it's applied to EDGE components (such as, gateway), it will be set to
        /// default limit (1,000,000) on the specific components.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_half_open_conn_limit")]
        public long? TcpHalfOpenConnLimit { get; set; }
        /// <summary>
        /// The maximum limit of active udp connections. If this property is omitted, or set to null, then there is no limit on
        /// active udp connections for those components if it's applied to ESX components (such as segment, segment port, virtual
        /// machine, etc); on the other side, if it's applied to EDGE components (such as, gateway), it will be set to default limit
        /// (100,000) on the specific component.
        /// </summary>
        [JsonProperty(PropertyName = "udp_active_flow_limit")]
        public long? UdpActiveFlowLimit { get; set; }
        /// <summary>
        /// The maximum limit of active NAT connections. This limit only apply to EDGE components (such as, gateway). If this
        /// property is omitted, or set to null, then there is no limit on the specific component. Meanwhile there is an implicit
        /// limit which depends on the underlying hardware resource.
        /// </summary>
        [JsonProperty(PropertyName = "nat_active_conn_limit")]
        public long? NatActiveConnLimit { get; set; }
    }
}
