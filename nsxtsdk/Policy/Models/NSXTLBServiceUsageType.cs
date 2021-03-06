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
    public class NSXTLBServiceUsageType : NSXTLBServiceUsagePerEPType
    {
        /// <summary>
        /// Pool capacity means maximum number of pools which could be configured in
        /// the given load balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "pool_capacity")]
        public long? PoolCapacity { get; set; }
        /// <summary>
        /// The size of load balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "service_size")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbserviceUsageServiceSizeEnumType? ServiceSize { get; set; }
        /// <summary>
        /// The severity calculation is based on the largest usage percentage from
        /// virtual servers, pools and pool members for one load balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbserviceUsageSeverityEnumType? Severity { get; set; }
        /// <summary>
        /// Pool member capacity means maximum number of pool members which could be
        /// configured in the given load balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "pool_member_capacity")]
        public long? PoolMemberCapacity { get; set; }
        /// <summary>
        /// The current number of virtual servers which has been configured in the
        /// given load balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "current_virtual_server_count")]
        public long? CurrentVirtualServerCount { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// The current number of pools which has been configured in the given load
        /// balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "current_pool_count")]
        public long? CurrentPoolCount { get; set; }
        /// <summary>
        /// The current number of pool members which has been configured in the given
        /// load balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "current_pool_member_count")]
        public long? CurrentPoolMemberCount { get; set; }
        /// <summary>
        /// The usage percentage is the largest usage percentage from virtual
        /// servers, pools and pool members for the load balancer service. If the
        /// property relax_scale_validation is set as true for LBService, it is
        /// possible that the value is larger than 100.0. For example, if SMALL LBS
        /// is deployed on MEDIUM edge node and configured with MEDIUM LBS virtual
        /// server scale number, LBS usage percentage is shown larger than 100.0.
        /// </summary>
        [JsonProperty(PropertyName = "usage_percentage")]
        public double? UsagePercentage { get; set; }
        /// <summary>
        /// Virtual server capacity means maximum number of virtual servers which
        /// could be configured in the given load balancer service.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_server_capacity")]
        public long? VirtualServerCapacity { get; set; }
        /// <summary>
        /// LBService object path.
        /// </summary>
        [JsonProperty(PropertyName = "service_path")]
        public string? ServicePath { get; set; }
    }
}
