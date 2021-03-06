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
    /// The load balancer node usage summary for all nodes. Only EdgeNode is
        /// supported. The summary calculation is based on all edge nodes
        /// configured in edge clusters.
    /// </summary>
    [NSXTProperty(Description: @"The load balancer node usage summary for all nodes. Only EdgeNode issupported. The summary calculation is based on all edge nodesconfigured in edge clusters.")]
    public class NSXTLbNodeUsageSummaryType 
    {
        /// <summary>
        /// The property identifies array of node count for each severity (RED,
        /// ORANGE and GREEN).
        /// </summary>
        [JsonProperty(PropertyName = "node_counts")]
        public IList<NSXTLbNodeCountPerSeverityType> NodeCounts { get; set; }
        /// <summary>
        /// The current credit number reflects the overall credit usage for
        /// all nodes.
        /// </summary>
        [JsonProperty(PropertyName = "current_credit_number")]
        public long? CurrentCreditNumber { get; set; }
        /// <summary>
        /// The property contains lb node usages for each node.
        /// </summary>
        [JsonProperty(PropertyName = "node_usages")]
        public IList<NSXTLbNodeUsageType> NodeUsages { get; set; }
        /// <summary>
        /// The severity calculation is based on current credit usage percentage
        /// of load balancer for all nodes.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbNodeUsageSummarySeverityEnumType? Severity { get; set; }
        /// <summary>
        /// The overall remaining number of pool members which could be configured
        /// on all nodes.
        /// </summary>
        [JsonProperty(PropertyName = "remaining_pool_members")]
        public long? RemainingPoolMembers { get; set; }
        /// <summary>
        /// The overall number of pool members configured on all nodes.
        /// </summary>
        [JsonProperty(PropertyName = "current_pool_members")]
        public long? CurrentPoolMembers { get; set; }
        /// <summary>
        /// The overall usage percentage of all nodes for load balancer.
        /// The value is the larger value between overall pool member usage
        /// percentage and overall load balancer credit usage percentage.
        /// </summary>
        [JsonProperty(PropertyName = "usage_percentage")]
        public double? UsagePercentage { get; set; }
        /// <summary>
        /// The remaining credit number is the overall remaining credits that can
        /// be used for load balancer service configuration for all nodes.
        /// </summary>
        [JsonProperty(PropertyName = "remaining_credit_number")]
        public long? RemainingCreditNumber { get; set; }
    }
}
