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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIpPoolType : NSXTManagedResourceType
    {
        /// <summary>
        /// If true, a validation error will be thrown if another IP pool is found to be overlapping with this pool.
        /// The flag is false by default.
        /// </summary>
        [JsonProperty(PropertyName = "check_overlap_with_existing_pools")]
        public bool? CheckOverlapWithExistingPools { get; set; }
        /// <summary>
        /// Subnets can be IPv4 or IPv6 and they should not overlap. The maximum number will not exceed 5 subnets.
        /// </summary>
        [JsonProperty(PropertyName = "subnets")]
        public IList<NSXTIpPoolSubnetType> Subnets { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pool_usage")]
        public NSXTPoolUsageType PoolUsage { get; set; }
        /// <summary>
        /// Delay in milliseconds, while releasing allocated IP address from IP pool (Default is 2 mins).
        /// </summary>
        [JsonProperty(PropertyName = "ip_release_delay")]
        public long? IpReleaseDelay { get; set; }
    }
}
