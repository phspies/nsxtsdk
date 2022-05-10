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
    public class NSXTIpAddressPoolType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// If an existing IpAddressPool is found that overlaps with the given IpAddressPool,
        /// then a validation error would be thrown while realization.
        /// It is false by default.
        /// </summary>
        [JsonProperty(PropertyName = "check_overlap_with_existing_pools")]
        public bool? CheckOverlapWithExistingPools { get; set; }
        /// <summary>
        /// Delay in milliseconds, while releasing allocated IP address from IP pool (Default is 2 mins).
        /// </summary>
        [JsonProperty(PropertyName = "ip_release_delay")]
        public long? IpReleaseDelay { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pool_usage")]
        public NSXTPolicyPoolUsageType PoolUsage { get; set; }
    }
}
