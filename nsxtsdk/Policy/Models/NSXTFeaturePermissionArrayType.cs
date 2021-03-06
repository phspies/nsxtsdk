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
    public class NSXTFeaturePermissionArrayType 
    {
        /// <summary>
        /// Array of FeaturePermission
        /// </summary>
        [JsonProperty(PropertyName = "feature_permissions", Required = Required.AllowNull)]
        public IList<NSXTFeaturePermissionType> FeaturePermissions { get; set; }
    }
}
