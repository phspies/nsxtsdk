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
    public class NSXTPolicyTraceflowObservationDroppedType : NSXTTraceflowObservationDroppedType
    {
        /// <summary>
        /// The path of the ACL rule that was applied to forward the traceflow packet
        /// </summary>
        [JsonProperty(PropertyName = "acl_rule_path")]
        public string? AclRulePath { get; set; }
        /// <summary>
        /// The path of the NAT rule that was applied to forward the traceflow packet
        /// </summary>
        [JsonProperty(PropertyName = "nat_rule_path")]
        public string? NatRulePath { get; set; }
        /// <summary>
        /// The path of the segment port or router port at which the traceflow packet was dropped
        /// </summary>
        [JsonProperty(PropertyName = "segment_port_path")]
        public string? SegmentPortPath { get; set; }
    }
}
