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
    /// Represents high level logical grouping of portions or segments of a donut / stats chart.
    /// </summary>
    [NSXTProperty(Description: @"Represents high level logical grouping of portions or segments of a donut / stats chart.")]
    public class NSXTDonutSectionType 
    {
        /// <summary>
        /// Field of the root of the api result set for forming parts.
        /// </summary>
        [JsonProperty(PropertyName = "row_list_field")]
        public string? RowListField { get; set; }
        /// <summary>
        /// Array of portions or parts of the donut or stats chart.
        /// </summary>
        [JsonProperty(PropertyName = "parts", Required = Required.AllowNull)]
        public IList<NSXTDonutPartType> Parts { get; set; }
        /// <summary>
        /// If true, the section will be appled as template for forming parts. Only one part will be formed from each element of
        /// 'row_list_field'.
        /// </summary>
        [JsonProperty(PropertyName = "template")]
        public bool? Template { get; set; }
    }
}
