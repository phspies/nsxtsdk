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
    public class NSXTLBEdgeNodeUsageType : NSXTLBNodeUsageType
    {
        /// <summary>
        /// The count of medium load balancer services configured on the node.
        /// </summary>
        [JsonProperty(PropertyName = "current_medium_load_balancer_count")]
        public long? CurrentMediumLoadBalancerCount { get; set; }
        /// <summary>
        /// The remaining count of xlarge load balancer services which can be
        /// configured on the given edge node.
        /// </summary>
        [JsonProperty(PropertyName = "remaining_xlarge_load_balancer_count")]
        public long? RemainingXlargeLoadBalancerCount { get; set; }
        /// <summary>
        /// The severity calculation is based on current credit usage percentage
        /// of load balancer for one node.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbedgeNodeUsageSeverityEnumType? Severity { get; set; }
        /// <summary>
        /// Pool member capacity means maximum number of pool members which can
        /// be configured on the given edge node.
        /// </summary>
        [JsonProperty(PropertyName = "pool_member_capacity")]
        public long? PoolMemberCapacity { get; set; }
        /// <summary>
        /// The count of virtual servers configured on the node.
        /// </summary>
        [JsonProperty(PropertyName = "current_virtual_server_count")]
        public long? CurrentVirtualServerCount { get; set; }
        /// <summary>
        /// The count of xlarge load balancer services configured on the node.
        /// </summary>
        [JsonProperty(PropertyName = "current_xlarge_load_balancer_count")]
        public long? CurrentXlargeLoadBalancerCount { get; set; }
        /// <summary>
        /// The count of pools configured on the node.
        /// </summary>
        [JsonProperty(PropertyName = "current_pool_count")]
        public long? CurrentPoolCount { get; set; }
        /// <summary>
        /// The remaining count of small load balancer services which can be
        /// configured on the given edge node.
        /// </summary>
        [JsonProperty(PropertyName = "remaining_small_load_balancer_count")]
        public long? RemainingSmallLoadBalancerCount { get; set; }
        /// <summary>
        /// The count of pool members configured on the node.
        /// </summary>
        [JsonProperty(PropertyName = "current_pool_member_count")]
        public long? CurrentPoolMemberCount { get; set; }
        /// <summary>
        /// The load balancer credit capacity means the maximum credits which can
        /// be used for load balancer configuration for the given edge node.
        /// </summary>
        [JsonProperty(PropertyName = "load_balancer_credit_capacity")]
        public long? LoadBalancerCreditCapacity { get; set; }
        /// <summary>
        /// The path of edge cluster which contains the edge node.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_path")]
        public string? EdgeClusterPath { get; set; }
        /// <summary>
        /// The current load balancer credits means the current credits used on the
        /// node. For example, configuring a medium load balancer on a node
        /// consumes 10 credits. If there are 2 medium instances configured on a
        /// node, the current credit number is 2 * 10 = 20.
        /// </summary>
        [JsonProperty(PropertyName = "current_load_balancer_credits")]
        public long? CurrentLoadBalancerCredits { get; set; }
        /// <summary>
        /// The remaining count of large load balancer services which can be
        /// configured on the given edge node.
        /// </summary>
        [JsonProperty(PropertyName = "remaining_large_load_balancer_count")]
        public long? RemainingLargeLoadBalancerCount { get; set; }
        /// <summary>
        /// The count of large load balancer services configured on the node.
        /// </summary>
        [JsonProperty(PropertyName = "current_large_load_balancer_count")]
        public long? CurrentLargeLoadBalancerCount { get; set; }
        /// <summary>
        /// The form factor of the given edge node.
        /// </summary>
        [JsonProperty(PropertyName = "form_factor")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbedgeNodeUsageFormFactorEnumType? FormFactor { get; set; }
        /// <summary>
        /// The usage percentage of the edge node for load balancer.
        /// The value is the larger value between load balancer credit usage
        /// percentage and pool member usage percentage for the edge node.
        /// </summary>
        [JsonProperty(PropertyName = "usage_percentage")]
        public double? UsagePercentage { get; set; }
        /// <summary>
        /// The count of small load balancer services configured on the node.
        /// </summary>
        [JsonProperty(PropertyName = "current_small_load_balancer_count")]
        public long? CurrentSmallLoadBalancerCount { get; set; }
        /// <summary>
        /// The remaining count of medium load balancer services which can be
        /// configured on the given edge node.
        /// </summary>
        [JsonProperty(PropertyName = "remaining_medium_load_balancer_count")]
        public long? RemainingMediumLoadBalancerCount { get; set; }
    }
}
