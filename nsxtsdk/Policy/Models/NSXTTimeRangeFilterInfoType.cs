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
    /// time range filter information
    /// </summary>
    [NSXTProperty(Description: @"time range filter information")]
    public class NSXTTimeRangeFilterInfoType 
    {
        /// <summary>
        /// to parameter name used for time range filter to date value.
        /// </summary>
        [JsonProperty(PropertyName = "to_param_name")]
        public string? ToParamName { get; set; }
        /// <summary>
        /// from parameter name used for time range filter from date value.
        /// </summary>
        [JsonProperty(PropertyName = "from_param_name")]
        public string? FromParamName { get; set; }
        /// <summary>
        /// type of time range filter value can be epoch, ISO date Format.
        /// </summary>
        [JsonProperty(PropertyName = "value_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTimeRangeFilterInfoValueTypeEnumType? ValueType { get; set; }
    }
}
