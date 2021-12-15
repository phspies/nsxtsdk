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
    /// Transport zone runtime status information
    /// </summary>
    [NSXTProperty(Description: @"Transport zone runtime status information")]
    public class NSXTTransportZoneStatusType 
    {
        /// <summary>
        /// Count of logical ports in the transport zone
        /// </summary>
        [JsonProperty(PropertyName = "num_logical_ports")]
        [NSXTProperty(IsRequired: false, Description: @"Count of logical ports in the transport zone")]
        public int? NumLogicalPorts { get; set; }
        /// <summary>
        /// Unique ID identifying the transport zone
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_id")]
        [NSXTProperty(IsRequired: false, Description: @"Unique ID identifying the transport zone")]
        public string? TransportZoneId { get; set; }
        /// <summary>
        /// Information about transport nodes which are part of this transport zone
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_members")]
        [NSXTProperty(IsRequired: false, Description: @"Information about transport nodes which are part of this transport zone")]
        public IList<NSXTTransportNodeMemberInfoType> TransportNodeMembers { get; set; }
        /// <summary>
        /// Count of logical switches in the transport zone
        /// </summary>
        [JsonProperty(PropertyName = "num_logical_switches")]
        [NSXTProperty(IsRequired: false, Description: @"Count of logical switches in the transport zone")]
        public int? NumLogicalSwitches { get; set; }
        /// <summary>
        /// Count of transport nodes in the transport zone
        /// </summary>
        [JsonProperty(PropertyName = "num_transport_nodes")]
        [NSXTProperty(IsRequired: false, Description: @"Count of transport nodes in the transport zone")]
        public int? NumTransportNodes { get; set; }
    }
}
