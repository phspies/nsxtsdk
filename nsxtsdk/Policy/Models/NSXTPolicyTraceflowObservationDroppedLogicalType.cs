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
    public class NSXTPolicyTraceflowObservationDroppedLogicalType : NSXTTraceflowObservationDroppedLogicalType
    {
        /// <summary>
        /// The path of the ACL rule that was applied to forward the traceflow packet
        /// </summary>
        [JsonProperty(PropertyName = "acl_rule_path")]
        [NSXTProperty(IsRequired: false, Description: @"The path of the ACL rule that was applied to forward the traceflow packet")]
        public string? AclRulePath { get; set; }
        /// <summary>
        /// The path of the NAT rule that was applied to forward the traceflow packet
        /// </summary>
        [JsonProperty(PropertyName = "nat_rule_path")]
        [NSXTProperty(IsRequired: false, Description: @"The path of the NAT rule that was applied to forward the traceflow packet")]
        public string? NatRulePath { get; set; }
        /// <summary>
        /// The path of the component that dropped the traceflow packet
        /// </summary>
        [JsonProperty(PropertyName = "component_path")]
        [NSXTProperty(IsRequired: false, Description: @"The path of the component that dropped the traceflow packet")]
        public string? ComponentPath { get; set; }
        /// <summary>
        /// The path of the segment port at which traceflow packet was dropped
        /// </summary>
        [JsonProperty(PropertyName = "segment_port_path")]
        [NSXTProperty(IsRequired: false, Description: @"The path of the segment port at which traceflow packet was dropped")]
        public string? SegmentPortPath { get; set; }
    }
}