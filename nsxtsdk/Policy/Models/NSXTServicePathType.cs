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
    /// An instance of service chain that consists of forward and reverse service paths.
    /// </summary>
    [NSXTProperty(Description: @"An instance of service chain that consists of forward and reverse service paths.")]
    public class NSXTServicePathType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "reverse_path")]
        public NSXTUnidirectionalServicePathType ReversePath { get; set; }
        /// <summary>
        /// Uuid of a service chain.
        /// </summary>
        [JsonProperty(PropertyName = "service_chain_uuid")]
        public string? ServiceChainUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "forward_path")]
        public NSXTUnidirectionalServicePathType ForwardPath { get; set; }
        /// <summary>
        /// Unique identifier of a service path.
        /// </summary>
        [JsonProperty(PropertyName = "service_path_id")]
        public long? ServicePathId { get; set; }
        /// <summary>
        /// A unique id of a service chain.
        /// </summary>
        [JsonProperty(PropertyName = "service_chain_id")]
        public long? ServiceChainId { get; set; }
    }
}
