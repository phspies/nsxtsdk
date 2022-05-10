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
    /// Feature Permission
    /// </summary>
    [NSXTProperty(Description: @"Feature Permission")]
    public class NSXTFeaturePermissionType 
    {
        /// <summary>
        /// Is execute recommended
        /// </summary>
        [JsonProperty(PropertyName = "is_execute_recommended")]
        public bool? IsExecuteRecommended { get; set; }
        /// <summary>
        /// Feature Name
        /// </summary>
        [JsonProperty(PropertyName = "feature_name")]
        public string? FeatureName { get; set; }
        /// <summary>
        /// Permission
        /// </summary>
        [JsonProperty(PropertyName = "permission", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFeaturePermissionPermissionEnumType Permission { get; set; }
        /// <summary>
        /// Is internal
        /// </summary>
        [JsonProperty(PropertyName = "is_internal")]
        public bool? IsInternal { get; set; }
        /// <summary>
        /// Feature Id
        /// </summary>
        [JsonProperty(PropertyName = "feature", Required = Required.AllowNull)]
        public string Feature { get; set; }
        /// <summary>
        /// Feature Description
        /// </summary>
        [JsonProperty(PropertyName = "feature_description")]
        public string? FeatureDescription { get; set; }
    }
}
