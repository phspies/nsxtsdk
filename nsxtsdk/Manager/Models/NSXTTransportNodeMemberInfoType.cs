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
    /// Information about participating transport nodes
    /// </summary>
    [NSXTProperty(Description: @"Information about participating transport nodes")]
    public class NSXTTransportNodeMemberInfoType 
    {
        /// <summary>
        /// List of host switches using the transport zone
        /// </summary>
        [JsonProperty(PropertyName = "host_switches")]
        public IList<NSXTHostSwitchInfoType> HostSwitches { get; set; }
        /// <summary>
        /// Display name of the transport node which has one or more host switches which belong to associated transport zone.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_display_name")]
        public string? TransportNodeDisplayName { get; set; }
        /// <summary>
        /// Id of the compute collection to which this transport node belongs. Empty if this is standalone transport node or non ESX
        /// type node.
        /// </summary>
        [JsonProperty(PropertyName = "compute_collection_id")]
        public string? ComputeCollectionId { get; set; }
        /// <summary>
        /// Id of the transport node which has one or more host switches which belong to associated transport zone.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id")]
        public string? TransportNodeId { get; set; }
    }
}
