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
    public class NSXTPolicyTraceflowObservationForwardedLogicalType : NSXTTraceflowObservationForwardedLogicalType
    {
        /// <summary>
        /// The path of the NAT rule that was applied to forward the traceflow packet
        /// </summary>
        [JsonProperty(PropertyName = "nat_rule_path")]
        public string? NatRulePath { get; set; }
        /// <summary>
        /// The path of the jump-to rule that was applied to the traceflow packet
        /// </summary>
        [JsonProperty(PropertyName = "jumpto_rule_path")]
        public string? JumptoRulePath { get; set; }
        /// <summary>
        /// The path of the component that forwarded the traceflow packet
        /// </summary>
        [JsonProperty(PropertyName = "component_path")]
        public string? ComponentPath { get; set; }
        /// <summary>
        /// The path of the segment port or router port through which the traceflow packet was forwarded
        /// </summary>
        [JsonProperty(PropertyName = "segment_port_path")]
        public string? SegmentPortPath { get; set; }
        /// <summary>
        /// The path of the l2 rule that was applied to the traceflow packet
        /// </summary>
        [JsonProperty(PropertyName = "l2_rule_path")]
        public string? L2RulePath { get; set; }
        /// <summary>
        /// The path of the ACL rule that was applied to forward the traceflow packet
        /// </summary>
        [JsonProperty(PropertyName = "acl_rule_path")]
        public string? AclRulePath { get; set; }
        /// <summary>
        /// The path of the destination component to which the traceflow packet was forwarded
        /// </summary>
        [JsonProperty(PropertyName = "dst_component_path")]
        public string? DstComponentPath { get; set; }
    }
}
