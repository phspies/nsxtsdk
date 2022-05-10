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
    /// Routing table.
    /// </summary>
    [NSXTProperty(Description: @"Routing table.")]
    public class NSXTRoutingTableType 
    {
        /// <summary>
        /// Entry count.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }
        /// <summary>
        /// Routing table fetch status from Transport node.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRoutingTableStatusEnumType? Status { get; set; }
        /// <summary>
        /// Route entries.
        /// </summary>
        [JsonProperty(PropertyName = "route_entries", Required = Required.AllowNull)]
        public IList<NSXTRoutingEntryType> RouteEntries { get; set; }
        /// <summary>
        /// Routing table fetch error message, populated only if status if failure.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
        /// <summary>
        /// Transport node ID.
        /// </summary>
        [JsonProperty(PropertyName = "edge_node")]
        public string? EdgeNode { get; set; }
    }
}
