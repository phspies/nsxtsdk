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
        [NSXTProperty(IsRequired: false, Description: @"Timestamp of the request, in YYYY-MM-DD HH:MM:SS.zzz format.")]
        public string? Timestamp { get; set; }
        /// <summary>
        /// The array of failed DNS queries on active and standby transport node.
        /// If there is no standby node, the failed queries on standby node will
        /// not be present.
        /// </summary>
        [JsonProperty(PropertyName = "per_node_failed_queries")]
        [NSXTProperty(IsRequired: false, Description: @"The array of failed DNS queries on active and standby transport node.If there is no standby node, the failed queries on standby node willnot be present.")]
        public IList<NSXTPerNodeDnsFailedQueriesType> PerNodeFailedQueries { get; set; }
    }
}
