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
        [NSXTProperty(IsRequired: false, Description: @"Paged Collection of Segment State on specific Enforcement Point")]
        public IList<NSXTSegmentConfigurationStateType> Results { get; set; }
    }
}
