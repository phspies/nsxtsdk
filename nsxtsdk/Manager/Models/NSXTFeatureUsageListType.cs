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
    public class NSXTFeatureUsageListType : NSXTResourceType
    {
        /// <summary>
        /// Feature Usage List
        /// </summary>
        [JsonProperty(PropertyName = "feature_usage_info")]
        [NSXTProperty(IsRequired: false, Description: @"Feature Usage List")]
        public IList<NSXTFeatureUsageType> FeatureUsageInfo { get; set; }
    }
}