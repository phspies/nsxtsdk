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
    /// Metadata related to a given error_id
    /// </summary>
    [NSXTProperty(Description: @"Metadata related to a given error_id")]
    public class NSXTErrorResolverInfoType 
    {
        /// <summary>
        /// The error id for which metadata information is needed
        /// </summary>
        [JsonProperty(PropertyName = "error_id", Required = Required.AllowNull)]
        public long ErrorId { get; set; }
        /// <summary>
        /// Indicates whether there is a resolver associated with the error or not
        /// </summary>
        [JsonProperty(PropertyName = "resolver_present", Required = Required.AllowNull)]
        public bool ResolverPresent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "user_metadata")]
        public NSXTErrorResolverUserMetadataType UserMetadata { get; set; }
    }
}
