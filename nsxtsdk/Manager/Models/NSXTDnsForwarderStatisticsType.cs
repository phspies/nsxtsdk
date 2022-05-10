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
    /// The current statistics counters of the DNS forwarder including cache usages
        /// and query numbers per forwarders.
    /// </summary>
    [NSXTProperty(Description: @"The current statistics counters of the DNS forwarder including cache usagesand query numbers per forwarders.")]
    public class NSXTDnsForwarderStatisticsType 
    {
        /// <summary>
        /// The total number of forwarded dns queries
        /// </summary>
        [JsonProperty(PropertyName = "queries_forwarded")]
        public long? QueriesForwarded { get; set; }
        /// <summary>
        /// The statistics of conditional forwarders
        /// </summary>
        [JsonProperty(PropertyName = "conditional_forwarder_statistics")]
        public IList<NSXTPerForwarderStatisticsType> ConditionalForwarderStatistics { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "default_forwarder_statistics")]
        public NSXTPerForwarderStatisticsType DefaultForwarderStatistics { get; set; }
        /// <summary>
        /// The totocal number of queries answered from local cache
        /// </summary>
        [JsonProperty(PropertyName = "queries_answered_locally")]
        public long? QueriesAnsweredLocally { get; set; }
        /// <summary>
        /// The statistics of used cache
        /// </summary>
        [JsonProperty(PropertyName = "used_cache_statistics")]
        public IList<NSXTPerNodeUsedCacheStatisticsType> UsedCacheStatistics { get; set; }
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
        /// Error message, if available
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// The total number of received dns queries
        /// </summary>
        [JsonProperty(PropertyName = "total_queries")]
        public long? TotalQueries { get; set; }
    }
}
