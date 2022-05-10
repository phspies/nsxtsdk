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
    public class NSXTTraceflowObservationDeliveredType : NSXTTraceflowObservationType
    {
        /// <summary>
        /// This field specifies the resolution type of ARP ARP_SUPPRESSION_PORT_CACHE - ARP request is suppressed by port DB
        /// ARP_SUPPRESSION_TABLE - ARP request is suppressed by ARP table ARP_SUPPRESSION_CP_QUERY - ARP request is suppressed by
        /// info derived from CP ARP_VM - No suppression and the ARP request is resolved.
        /// </summary>
        [JsonProperty(PropertyName = "resolution_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTraceflowObservationDeliveredResolutionTypeEnumType? ResolutionType { get; set; }
        /// <summary>
        /// The name of the logical port into which the traceflow packet was delivered
        /// </summary>
        [JsonProperty(PropertyName = "lport_name")]
        public string? LportName { get; set; }
        /// <summary>
        /// The source MAC address of form:
        /// "^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$". For example: 00:00:00:00:00:00.
        /// </summary>
        [JsonProperty(PropertyName = "target_mac")]
        public string? TargetMac { get; set; }
        /// <summary>
        /// VLAN on bridged network
        /// </summary>
        [JsonProperty(PropertyName = "vlan_id")]
        public long? VlanId { get; set; }
        /// <summary>
        /// The id of the logical port into which the traceflow packet was delivered
        /// </summary>
        [JsonProperty(PropertyName = "lport_id")]
        public string? LportId { get; set; }
    }
}
