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
    public class NSXTTimeRangeDropdownFilterWidgetConfigurationType : NSXTDropdownFilterWidgetConfigurationType
    {
        public NSXTTimeRangeDropdownFilterWidgetConfigurationType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "time_range_filter_info")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTTimeRangeFilterInfoType TimeRangeFilterInfo { get; set; }
    }
}
