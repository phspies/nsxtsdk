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
    public class NSXTFeatureUsageListType : NSXTResourceType
    {
        /// <summary>
        /// Feature Usage List
        /// </summary>
        [JsonProperty(PropertyName = "feature_usage_info")]
        public IList<NSXTFeatureUsageType> FeatureUsageInfo { get; set; }
    }
}
