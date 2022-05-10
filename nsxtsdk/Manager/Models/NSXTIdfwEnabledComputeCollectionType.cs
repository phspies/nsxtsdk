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
    public class NSXTIdfwEnabledComputeCollectionType : NSXTManagedResourceType
    {
        /// <summary>
        /// Compute collection name.
        /// </summary>
        [JsonProperty(PropertyName = "compute_collection_name")]
        public string? ComputeCollectionName { get; set; }
        /// <summary>
        /// Compute collection enabled status (true=Enabled / false=Disabled).
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
        /// <summary>
        /// Compute collection ID.
        /// </summary>
        [JsonProperty(PropertyName = "compute_collection_id", Required = Required.AllowNull)]
        public string ComputeCollectionId { get; set; }
    }
}
