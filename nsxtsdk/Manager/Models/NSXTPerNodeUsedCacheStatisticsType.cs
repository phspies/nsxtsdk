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
    /// Query statistics counters of used cache from node
    /// </summary>
    [NSXTProperty(Description: @"Query statistics counters of used cache from node")]
    public class NSXTPerNodeUsedCacheStatisticsType 
    {
        /// <summary>
        /// The total number of cached entries
        /// </summary>
        [JsonProperty(PropertyName = "cached_entries")]
        public long? CachedEntries { get; set; }
        /// <summary>
        /// Uuid of active/standby transport node
        /// </summary>
        [JsonProperty(PropertyName = "node_id")]
        public string? NodeId { get; set; }
        /// <summary>
        /// The memory size used in cache, in kb
        /// </summary>
        [JsonProperty(PropertyName = "used_cache_size")]
        public long? UsedCacheSize { get; set; }
    }
}
