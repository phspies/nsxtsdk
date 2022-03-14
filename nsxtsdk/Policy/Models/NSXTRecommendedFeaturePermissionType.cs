// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Recommended Feature Permission
    /// </summary>
    [NSXTProperty(Description: @"Recommended Feature Permission")]
    public class NSXTRecommendedFeaturePermissionType 
    {
        /// <summary>
        /// List of source features
        /// </summary>
        [JsonProperty(PropertyName = "src_features", Required = Required.AllowNull)]
        public IList<string> SrcFeatures { get; set; }
        /// <summary>
        /// Feature
        /// </summary>
        [JsonProperty(PropertyName = "target_feature", Required = Required.AllowNull)]
        public string TargetFeature { get; set; }
        /// <summary>
        /// Permission
        /// </summary>
        [JsonProperty(PropertyName = "recommended_permissions", Required = Required.AllowNull)]
        public IList<string> RecommendedPermissions { get; set; }
    }
}
