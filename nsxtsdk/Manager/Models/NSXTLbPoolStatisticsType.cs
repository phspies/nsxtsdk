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
    public class NSXTLbPoolStatisticsType 
    {
        /// <summary>
        /// Timestamp when the data was last updated
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "statistics", Required = Required.AllowNull)]
        public NSXTLbStatisticsCounterType Statistics { get; set; }
        /// <summary>
        /// Load balancer pool identifier
        /// </summary>
        [JsonProperty(PropertyName = "pool_id", Required = Required.AllowNull)]
        public string PoolId { get; set; }
        /// <summary>
        /// Statistics of load balancer pool members
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<NSXTLbPoolMemberStatisticsType> Members { get; set; }
    }
}
