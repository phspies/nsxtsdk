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
    /// Gives the statistics of a NAT rule per enforcement point.
    /// </summary>
    [NSXTProperty(Description: @"Gives the statistics of a NAT rule per enforcement point.")]
    public class NSXTPolicyNatRuleStatisticsPerEnforcementPointType 
    {
        /// <summary>
        /// Gives NAT rule stats on an enforcement point.
        /// </summary>
        [JsonProperty(PropertyName = "rule_statistics")]
        public IList<NSXTPolicyNatRuleStatisticsType> RuleStatistics { get; set; }
        /// <summary>
        /// Path of NAT Rule.
        /// </summary>
        [JsonProperty(PropertyName = "rule_path")]
        public string? RulePath { get; set; }
        /// <summary>
        /// Policy Path referencing the enforcement point from where the statistics are fetched.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        public string? EnforcementPointPath { get; set; }
    }
}
