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
    public class NSXTBgpNeighborStatusLiteDtoType 
    {
        /// <summary>
        /// Current state of the BGP session.
        /// </summary>
        [JsonProperty(PropertyName = "connection_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBgpNeighborStatusLiteDtoConnectionStateEnumType? ConnectionState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "remote_site")]
        public NSXTResourceReferenceType RemoteSite { get; set; }
        /// <summary>
        /// Source Ip address.
        /// </summary>
        [JsonProperty(PropertyName = "source_address")]
        public string? SourceAddress { get; set; }
        /// <summary>
        /// Ip address of BGP neighbor.
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_address")]
        public string? NeighborAddress { get; set; }
    }
}
