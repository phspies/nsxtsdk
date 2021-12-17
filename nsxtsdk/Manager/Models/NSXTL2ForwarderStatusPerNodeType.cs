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
    public class NSXTL2ForwarderStatusPerNodeType 
    {
        public NSXTL2ForwarderStatusPerNodeType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "transport_node")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTResourceReferenceType TransportNode { get; set; }
        /// <summary>
        /// High Availability status of a service router on the edge node.
        /// </summary>
        [JsonProperty(PropertyName = "high_availability_status")]
        [NSXTProperty(IsRequired: false, Description: @"High Availability status of a service router on the edge node.")]
        public NSXTL2ForwarderStatusPerNodeHighAvailabilityStatusEnumType? HighAvailabilityStatus { get; set; }
    }
}
