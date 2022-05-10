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
    /// BGP routes per transport node.
    /// </summary>
    [NSXTProperty(Description: @"BGP routes per transport node.")]
    public class NSXTRoutesPerTransportNodeType 
    {
        /// <summary>
        /// Array of BGP neighbor route details for this transport node.
        /// </summary>
        [JsonProperty(PropertyName = "routes")]
        public IList<NSXTRouteDetailsType> Routes { get; set; }
        /// <summary>
        /// BGP neighbor source address.
        /// </summary>
        [JsonProperty(PropertyName = "source_address")]
        public string? SourceAddress { get; set; }
        /// <summary>
        /// Transport node id
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id")]
        public string? TransportNodeId { get; set; }
    }
}
