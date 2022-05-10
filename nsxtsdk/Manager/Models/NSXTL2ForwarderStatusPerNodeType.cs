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
    public class NSXTL2ForwarderStatusPerNodeType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "transport_node")]
        public NSXTResourceReferenceType TransportNode { get; set; }
        /// <summary>
        /// High Availability status of a service router on the edge node.
        /// </summary>
        [JsonProperty(PropertyName = "high_availability_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL2ForwarderStatusPerNodeHighAvailabilityStatusEnumType? HighAvailabilityStatus { get; set; }
    }
}
