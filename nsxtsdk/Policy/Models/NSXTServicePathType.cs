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
    /// An instance of service chain that consists of forward and reverse service paths.
    /// </summary>
    [NSXTProperty(Description: @"An instance of service chain that consists of forward and reverse service paths.")]
    public class NSXTServicePathType 
    {
        /// <summary>
        /// Reverse service path if available that applies to egress traffic.
        /// </summary>
        [JsonProperty(PropertyName = "reverse_path")]
        [NSXTProperty(IsRequired: false, Description: @"Reverse service path if available that applies to egress traffic.")]
        public NSXTUnidirectionalServicePathType ReversePath { get; set; }
        /// <summary>
        /// Uuid of a service chain.
        /// </summary>
        [JsonProperty(PropertyName = "service_chain_uuid")]
        [NSXTProperty(IsRequired: false, Description: @"Uuid of a service chain.")]
        public string? ServiceChainUuid { get; set; }
        /// <summary>
        /// Forward service path if available that applies to ingress traffic.
        /// </summary>
        [JsonProperty(PropertyName = "forward_path")]
        [NSXTProperty(IsRequired: false, Description: @"Forward service path if available that applies to ingress traffic.")]
        public NSXTUnidirectionalServicePathType ForwardPath { get; set; }
        /// <summary>
        /// Unique identifier of a service path.
        /// </summary>
        [JsonProperty(PropertyName = "service_path_id")]
        [NSXTProperty(IsRequired: false, Description: @"Unique identifier of a service path.")]
        public long? ServicePathId { get; set; }
        /// <summary>
        /// A unique id of a service chain.
        /// </summary>
        [JsonProperty(PropertyName = "service_chain_id")]
        [NSXTProperty(IsRequired: false, Description: @"A unique id of a service chain.")]
        public long? ServiceChainId { get; set; }
    }
}