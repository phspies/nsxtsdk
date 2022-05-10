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
    public class NSXTTransportNodeCollectionType : NSXTManagedResourceType
    {
        /// <summary>
        /// Flag indicating if applied profile has NVDS
        /// </summary>
        [JsonProperty(PropertyName = "has_nvds")]
        public bool? HasNvds { get; set; }
        /// <summary>
        /// Transport Node Profile ID
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_profile_id", Required = Required.AllowNull)]
        public string TransportNodeProfileId { get; set; }
        /// <summary>
        /// Compute collection id
        /// </summary>
        [JsonProperty(PropertyName = "compute_collection_id", Required = Required.AllowNull)]
        public string ComputeCollectionId { get; set; }
        /// <summary>
        /// Flag indicating security status of Transport Node Collection
        /// </summary>
        [JsonProperty(PropertyName = "install_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTransportNodeCollectionInstallModeEnumType? InstallMode { get; set; }
    }
}
