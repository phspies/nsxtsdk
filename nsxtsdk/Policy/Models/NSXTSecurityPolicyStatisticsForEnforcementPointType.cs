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
    /// Aggregate statistics of all the rules in a security policy for a specific
        /// enforcement point.
    /// </summary>
    [NSXTProperty(Description: @"Aggregate statistics of all the rules in a security policy for a specificenforcement point.")]
    public class NSXTSecurityPolicyStatisticsForEnforcementPointType 
    {
        /// <summary>
        /// Enforcement point to fetch the statistics from.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point")]
        [NSXTProperty(IsRequired: false, Description: @"Enforcement point to fetch the statistics from.")]
        public string? EnforcementPoint { get; set; }
        /// <summary>
        /// Statistics for the specified enforcement point
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        [NSXTProperty(IsRequired: false, Description: @"Statistics for the specified enforcement point")]
        public NSXTSecurityPolicyStatisticsType Statistics { get; set; }
    }
}
