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
    /// Gives the statistics of a NAT rule per logical router on specified enforcement point.
    /// </summary>
    [NSXTProperty(Description: @"Gives the statistics of a NAT rule per logical router on specified enforcement point.")]
    public class NSXTPolicyNatRuleStatisticsPerLogicalRouterType 
    {
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Detailed Rule statistics per logical router.
        /// </summary>
        [JsonProperty(PropertyName = "per_node_statistics")]
        public IList<NSXTPolicyNatRuleStatisticsPerTransportNodeType> PerNodeStatistics { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public NSXTPolicyNATRuleCountersType Statistics { get; set; }
        /// <summary>
        /// Path of the router.
        /// </summary>
        [JsonProperty(PropertyName = "router_path")]
        public string? RouterPath { get; set; }
        /// <summary>
        /// Policy Path referencing the enforcement point from where the statistics are fetched.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        public string? EnforcementPointPath { get; set; }
    }
}
