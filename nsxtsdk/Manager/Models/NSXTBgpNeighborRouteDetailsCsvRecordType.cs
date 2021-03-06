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
    public class NSXTBgpNeighborRouteDetailsCsvRecordType : NSXTCsvRecordType
    {
        /// <summary>
        /// BGP Multi Exit Discriminator attribute.
        /// </summary>
        [JsonProperty(PropertyName = "med")]
        public long? Med { get; set; }
        /// <summary>
        /// CIDR network address.
        /// </summary>
        [JsonProperty(PropertyName = "network")]
        public string? Network { get; set; }
        /// <summary>
        /// BGP Weight attribute.
        /// </summary>
        [JsonProperty(PropertyName = "weight")]
        public long? Weight { get; set; }
        /// <summary>
        /// Transport node id
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id")]
        public string? TransportNodeId { get; set; }
        /// <summary>
        /// BGP AS path attribute.
        /// </summary>
        [JsonProperty(PropertyName = "as_path")]
        public string? AsPath { get; set; }
        /// <summary>
        /// Next hop IP address.
        /// </summary>
        [JsonProperty(PropertyName = "next_hop")]
        public string? NextHop { get; set; }
        /// <summary>
        /// Logical router id
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        public string? LogicalRouterId { get; set; }
        /// <summary>
        /// BGP Local Preference attribute.
        /// </summary>
        [JsonProperty(PropertyName = "local_pref")]
        public long? LocalPref { get; set; }
        /// <summary>
        /// BGP neighbor source address.
        /// </summary>
        [JsonProperty(PropertyName = "source_address")]
        public string? SourceAddress { get; set; }
        /// <summary>
        /// BGP neighbor id
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_id")]
        public string? NeighborId { get; set; }
        /// <summary>
        /// BGP neighbor peer IP address.
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_address")]
        public string? NeighborAddress { get; set; }
    }
}
