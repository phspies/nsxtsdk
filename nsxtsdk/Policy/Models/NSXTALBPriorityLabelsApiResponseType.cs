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
    public class NSXTALBPriorityLabelsApiResponseType : NSXTListResultType
    {
        /// <summary>
        /// count
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        [NSXTProperty(IsRequired: false, Description: @"count")]
        public long? Count { get; set; }
        /// <summary>
        /// Array of PriorityLabels
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"Array of PriorityLabels")]
        public IList<NSXTALBPriorityLabelsType> Results { get; set; }
    }
}