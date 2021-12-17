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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTraceflowObservationDroppedType : NSXTTraceflowObservationType
    {
        public NSXTTraceflowObservationDroppedType()
        {
        }
        /// <summary>
        /// This field is specified when the traceflow packet matched a NAT rule.
        /// </summary>
        [JsonProperty(PropertyName = "nat_rule_id")]
        [NSXTProperty(IsRequired: false, Description: @"This field is specified when the traceflow packet matched a NAT rule.")]
        public long? NatRuleId { get; set; }
        /// <summary>
        /// The reason traceflow packet was dropped
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        [NSXTProperty(IsRequired: false, Description: @"The reason traceflow packet was dropped")]
        public NSXTTraceflowObservationDroppedReasonEnumType? Reason { get; set; }
        /// <summary>
        /// This field is specified when the traceflow packet matched a jump-to rule.
        /// </summary>
        [JsonProperty(PropertyName = "jumpto_rule_id")]
        [NSXTProperty(IsRequired: false, Description: @"This field is specified when the traceflow packet matched a jump-to rule.")]
        public long? JumptoRuleId { get; set; }
        /// <summary>
        /// The id of the logical port at which the traceflow packet was dropped
        /// </summary>
        [JsonProperty(PropertyName = "lport_id")]
        [NSXTProperty(IsRequired: false, Description: @"The id of the logical port at which the traceflow packet was dropped")]
        public string? LportId { get; set; }
        /// <summary>
        /// The name of the logical port at which the traceflow packet was dropped
        /// </summary>
        [JsonProperty(PropertyName = "lport_name")]
        [NSXTProperty(IsRequired: false, Description: @"The name of the logical port at which the traceflow packet was dropped")]
        public string? LportName { get; set; }
        /// <summary>
        /// This field is specified when the traceflow packet matched a L3 firewall rule.
        /// </summary>
        [JsonProperty(PropertyName = "acl_rule_id")]
        [NSXTProperty(IsRequired: false, Description: @"This field is specified when the traceflow packet matched a L3 firewall rule.")]
        public long? AclRuleId { get; set; }
        /// <summary>
        /// This field specifies the ARP fails reason ARP_TIMEOUT - ARP failure due to query control plane timeout ARP_CPFAIL - ARP
        /// failure due post ARP query message to control plane failure ARP_FROMCP - ARP failure due to deleting ARP entry from
        /// control plane ARP_PORTDESTROY - ARP failure due to port destruction ARP_TABLEDESTROY - ARP failure due to ARP table
        /// destruction ARP_NETDESTROY - ARP failure due to overlay network destruction
        /// </summary>
        [JsonProperty(PropertyName = "arp_fail_reason")]
        [NSXTProperty(IsRequired: false, Description: @"This field specifies the ARP fails reason ARP_TIMEOUT - ARP failure due to query control plane timeout ARP_CPFAIL - ARP failure due post ARP query message to control plane failure ARP_FROMCP - ARP failure due to deleting ARP entry from control plane ARP_PORTDESTROY - ARP failure due to port destruction ARP_TABLEDESTROY - ARP failure due to ARP table destruction ARP_NETDESTROY - ARP failure due to overlay network destruction")]
        public NSXTTraceflowObservationDroppedArpFailReasonEnumType? ArpFailReason { get; set; }
        /// <summary>
        /// This field is specified when the traceflow packet matched a l2 rule.
        /// </summary>
        [JsonProperty(PropertyName = "l2_rule_id")]
        [NSXTProperty(IsRequired: false, Description: @"This field is specified when the traceflow packet matched a l2 rule.")]
        public long? L2RuleId { get; set; }
    }
}
