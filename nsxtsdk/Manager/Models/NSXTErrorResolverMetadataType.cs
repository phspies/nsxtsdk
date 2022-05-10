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
    /// Error along with its metadata
    /// </summary>
    [NSXTProperty(Description: @"Error along with its metadata")]
    public class NSXTErrorResolverMetadataType 
    {
        /// <summary>
        /// The error id as reported by the entity where the error occurred.
        /// </summary>
        [JsonProperty(PropertyName = "error_id", Required = Required.AllowNull)]
        public long ErrorId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "system_metadata")]
        public NSXTErrorResolverSystemMetadataType SystemMetadata { get; set; }
        /// <summary>
        /// The entity/node UUID where the error has occurred.
        /// </summary>
        [JsonProperty(PropertyName = "entity_id", Required = Required.AllowNull)]
        public string EntityId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "user_metadata")]
        public NSXTErrorResolverUserMetadataType UserMetadata { get; set; }
    }
}
