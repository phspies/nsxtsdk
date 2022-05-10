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
    public class NSXTChildGroupDiscoveryProfileBindingMapType : NSXTChildPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "GroupDiscoveryProfileBindingMap", Required = Required.AllowNull)]
        public NSXTGroupDiscoveryProfileBindingMapType GroupDiscoveryProfileBindingMap { get; set; }
    }
}
