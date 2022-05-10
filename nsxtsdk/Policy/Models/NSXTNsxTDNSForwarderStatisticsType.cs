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
    public class NSXTNsxTDNSForwarderStatisticsType : NSXTDNSForwarderStatisticsPerEnforcementPointType
    {
        /// <summary>
        /// The total number of forwarded DNS queries
        /// </summary>
        [JsonProperty(PropertyName = "queries_forwarded")]
        public long? QueriesForwarded { get; set; }
        /// <summary>
        /// The total number of cached entries
        /// </summary>
        [JsonProperty(PropertyName = "cached_entries")]
        public long? CachedEntries { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "default_forwarder_statistics")]
        public NSXTNsxTDNSForwarderZoneStatisticsType DefaultForwarderStatistics { get; set; }
        /// <summary>
        /// The total number of queries answered from local cache
        /// </summary>
        [JsonProperty(PropertyName = "queries_answered_locally")]
        public long? QueriesAnsweredLocally { get; set; }
        /// <summary>
        /// The statistics of used cache
        /// </summary>
        [JsonProperty(PropertyName = "used_cache_statistics")]
        public IList<NSXTNsxTPerNodeUsedCacheStatisticsType> UsedCacheStatistics { get; set; }
        /// <summary>
        /// The configured cache size, in kb
        /// </summary>
        [JsonProperty(PropertyName = "configured_cache_size")]
        public long? ConfiguredCacheSize { get; set; }
        /// <summary>
        /// Time stamp of the current statistics, in ms
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public long? Timestamp { get; set; }
        /// <summary>
        /// The statistics of conditional forwarder zones
        /// </summary>
        [JsonProperty(PropertyName = "conditional_forwarder_statistics")]
        public IList<NSXTNsxTDNSForwarderZoneStatisticsType> ConditionalForwarderStatistics { get; set; }
        /// <summary>
        /// The total number of received DNS queries
        /// </summary>
        [JsonProperty(PropertyName = "total_queries")]
        public long? TotalQueries { get; set; }
    }
}
