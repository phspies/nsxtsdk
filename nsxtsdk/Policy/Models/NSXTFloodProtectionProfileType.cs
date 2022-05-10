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
    [JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritanceAttribute("GatewayFloodProtectionProfile", typeof(NSXTGatewayFloodProtectionProfileType))]
    [JsonInheritanceAttribute("DistributedFloodProtectionProfile", typeof(NSXTDistributedFloodProtectionProfileType))]
    [NSXTProperty(Description: @"")]
    public class NSXTFloodProtectionProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// If this field is empty, firewall will not set a limit to active ICMP connections.
        /// </summary>
        [JsonProperty(PropertyName = "icmp_active_flow_limit")]
        public long? IcmpActiveFlowLimit { get; set; }
        /// <summary>
        /// If this field is empty, firewall will not set a limit to half open TCP connections.
        /// </summary>
        [JsonProperty(PropertyName = "tcp_half_open_conn_limit")]
        public long? TcpHalfOpenConnLimit { get; set; }
        /// <summary>
        /// If this field is empty, firewall will not set a limit to active UDP connections.
        /// </summary>
        [JsonProperty(PropertyName = "udp_active_flow_limit")]
        public long? UdpActiveFlowLimit { get; set; }
        /// <summary>
        /// GatewayFloodProtectionProfile is used for all Tier0 and Tier1 gateways.
        /// DistributedFloodProtectionProfile is used for all Transport Nodes.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFloodProtectionProfileResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// If this field is empty, firewall will not set a limit to other active connections. besides UDP, ICMP and half open TCP
        /// connections.
        /// </summary>
        [JsonProperty(PropertyName = "other_active_conn_limit")]
        public long? OtherActiveConnLimit { get; set; }
    }
}
