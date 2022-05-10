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
    /// Query statistics counters to an upstream server including successfully
        /// forwarded queries and failed queries.
    /// </summary>
    [NSXTProperty(Description: @"Query statistics counters to an upstream server including successfullyforwarded queries and failed queries.")]
    public class NSXTNsxTUpstreamServerStatisticsType 
    {
        /// <summary>
        /// Queries failed to forward.
        /// </summary>
        [JsonProperty(PropertyName = "queries_failed")]
        public long? QueriesFailed { get; set; }
        /// <summary>
        /// Upstream server ip
        /// </summary>
        [JsonProperty(PropertyName = "upstream_server")]
        public string? UpstreamServer { get; set; }
        /// <summary>
        /// Queries forwarded successfully
        /// </summary>
        [JsonProperty(PropertyName = "queries_succeeded")]
        public long? QueriesSucceeded { get; set; }
    }
}
