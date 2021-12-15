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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// This entity represents the flow parameters which are exported.
    /// </summary>
    [NSXTProperty(Description: @"This entity represents the flow parameters which are exported.")]
    public class NSXTIpfixDfwTemplateParametersType 
    {
        /// <summary>
        /// Type of the IPv4 ICMP message.
        /// </summary>
        [JsonProperty(PropertyName = "source_icmp_type")]
        [NSXTProperty(IsRequired: false, Description: @"Type of the IPv4 ICMP message.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? SourceIcmpType { get; set; }
        /// <summary>
        /// Code of the IPv4 ICMP message.
        /// </summary>
        [JsonProperty(PropertyName = "icmp_code")]
        [NSXTProperty(IsRequired: false, Description: @"Code of the IPv4 ICMP message.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? IcmpCode { get; set; }
        /// <summary>
        /// The destination transport port of a monitored network flow.
        /// </summary>
        [JsonProperty(PropertyName = "destination_transport_port")]
        [NSXTProperty(IsRequired: false, Description: @"The destination transport port of a monitored network flow.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? DestinationTransportPort { get; set; }
        /// <summary>
        /// The number of octets since the previous report (if any) in incoming
        /// packets for this flow at the observation point. The number of octets
        /// include IP header(s) and payload.
        /// </summary>
        [JsonProperty(PropertyName = "octet_delta_count")]
        [NSXTProperty(IsRequired: false, Description: @"The number of octets since the previous report (if any) in incomingpackets for this flow at the observation point. The number of octetsinclude IP header(s) and payload.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? OctetDeltaCount { get; set; }
        /// <summary>
        /// VIF UUID - enterprise specific Information Element that uniquely identifies VIF.
        /// </summary>
        [JsonProperty(PropertyName = "vif_uuid")]
        [NSXTProperty(IsRequired: false, Description: @"VIF UUID - enterprise specific Information Element that uniquely identifies VIF.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? VifUuid { get; set; }
        /// <summary>
        /// The value of the protocol number in the IP packet header.
        /// </summary>
        [JsonProperty(PropertyName = "protocol_identifier")]
        [NSXTProperty(IsRequired: false, Description: @"The value of the protocol number in the IP packet header.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? ProtocolIdentifier { get; set; }
        /// <summary>
        /// Five valid values are allowed: 1. Flow Created. 2. Flow Deleted.
        /// 3. Flow Denied. 4. Flow Alert (not used in DropKick implementation).
        /// 5. Flow Update.
        /// </summary>
        [JsonProperty(PropertyName = "firewall_event")]
        [NSXTProperty(IsRequired: false, Description: @"Five valid values are allowed: 1. Flow Created. 2. Flow Deleted.3. Flow Denied. 4. Flow Alert (not used in DropKick implementation).5. Flow Update.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? FirewallEvent { get; set; }
        /// <summary>
        /// Two valid values are allowed: 1. 0x00: igress flow to VM. 2. 0x01:
        /// egress flow from VM.
        /// </summary>
        [JsonProperty(PropertyName = "flow_direction")]
        [NSXTProperty(IsRequired: false, Description: @"Two valid values are allowed: 1. 0x00: igress flow to VM. 2. 0x01:egress flow from VM.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? FlowDirection { get; set; }
        /// <summary>
        /// The absolute timestamp (seconds) of the last packet of this flow.
        /// </summary>
        [JsonProperty(PropertyName = "flow_end")]
        [NSXTProperty(IsRequired: false, Description: @"The absolute timestamp (seconds) of the last packet of this flow.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? FlowEnd { get; set; }
        /// <summary>
        /// The source transport port of a monitored network flow.
        /// </summary>
        [JsonProperty(PropertyName = "source_transport_port")]
        [NSXTProperty(IsRequired: false, Description: @"The source transport port of a monitored network flow.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? SourceTransportPort { get; set; }
        /// <summary>
        /// The number of incoming packets since the previous report (if any)
        /// for this flow at the observation point.
        /// </summary>
        [JsonProperty(PropertyName = "packet_delta_count")]
        [NSXTProperty(IsRequired: false, Description: @"The number of incoming packets since the previous report (if any)for this flow at the observation point.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? PacketDeltaCount { get; set; }
        /// <summary>
        /// The destination IP address of a monitored network flow.
        /// </summary>
        [JsonProperty(PropertyName = "destination_address")]
        [NSXTProperty(IsRequired: false, Description: @"The destination IP address of a monitored network flow.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? DestinationAddress { get; set; }
        /// <summary>
        /// The source IP address of a monitored network flow.
        /// </summary>
        [JsonProperty(PropertyName = "source_address")]
        [NSXTProperty(IsRequired: false, Description: @"The source IP address of a monitored network flow.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? SourceAddress { get; set; }
        /// <summary>
        /// Firewall rule Id - enterprise specific Information Element that uniquely identifies
        /// firewall rule.
        /// </summary>
        [JsonProperty(PropertyName = "rule_id")]
        [NSXTProperty(IsRequired: false, Description: @"Firewall rule Id - enterprise specific Information Element that uniquely identifiesfirewall rule.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? RuleId { get; set; }
        /// <summary>
        /// The absolute timestamp (seconds) of the first packet of this flow.
        /// </summary>
        [JsonProperty(PropertyName = "flow_start")]
        [NSXTProperty(IsRequired: false, Description: @"The absolute timestamp (seconds) of the first packet of this flow.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? FlowStart { get; set; }
    }
}