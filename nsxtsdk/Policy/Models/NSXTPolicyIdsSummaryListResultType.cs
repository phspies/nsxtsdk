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
    public class NSXTPolicyIdsSummaryListResultType : NSXTListResultType
    {
        public NSXTPolicyIdsSummaryListResultType()
        {
        }
        /// <summary>
        /// Paged collection of the detected intrusions.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"Paged collection of the detected intrusions.")]
        public IList<NSXTPolicyIdsEventsSummaryType> Results { get; set; }
    }
}
