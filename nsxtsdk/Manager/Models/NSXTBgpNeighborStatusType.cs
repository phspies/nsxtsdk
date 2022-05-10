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
    public class NSXTBgpNeighborStatusType 
    {
        /// <summary>
        /// Current state of the BGP session.
        /// </summary>
        [JsonProperty(PropertyName = "connection_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBgpNeighborStatusConnectionStateEnumType? ConnectionState { get; set; }
        /// <summary>
        /// Count of messages received from the neighbor
        /// </summary>
        [JsonProperty(PropertyName = "messages_received")]
        public long? MessagesReceived { get; set; }
        /// <summary>
        /// Time in ms to wait for HELLO packet from BGP peer
        /// </summary>
        [JsonProperty(PropertyName = "keep_alive_interval")]
        public long? KeepAliveInterval { get; set; }
        /// <summary>
        /// Router ID of the BGP neighbor.
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_router_id")]
        public string? NeighborRouterId { get; set; }
        /// <summary>
        /// Sum of out prefixes counts across all address families.
        /// </summary>
        [JsonProperty(PropertyName = "total_out_prefix_count")]
        public long? TotalOutPrefixCount { get; set; }
        /// <summary>
        /// Logical router component(Service Router/Distributed Router) id
        /// </summary>
        [JsonProperty(PropertyName = "lr_component_id")]
        public string? LrComponentId { get; set; }
        /// <summary>
        /// Count of connections established
        /// </summary>
        [JsonProperty(PropertyName = "established_connection_count")]
        public long? EstablishedConnectionCount { get; set; }
        /// <summary>
        /// Count of messages sent to the neighbor
        /// </summary>
        [JsonProperty(PropertyName = "messages_sent")]
        public long? MessagesSent { get; set; }
        /// <summary>
        /// Time(in seconds) since connection was established.
        /// </summary>
        [JsonProperty(PropertyName = "time_since_established")]
        public long? TimeSinceEstablished { get; set; }
        /// <summary>
        /// Time in ms to wait for HELLO from BGP peer. If a HELLO packet is not seen from BGP Peer withing hold_time then BGP
        /// neighbor will be marked as down.
        /// </summary>
        [JsonProperty(PropertyName = "hold_time")]
        public long? HoldTime { get; set; }
        /// <summary>
        /// Current state of graceful restart where
        /// graceful_restart = true indicates graceful restart is enabled and
        /// graceful_restart = false indicates graceful restart is disabled.
        /// This is deprecated field, use graceful_restart_mode instead.
        /// </summary>
        [JsonProperty(PropertyName = "graceful_restart")]
        public bool? GracefulRestart { get; set; }
        /// <summary>
        /// Current state of graceful restart of BGP neighbor. Possible
        /// values are -
        /// 1. GR_AND_HELPER - Graceful restart with Helper
        /// 2. HELPER_ONLY - Helper only
        /// 3. DISABLE - Disabled
        /// </summary>
        [JsonProperty(PropertyName = "graceful_restart_mode")]
        public string? GracefulRestartMode { get; set; }
        /// <summary>
        /// Count of connection drop
        /// </summary>
        [JsonProperty(PropertyName = "connection_drop_count")]
        public long? ConnectionDropCount { get; set; }
        /// <summary>
        /// TCP port number of remote BGP Connection
        /// </summary>
        [JsonProperty(PropertyName = "remote_port")]
        public long? RemotePort { get; set; }
        /// <summary>
        /// The Ip address of logical port
        /// </summary>
        [JsonProperty(PropertyName = "source_address")]
        public string? SourceAddress { get; set; }
        /// <summary>
        /// Sum of in prefixes counts across all address families.
        /// </summary>
        [JsonProperty(PropertyName = "total_in_prefix_count")]
        public long? TotalInPrefixCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "remote_site")]
        public NSXTResourceReferenceType RemoteSite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "transport_node")]
        public NSXTResourceReferenceType TransportNode { get; set; }
        /// <summary>
        /// TCP port number of Local BGP connection
        /// </summary>
        [JsonProperty(PropertyName = "local_port")]
        public long? LocalPort { get; set; }
        /// <summary>
        /// AS number of the BGP neighbor
        /// </summary>
        [JsonProperty(PropertyName = "remote_as_number")]
        public string? RemoteAsNumber { get; set; }
        /// <summary>
        /// BGP capabilities sent to BGP neighbor.
        /// </summary>
        [JsonProperty(PropertyName = "announced_capabilities")]
        public IList<string> AnnouncedCapabilities { get; set; }
        /// <summary>
        /// BGP capabilities negotiated with BGP neighbor.
        /// </summary>
        [JsonProperty(PropertyName = "negotiated_capability")]
        public IList<string> NegotiatedCapability { get; set; }
        /// <summary>
        /// Address families of BGP neighbor
        /// </summary>
        [JsonProperty(PropertyName = "address_families")]
        public IList<NSXTBgpAddressFamilyType> AddressFamilies { get; set; }
        /// <summary>
        /// BGP neighbor type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBgpNeighborStatusTypeEnumType? Type { get; set; }
        /// <summary>
        /// The IP of the BGP neighbor
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_address")]
        public string? NeighborAddress { get; set; }
    }
}
