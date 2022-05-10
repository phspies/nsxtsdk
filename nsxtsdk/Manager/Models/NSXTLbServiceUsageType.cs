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
    /// Describes the capacity and current usage of virtual servers, pools, pool
        /// members for the given load balancer service.
    /// </summary>
    [NSXTProperty(Description: @"Describes the capacity and current usage of virtual servers, pools, poolmembers for the given load balancer service.")]
    public class NSXTLbServiceUsageType 
    {
        /// <summary>
        /// Pool capacity means maximum number of pools which could be configured
        /// in the given load balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "pool_capacity")]
        public long? PoolCapacity { get; set; }
        /// <summary>
        /// The size of load balancer service
        /// </summary>
        [JsonProperty(PropertyName = "service_size")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbServiceUsageServiceSizeEnumType? ServiceSize { get; set; }
        /// <summary>
        /// The severity calculation is based on the largest usage percentage from
        /// virtual servers, pools, pool members and rules for one load balancer
        /// service.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbServiceUsageSeverityEnumType? Severity { get; set; }
        /// <summary>
        /// Pool member capacity means maximum number of pool members which could
        /// be configured in the given load balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "pool_member_capacity")]
        public long? PoolMemberCapacity { get; set; }
        /// <summary>
        /// The current number of virtual servers which have been configured in the
        /// given load balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "current_virtual_server_count")]
        public long? CurrentVirtualServerCount { get; set; }
        /// <summary>
        /// The usage percentage is the largest usage percentage from virtual
        /// servers, pools and pool members for the load balancer service. If the
        /// property relax_scale_validation is set as true for LbService, it is
        /// possible that the value is larger than 100.0. For example, if SMALL LBS
        /// is deployed on MEDIUM edge node and configured with MEDIUM LBS virtual
        /// server scale number, LBS usage percentage is shown larger than 100.0.
        /// </summary>
        [JsonProperty(PropertyName = "usage_percentage")]
        public double? UsagePercentage { get; set; }
        /// <summary>
        /// UUID of load balancer service
        /// </summary>
        [JsonProperty(PropertyName = "service_id")]
        public string? ServiceId { get; set; }
        /// <summary>
        /// The current number of pools which have been configured in the given load
        /// balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "current_pool_count")]
        public long? CurrentPoolCount { get; set; }
        /// <summary>
        /// Virtual server capacity means maximum number of virtual servers which
        /// could be configured in the given load balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_server_capacity")]
        public long? VirtualServerCapacity { get; set; }
        /// <summary>
        /// The current number of pool members which have been configured in the
        /// given load balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "current_pool_member_count")]
        public long? CurrentPoolMemberCount { get; set; }
    }
}
