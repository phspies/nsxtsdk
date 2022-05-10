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
    /// Describes usage summary of virtual servers, pools and pool members for
        /// all load balancer services.
    /// </summary>
    [NSXTProperty(Description: @"Describes usage summary of virtual servers, pools and pool members forall load balancer services.")]
    public class NSXTLBServiceUsageSummaryType 
    {
        /// <summary>
        /// Overall pool usage percentage for all load balancer services.
        /// </summary>
        [JsonProperty(PropertyName = "pool_usage_percentage")]
        public double? PoolUsagePercentage { get; set; }
        /// <summary>
        /// Pool capacity means maximum number of pools which can be configured
        /// for all load balancer services.
        /// </summary>
        [JsonProperty(PropertyName = "pool_capacity")]
        public long? PoolCapacity { get; set; }
        /// <summary>
        /// The severity calculation is based on the overall usage percentage of
        /// pool members for all load balancer services.
        /// </summary>
        [JsonProperty(PropertyName = "pool_member_severity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbserviceUsageSummaryPoolMemberSeverityEnumType? PoolMemberSeverity { get; set; }
        /// <summary>
        /// Pool capacity means maximum number of pool members which can be
        /// configured for all load balancer services.
        /// </summary>
        [JsonProperty(PropertyName = "pool_member_capacity")]
        public long? PoolMemberCapacity { get; set; }
        /// <summary>
        /// Overall pool member usage percentage for all load balancer services.
        /// </summary>
        [JsonProperty(PropertyName = "pool_member_usage_percentage")]
        public double? PoolMemberUsagePercentage { get; set; }
        /// <summary>
        /// The current count of virtual servers configured for all load balancer
        /// services.
        /// </summary>
        [JsonProperty(PropertyName = "current_virtual_server_count")]
        public long? CurrentVirtualServerCount { get; set; }
        /// <summary>
        /// The current count of pools configured for all load balancer services.
        /// </summary>
        [JsonProperty(PropertyName = "current_pool_count")]
        public long? CurrentPoolCount { get; set; }
        /// <summary>
        /// The current count of pool members configured for all load balancer
        /// services.
        /// </summary>
        [JsonProperty(PropertyName = "current_pool_member_count")]
        public long? CurrentPoolMemberCount { get; set; }
        /// <summary>
        /// The severity calculation is based on the overall usage percentage of
        /// pools for all load balancer services.
        /// </summary>
        [JsonProperty(PropertyName = "pool_severity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbserviceUsageSummaryPoolSeverityEnumType? PoolSeverity { get; set; }
        /// <summary>
        /// The property identifies all lb service usages. By default, it is not
        /// included in response. It exists when parameter ?include_usages=true.
        /// </summary>
        [JsonProperty(PropertyName = "service_usages")]
        public IList<NSXTLBServiceUsageType> ServiceUsages { get; set; }
        /// <summary>
        /// Overall virtual server usage percentage for all load balancer services.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_server_usage_percentage")]
        public double? VirtualServerUsagePercentage { get; set; }
        /// <summary>
        /// The severity calculation is based on the overall usage percentage of
        /// virtual servers for all load balancer services.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_server_severity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbserviceUsageSummaryVirtualServerSeverityEnumType? VirtualServerSeverity { get; set; }
        /// <summary>
        /// The service count for each load balancer usage severity.
        /// </summary>
        [JsonProperty(PropertyName = "service_counts")]
        public IList<NSXTLBServiceCountPerSeverityType> ServiceCounts { get; set; }
        /// <summary>
        /// Virtual server capacity means maximum number of virtual servers which
        /// can be configured for all load balancer services.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_server_capacity")]
        public long? VirtualServerCapacity { get; set; }
    }
}
