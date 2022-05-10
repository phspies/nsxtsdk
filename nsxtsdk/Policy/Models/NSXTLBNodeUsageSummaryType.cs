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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLBNodeUsageSummaryType : NSXTPolicyRuntimeInfoPerEPType
    {
        /// <summary>
        /// Current load balancer credits in use for all nodes.
        /// For example, configuring a medium load balancer on a node consumes
        /// 10 credits. If there are 2 medium instances configured, the current
        /// load balancer credit number is 2 * 10 = 20.
        /// </summary>
        [JsonProperty(PropertyName = "current_load_balancer_credits")]
        public long? CurrentLoadBalancerCredits { get; set; }
        /// <summary>
        /// The load balancer credit capacity means the maximum credits which can
        /// be used for load balancer service configuration for all nodes.
        /// </summary>
        [JsonProperty(PropertyName = "load_balancer_credit_capacity")]
        public long? LoadBalancerCreditCapacity { get; set; }
        /// <summary>
        /// The property identifies all LB node usages. By default, it is not
        /// included in response. It exists when parameter ?include_usages=true.
        /// </summary>
        [JsonProperty(PropertyName = "node_usages")]
        public IList<NSXTLBNodeUsageType> NodeUsages { get; set; }
        /// <summary>
        /// The severity calculation is based on overall credit usage percentage
        /// of load balancer for all nodes.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbnodeUsageSummarySeverityEnumType? Severity { get; set; }
        /// <summary>
        /// Pool member capacity means maximum number of pool members which can
        /// be configured on all nodes.
        /// </summary>
        [JsonProperty(PropertyName = "pool_member_capacity")]
        public long? PoolMemberCapacity { get; set; }
        /// <summary>
        /// The property identifies array of node count for each severity.
        /// </summary>
        [JsonProperty(PropertyName = "node_counts")]
        public IList<NSXTLBNodeCountPerSeverityType> NodeCounts { get; set; }
        /// <summary>
        /// The overall count of pool members configured on all nodes.
        /// </summary>
        [JsonProperty(PropertyName = "current_pool_member_count")]
        public long? CurrentPoolMemberCount { get; set; }
        /// <summary>
        /// The overall usage percentage of all nodes for load balancer.
        /// The value is the larger value between overall pool member usage
        /// percentage and overall load balancer credit usage percentage.
        /// </summary>
        [JsonProperty(PropertyName = "usage_percentage")]
        public double? UsagePercentage { get; set; }
    }
}
