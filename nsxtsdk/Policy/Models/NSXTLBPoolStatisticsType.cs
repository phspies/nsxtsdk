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
    public class NSXTLBPoolStatisticsType : NSXTLBPoolStatisticsPerEPType
    {
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public NSXTLBStatisticsCounterType Statistics { get; set; }
        /// <summary>
        /// Load balancer pool object path.
        /// </summary>
        [JsonProperty(PropertyName = "pool_path")]
        public string? PoolPath { get; set; }
        /// <summary>
        /// Statistics of load balancer pool members.
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<NSXTLBPoolMemberStatisticsType> Members { get; set; }
    }
}
