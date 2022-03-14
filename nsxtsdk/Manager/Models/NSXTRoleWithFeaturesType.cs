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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTRoleWithFeaturesType : NSXTManagedResourceType
    {
        /// <summary>
        /// Short identifier for the role. Must be all lower case with no spaces.
        /// </summary>
        public string? Role { get; set; }
        /// <summary>
        /// Features
        /// </summary>
        [JsonProperty(PropertyName = "features", Required = Required.AllowNull)]
        public IList<NSXTFeaturePermissionType> Features { get; set; }
    }
}
