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
    public class NSXTHostTransportNodeCollectionType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Flag indicating if applied profile has NVDS
        /// </summary>
        [JsonProperty(PropertyName = "has_nvds")]
        public bool? HasNvds { get; set; }
        /// <summary>
        /// Transport Node Profile ID
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_profile_id")]
        public string? TransportNodeProfileId { get; set; }
        /// <summary>
        /// Compute collection id
        /// </summary>
        [JsonProperty(PropertyName = "compute_collection_id", Required = Required.AllowNull)]
        public string ComputeCollectionId { get; set; }
    }
}
