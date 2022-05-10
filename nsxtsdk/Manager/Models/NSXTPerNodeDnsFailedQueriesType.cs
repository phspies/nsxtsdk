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
    public class NSXTPerNodeDnsFailedQueriesType : NSXTListResultType
    {
        /// <summary>
        /// Timestamp of the request, in YYYY-MM-DD HH:MM:SS.zzz format.
        /// </summary>
        [JsonProperty(PropertyName = "timestamp")]
        public string? Timestamp { get; set; }
        /// <summary>
        /// The Uuid of active/standby transport node.
        /// </summary>
        [JsonProperty(PropertyName = "node_id")]
        public string? NodeId { get; set; }
        /// <summary>
        /// The list of failed DNS queries.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTDnsFailedQueryType> Results { get; set; }
    }
}
