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
    public class NSXTGroupDiscoveryProfileBindingMapListResultType : NSXTListResultType
    {
        /// <summary>
        /// Group Discovery Profile Binding Map List Results
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTGroupDiscoveryProfileBindingMapType> Results { get; set; }
    }
}
