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
    public class NSXTDiscoveredResourceType : NSXTResourceType
    {
        /// <summary>
        /// Defaults to ID if not set
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Description of this resource
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Timestamp of last modification
        /// </summary>
        [JsonProperty(PropertyName = "_last_sync_time")]
        public long? LastSyncTime { get; set; }
        /// <summary>
        /// Opaque identifiers meaningful to the API user
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<NSXTTagType> Tags { get; set; }
        /// <summary>
        /// Specifies list of scope of discovered resource. e.g. if VHC path is associated with
        /// principal identity, who owns the discovered resource, then scope id will be VHC path
        /// and scope type will be VHC.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public IList<NSXTDiscoveredResourceScopeType> Scope { get; set; }
        /// <summary>
        /// The type of this resource.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        public string ResourceType { get; set; }
    }
}
