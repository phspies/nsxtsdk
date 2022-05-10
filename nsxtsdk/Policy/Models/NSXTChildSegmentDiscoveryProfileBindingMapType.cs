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
    public class NSXTChildSegmentDiscoveryProfileBindingMapType : NSXTChildPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "SegmentDiscoveryProfileBindingMap", Required = Required.AllowNull)]
        public NSXTSegmentDiscoveryProfileBindingMapType SegmentDiscoveryProfileBindingMap { get; set; }
    }
}
