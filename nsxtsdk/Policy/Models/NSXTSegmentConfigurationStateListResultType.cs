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
    public class NSXTSegmentConfigurationStateListResultType : NSXTListResultType
    {
        /// <summary>
        /// Paged Collection of Segment State on specific Enforcement Point
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTSegmentConfigurationStateType> Results { get; set; }
    }
}
