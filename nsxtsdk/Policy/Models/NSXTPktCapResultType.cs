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
    /// The packet capture result for transport nodes
    /// </summary>
    [NSXTProperty(Description: @"The packet capture result for transport nodes")]
    public class NSXTPktCapResultType 
    {
        /// <summary>
        /// The packet capture resource info for ports where packet
        /// capture action is performed
        /// </summary>
        [JsonProperty(PropertyName = "pktcap_resource_list")]
        public IList<NSXTPktCapResourceType> PktcapResourceList { get; set; }
        /// <summary>
        /// Type of the transport node
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPktCapResultTransportNodeTypeEnumType? TransportNodeType { get; set; }
        /// <summary>
        /// The ID of transport node where packet capture action is deployed
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id")]
        public string? TransportNodeId { get; set; }
    }
}
