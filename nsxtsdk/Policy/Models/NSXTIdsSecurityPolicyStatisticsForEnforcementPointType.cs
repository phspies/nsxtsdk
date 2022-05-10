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
    /// Aggregate statistics of all the IDS rules in a security policy for a specific
        /// enforcement point.
    /// </summary>
    [NSXTProperty(Description: @"Aggregate statistics of all the IDS rules in a security policy for a specificenforcement point.")]
    public class NSXTIdsSecurityPolicyStatisticsForEnforcementPointType 
    {
        /// <summary>
        /// Enforcement point to fetch the statistics from.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point")]
        public string? EnforcementPoint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public NSXTIdsSecurityPolicyStatisticsType Statistics { get; set; }
    }
}
