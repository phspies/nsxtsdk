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
    public class NSXTTraceflowObservationDroppedType : NSXTTraceflowObservationType
    {
        /// <summary>
        /// This field is specified when the traceflow packet matched a NAT rule.
        /// </summary>
        [JsonProperty(PropertyName = "nat_rule_id")]
        public long? NatRuleId { get; set; }
        /// <summary>
        /// The reason traceflow packet was dropped
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTraceflowObservationDroppedReasonEnumType? Reason { get; set; }
        /// <summary>
        /// This field is specified when the traceflow packet matched a jump-to rule.
        /// </summary>
        [JsonProperty(PropertyName = "jumpto_rule_id")]
        public long? JumptoRuleId { get; set; }
        /// <summary>
        /// The id of the logical port at which the traceflow packet was dropped
        /// </summary>
        [JsonProperty(PropertyName = "lport_id")]
        public string? LportId { get; set; }
        /// <summary>
        /// The name of the logical port at which the traceflow packet was dropped
        /// </summary>
        [JsonProperty(PropertyName = "lport_name")]
        public string? LportName { get; set; }
        /// <summary>
        /// This field is specified when the traceflow packet matched a L3 firewall rule.
        /// </summary>
        [JsonProperty(PropertyName = "acl_rule_id")]
        public long? AclRuleId { get; set; }
        /// <summary>
        /// This field specifies the ARP fails reason ARP_TIMEOUT - ARP failure due to query control plane timeout ARP_CPFAIL - ARP
        /// failure due post ARP query message to control plane failure ARP_FROMCP - ARP failure due to deleting ARP entry from
        /// control plane ARP_PORTDESTROY - ARP failure due to port destruction ARP_TABLEDESTROY - ARP failure due to ARP table
        /// destruction ARP_NETDESTROY - ARP failure due to overlay network destruction
        /// </summary>
        [JsonProperty(PropertyName = "arp_fail_reason")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTraceflowObservationDroppedArpFailReasonEnumType? ArpFailReason { get; set; }
        /// <summary>
        /// This field is specified when the traceflow packet matched a l2 rule.
        /// </summary>
        [JsonProperty(PropertyName = "l2_rule_id")]
        public long? L2RuleId { get; set; }
    }
}
