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
    public class NSXTTraceflowObservationForwardedLogicalType : NSXTTraceflowObservationType
    {
        /// <summary>
        /// The id of the destination component to which the traceflow packet was forwarded.
        /// </summary>
        [JsonProperty(PropertyName = "dst_component_id")]
        public string? DstComponentId { get; set; }
        /// <summary>
        /// This field is specified when the traceflow packet was forwarded by a VLAN
        /// logical network.
        /// </summary>
        [JsonProperty(PropertyName = "vlan")]
        public long? Vlan { get; set; }
        /// <summary>
        /// This field is specified when the traceflow packet was forwarded by an overlay
        /// logical network.
        /// </summary>
        [JsonProperty(PropertyName = "vni")]
        public int? Vni { get; set; }
        /// <summary>
        /// This field is specified when the traceflow packet matched a l2 rule.
        /// </summary>
        [JsonProperty(PropertyName = "l2_rule_id")]
        public long? L2RuleId { get; set; }
        /// <summary>
        /// The translated source IP address of VPN/NAT
        /// </summary>
        [JsonProperty(PropertyName = "translated_src_ip")]
        public string? TranslatedSrcIp { get; set; }
        /// <summary>
        /// The translated destination IP address of VNP/NAT
        /// </summary>
        [JsonProperty(PropertyName = "translated_dst_ip")]
        public string? TranslatedDstIp { get; set; }
        /// <summary>
        /// The source MAC address of form:
        /// "^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$". For example: 00:00:00:00:00:00.
        /// </summary>
        [JsonProperty(PropertyName = "spoofguard_mac")]
        public string? SpoofguardMac { get; set; }
        /// <summary>
        /// ARP_UNKNOWN_FROM_CP - Unknown ARP query result emitted by control plane ND_NS_UNKNOWN_FROM_CP - Unknown neighbor
        /// solicitation query result emitted by control plane UNKNOWN - Unknown resend type
        /// </summary>
        [JsonProperty(PropertyName = "resend_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTraceflowObservationForwardedLogicalResendTypeEnumType? ResendType { get; set; }
        /// <summary>
        /// This field specified the prefix IP address a traceflow packet matched in the whitelist in spoofguard.
        /// </summary>
        [JsonProperty(PropertyName = "spoofguard_ip")]
        public string? SpoofguardIp { get; set; }
        /// <summary>
        /// This field is specified when the traceflow packet matched a jump-to rule.
        /// </summary>
        [JsonProperty(PropertyName = "jumpto_rule_id")]
        public long? JumptoRuleId { get; set; }
        /// <summary>
        /// The path index of the service insertion component
        /// </summary>
        [JsonProperty(PropertyName = "service_path_index")]
        public long? ServicePathIndex { get; set; }
        /// <summary>
        /// The id of the component that forwarded the traceflow packet.
        /// </summary>
        [JsonProperty(PropertyName = "component_id")]
        public string? ComponentId { get; set; }
        /// <summary>
        /// This field specified the VLAN id a traceflow packet matched in the whitelist in spoofguard.
        /// </summary>
        [JsonProperty(PropertyName = "spoofguard_vlan_id")]
        public long? SpoofguardVlanId { get; set; }
        /// <summary>
        /// The name of the logical port through which the traceflow packet was forwarded.
        /// </summary>
        [JsonProperty(PropertyName = "lport_name")]
        public string? LportName { get; set; }
        /// <summary>
        /// This field is specified when the traceflow packet matched a L3 firewall rule.
        /// </summary>
        [JsonProperty(PropertyName = "acl_rule_id")]
        public long? AclRuleId { get; set; }
        /// <summary>
        /// The index of the service insertion component
        /// </summary>
        [JsonProperty(PropertyName = "service_index")]
        public long? ServiceIndex { get; set; }
        /// <summary>
        /// The type of the destination component to which the traceflow packet was forwarded.
        /// </summary>
        [JsonProperty(PropertyName = "dst_component_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTraceflowObservationForwardedLogicalDstComponentTypeEnumType? DstComponentType { get; set; }
        /// <summary>
        /// The name of the destination component to which the traceflow packet was forwarded.
        /// </summary>
        [JsonProperty(PropertyName = "dst_component_name")]
        public string? DstComponentName { get; set; }
        /// <summary>
        /// This field is specified when the traceflow packet matched a NAT rule.
        /// </summary>
        [JsonProperty(PropertyName = "nat_rule_id")]
        public long? NatRuleId { get; set; }
        /// <summary>
        /// The id of the logical port through which the traceflow packet was forwarded.
        /// </summary>
        [JsonProperty(PropertyName = "lport_id")]
        public string? LportId { get; set; }
        /// <summary>
        /// MAC address of nexthop for service insertion(SI)
        /// in service VM(SVM) where the traceflow packet was received.
        /// </summary>
        [JsonProperty(PropertyName = "svc_nh_mac")]
        public string? SvcNhMac { get; set; }
        /// <summary>
        /// The ttl of the service insertion component
        /// </summary>
        [JsonProperty(PropertyName = "service_ttl")]
        public long? ServiceTtl { get; set; }
    }
}
