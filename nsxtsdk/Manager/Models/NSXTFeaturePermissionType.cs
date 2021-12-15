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
    /// Feature Permission
    /// </summary>
    [NSXTProperty(Description: @"Feature Permission")]
    public class NSXTFeaturePermissionType 
    {
        /// <summary>
        /// Is execute recommended
        /// </summary>
        [JsonProperty(PropertyName = "is_execute_recommended")]
        [NSXTProperty(IsRequired: false, Description: @"Is execute recommended")]
        public bool? IsExecuteRecommended { get; set; }
        /// <summary>
        /// Feature Name
        /// </summary>
        [JsonProperty(PropertyName = "feature_name")]
        [NSXTProperty(IsRequired: false, Description: @"Feature Name")]
        public string? FeatureName { get; set; }
        /// <summary>
        /// Permission
        /// </summary>
        [JsonProperty(PropertyName = "permission", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Permission")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTFeaturePermissionPermissionEnumType Permission { get; set; }
        /// <summary>
        /// Is internal
        /// </summary>
        [JsonProperty(PropertyName = "is_internal")]
        [NSXTProperty(IsRequired: false, Description: @"Is internal")]
        public bool? IsInternal { get; set; }
        /// <summary>
        /// Feature Id
        /// </summary>
        [JsonProperty(PropertyName = "feature", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Feature Id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Feature { get; set; }
        /// <summary>
        /// Feature Description
        /// </summary>
        [JsonProperty(PropertyName = "feature_description")]
        [NSXTProperty(IsRequired: false, Description: @"Feature Description")]
        public string? FeatureDescription { get; set; }
    }
}
