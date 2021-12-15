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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLbEdgeNodeUsageType : NSXTLbNodeUsageType
    {
        /// <summary>
        /// The current credit number reflects the current usage on the node.
        /// For example, configuring a medium load balancer on a node consumes
        /// 10 credits. If there are 2 medium instances configured on a node,
        /// the current credit number is 2 * 10 = 20.
        /// </summary>
        [JsonProperty(PropertyName = "current_credit_number")]
        [NSXTProperty(IsRequired: false, Description: @"The current credit number reflects the current usage on the node.For example, configuring a medium load balancer on a node consumes10 credits. If there are 2 medium instances configured on a node,the current credit number is 2 * 10 = 20.")]
        public long? CurrentCreditNumber { get; set; }
        /// <summary>
        /// The form factor of the given edge node.
        /// </summary>
        [JsonProperty(PropertyName = "form_factor")]
        [NSXTProperty(IsRequired: false, Description: @"The form factor of the given edge node.")]
        public NSXTLbEdgeNodeUsageFormFactorEnumType? FormFactor { get; set; }
        /// <summary>
        /// The number of virtual servers configured on the node.
        /// </summary>
        [JsonProperty(PropertyName = "current_virtual_servers")]
        [NSXTProperty(IsRequired: false, Description: @"The number of virtual servers configured on the node.")]
        public long? CurrentVirtualServers { get; set; }
        /// <summary>
        /// The number of small load balancer services configured on the node.
        /// </summary>
        [JsonProperty(PropertyName = "current_small_load_balancer_services")]
        [NSXTProperty(IsRequired: false, Description: @"The number of small load balancer services configured on the node.")]
        public long? CurrentSmallLoadBalancerServices { get; set; }
        /// <summary>
        /// The number of pool members configured on the node.
        /// </summary>
        [JsonProperty(PropertyName = "current_pool_members")]
        [NSXTProperty(IsRequired: false, Description: @"The number of pool members configured on the node.")]
        public long? CurrentPoolMembers { get; set; }
        /// <summary>
        /// The severity calculation is based on current credit usage percentage
        /// of load balancer for one node.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        [NSXTProperty(IsRequired: false, Description: @"The severity calculation is based on current credit usage percentageof load balancer for one node.")]
        public NSXTLbEdgeNodeUsageSeverityEnumType? Severity { get; set; }
        /// <summary>
        /// The number of pools configured on the node.
        /// </summary>
        [JsonProperty(PropertyName = "current_pools")]
        [NSXTProperty(IsRequired: false, Description: @"The number of pools configured on the node.")]
        public long? CurrentPools { get; set; }
        /// <summary>
        /// The remaining number of pool members which could be configured on the
        /// given edge node.
        /// </summary>
        [JsonProperty(PropertyName = "remaining_pool_members")]
        [NSXTProperty(IsRequired: false, Description: @"The remaining number of pool members which could be configured on thegiven edge node.")]
        public long? RemainingPoolMembers { get; set; }
        /// <summary>
        /// The ID of edge cluster which contains the edge node.
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_id")]
        [NSXTProperty(IsRequired: false, Description: @"The ID of edge cluster which contains the edge node.")]
        public string? EdgeClusterId { get; set; }
        /// <summary>
        /// The remaining number of xlarge load balancer services which could be
        /// configured on the given edge node.
        /// </summary>
        [JsonProperty(PropertyName = "remaining_xlarge_load_balancer_services")]
        [NSXTProperty(IsRequired: false, Description: @"The remaining number of xlarge load balancer services which could beconfigured on the given edge node.")]
        public long? RemainingXlargeLoadBalancerServices { get; set; }
        /// <summary>
        /// The remaining number of small load balancer services which could be
        /// configured on the given edge node.
        /// </summary>
        [JsonProperty(PropertyName = "remaining_small_load_balancer_services")]
        [NSXTProperty(IsRequired: false, Description: @"The remaining number of small load balancer services which could beconfigured on the given edge node.")]
        public long? RemainingSmallLoadBalancerServices { get; set; }
        /// <summary>
        /// The number of xlarge load balancer services configured on the node.
        /// </summary>
        [JsonProperty(PropertyName = "current_xlarge_load_balancer_services")]
        [NSXTProperty(IsRequired: false, Description: @"The number of xlarge load balancer services configured on the node.")]
        public long? CurrentXlargeLoadBalancerServices { get; set; }
        /// <summary>
        /// The usage percentage of the edge node for load balancer.
        /// The value is the larger value between load balancer credit usage
        /// percentage and pool member usage percentage for the edge node.
        /// </summary>
        [JsonProperty(PropertyName = "usage_percentage")]
        [NSXTProperty(IsRequired: false, Description: @"The usage percentage of the edge node for load balancer.The value is the larger value between load balancer credit usagepercentage and pool member usage percentage for the edge node.")]
        public double? UsagePercentage { get; set; }
        /// <summary>
        /// The number of large load balancer services configured on the node.
        /// </summary>
        [JsonProperty(PropertyName = "current_large_load_balancer_services")]
        [NSXTProperty(IsRequired: false, Description: @"The number of large load balancer services configured on the node.")]
        public long? CurrentLargeLoadBalancerServices { get; set; }
        /// <summary>
        /// The remaining credit number is the remaining credits that can be used
        /// for load balancer service configuration. For example, an edge node with
        /// form factor LARGE_VIRTUAL_MACHINE has 40 credits, and a medium
        /// load balancer instance costs 10 credits. If there are currently
        /// 3 medium instances configured, the remaining credit number is
        /// 40 - (3 * 10) = 10.
        /// </summary>
        [JsonProperty(PropertyName = "remaining_credit_number")]
        [NSXTProperty(IsRequired: false, Description: @"The remaining credit number is the remaining credits that can be usedfor load balancer service configuration. For example, an edge node withform factor LARGE_VIRTUAL_MACHINE has 40 credits, and a mediumload balancer instance costs 10 credits. If there are currently3 medium instances configured, the remaining credit number is40 - (3 * 10) = 10.")]
        public long? RemainingCreditNumber { get; set; }
        /// <summary>
        /// The remaining number of large load balancer services which could be
        /// configured on the given edge node.
        /// </summary>
        [JsonProperty(PropertyName = "remaining_large_load_balancer_services")]
        [NSXTProperty(IsRequired: false, Description: @"The remaining number of large load balancer services which could beconfigured on the given edge node.")]
        public long? RemainingLargeLoadBalancerServices { get; set; }
        /// <summary>
        /// The remaining number of medium load balancer services which could be
        /// configured on the given edge node.
        /// </summary>
        [JsonProperty(PropertyName = "remaining_medium_load_balancer_services")]
        [NSXTProperty(IsRequired: false, Description: @"The remaining number of medium load balancer services which could beconfigured on the given edge node.")]
        public long? RemainingMediumLoadBalancerServices { get; set; }
        /// <summary>
        /// The number of medium load balancer services configured on the node.
        /// </summary>
        [JsonProperty(PropertyName = "current_medium_load_balancer_services")]
        [NSXTProperty(IsRequired: false, Description: @"The number of medium load balancer services configured on the node.")]
        public long? CurrentMediumLoadBalancerServices { get; set; }
    }
}