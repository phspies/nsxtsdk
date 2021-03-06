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
    /// The array of the failed DNS queries with entry count and timestamp
        /// on active and standby transport node.
    /// </summary>
    [NSXTProperty(Description: @"The array of the failed DNS queries with entry count and timestampon active and standby transport node.")]
    public class NSXTDnsFailedQueriesType 
    {
        /// <summary>
        /// Timestamp of the request, in YYYY-MM-DD HH:MM:SS.zzz format.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public string? Timestamp { get; set; }
        /// <summary>
        /// The array of failed DNS queries on active and standby transport node.
        /// If there is no standby node, the failed queries on standby node will
        /// not be present.
        /// </summary>
        [JsonProperty(PropertyName = "per_node_failed_queries")]
        public IList<NSXTPerNodeDnsFailedQueriesType> PerNodeFailedQueries { get; set; }
    }
}
