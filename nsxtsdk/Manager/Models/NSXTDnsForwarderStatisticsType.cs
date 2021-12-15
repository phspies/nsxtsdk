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
        [NSXTProperty(IsRequired: false, Description: @"The total number of forwarded dns queries")]
        public long? QueriesForwarded { get; set; }
        /// <summary>
        /// The statistics of conditional forwarders
        /// </summary>
        [JsonProperty(PropertyName = "conditional_forwarder_statistics")]
        [NSXTProperty(IsRequired: false, Description: @"The statistics of conditional forwarders")]
        public IList<NSXTPerForwarderStatisticsType> ConditionalForwarderStatistics { get; set; }
        /// <summary>
        /// The statistics of default forwarder
        /// </summary>
        [JsonProperty(PropertyName = "default_forwarder_statistics")]
        [NSXTProperty(IsRequired: false, Description: @"The statistics of default forwarder")]
        public NSXTPerForwarderStatisticsType DefaultForwarderStatistics { get; set; }
        /// <summary>
        /// The totocal number of queries answered from local cache
        /// </summary>
        [JsonProperty(PropertyName = "queries_answered_locally")]
        [NSXTProperty(IsRequired: false, Description: @"The totocal number of queries answered from local cache")]
        public long? QueriesAnsweredLocally { get; set; }
        /// <summary>
        /// The statistics of used cache
        /// </summary>
        [JsonProperty(PropertyName = "used_cache_statistics")]
        [NSXTProperty(IsRequired: false, Description: @"The statistics of used cache")]
        public IList<NSXTPerNodeUsedCacheStatisticsType> UsedCacheStatistics { get; set; }
        /// <summary>
        /// The configured cache size, in kb
        /// </summary>
        [JsonProperty(PropertyName = "configured_cache_size")]
        [NSXTProperty(IsRequired: false, Description: @"The configured cache size, in kb")]
        public long? ConfiguredCacheSize { get; set; }
        /// <summary>
        /// Time stamp of the current statistics, in ms
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Time stamp of the current statistics, in ms")]
        public long? Timestamp { get; set; }
        /// <summary>
        /// Error message, if available
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        [NSXTProperty(IsRequired: false, Description: @"Error message, if available")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// The total number of received dns queries
        /// </summary>
        [JsonProperty(PropertyName = "total_queries")]
        [NSXTProperty(IsRequired: false, Description: @"The total number of received dns queries")]
        public long? TotalQueries { get; set; }
    }
}
