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
    /// IDS Rule statistics for a specfic enforcement point.
    /// </summary>
    [NSXTProperty(Description: @"IDS Rule statistics for a specfic enforcement point.")]
    public class NSXTIdsRuleStatisticsForEnforcementPointType 
    {
        /// <summary>
        /// IDS Rule statistics for a single enforcement point
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point")]
        public string? EnforcementPoint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public NSXTIdsRuleStatisticsType Statistics { get; set; }
    }
}
