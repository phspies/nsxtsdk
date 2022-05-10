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
    /// Transport zone runtime status information
    /// </summary>
    [NSXTProperty(Description: @"Transport zone runtime status information")]
    public class NSXTTransportZoneStatusType 
    {
        /// <summary>
        /// Count of logical ports in the transport zone
        /// </summary>
        [JsonProperty(PropertyName = "num_logical_ports")]
        public int? NumLogicalPorts { get; set; }
        /// <summary>
        /// Unique ID identifying the transport zone
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_id")]
        public string? TransportZoneId { get; set; }
        /// <summary>
        /// Information about transport nodes which are part of this transport zone
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_members")]
        public IList<NSXTTransportNodeMemberInfoType> TransportNodeMembers { get; set; }
        /// <summary>
        /// Count of logical switches in the transport zone
        /// </summary>
        [JsonProperty(PropertyName = "num_logical_switches")]
        public int? NumLogicalSwitches { get; set; }
        /// <summary>
        /// Count of transport nodes in the transport zone
        /// </summary>
        [JsonProperty(PropertyName = "num_transport_nodes")]
        public int? NumTransportNodes { get; set; }
    }
}
