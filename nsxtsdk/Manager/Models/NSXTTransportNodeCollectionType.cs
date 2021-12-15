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
    public class NSXTTransportNodeCollectionType : NSXTManagedResourceType
    {
        /// <summary>
        /// Flag indicating if applied profile has NVDS
        /// </summary>
        [JsonProperty(PropertyName = "has_nvds")]
        [NSXTProperty(IsRequired: false, Description: @"Flag indicating if applied profile has NVDS")]
        public bool? HasNvds { get; set; }
        /// <summary>
        /// Transport Node Profile ID
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_profile_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Transport Node Profile ID")]
        [System.ComponentModel.DataAnnotations.Required]
        public string TransportNodeProfileId { get; set; }
        /// <summary>
        /// Compute collection id
        /// </summary>
        [JsonProperty(PropertyName = "compute_collection_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Compute collection id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ComputeCollectionId { get; set; }
    }
}
