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
    /// Forwarding Rule statistics for a specfic enforcement point.
    /// </summary>
    [NSXTProperty(Description: @"Forwarding Rule statistics for a specfic enforcement point.")]
    public class NSXTForwardingRuleStatisticsForEnforcementPointType 
    {
        /// <summary>
        /// Path for a specific enforcement point
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point")]
        public string? EnforcementPoint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public NSXTForwardingRuleStatsType Statistics { get; set; }
    }
}
