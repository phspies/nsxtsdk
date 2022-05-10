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
    public class NSXTBfdConfigType : NSXTManagedResourceType
    {
        /// <summary>
        /// the time interval (in milliseconds) between heartbeat packets for BFD when receiving heartbeats.
        /// </summary>
        [JsonProperty(PropertyName = "receive_interval")]
        public long? ReceiveInterval { get; set; }
        /// <summary>
        /// Number of times a packet is missed before BFD declares the neighbor down.
        /// </summary>
        [JsonProperty(PropertyName = "declare_dead_multiple")]
        public long? DeclareDeadMultiple { get; set; }
        /// <summary>
        /// Flag to enable BFD for this LogicalRouter
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Logical router id
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        public string? LogicalRouterId { get; set; }
        /// <summary>
        /// the time interval (in milliseconds) between heartbeat packets for BFD when sending heartbeats.
        /// </summary>
        [JsonProperty(PropertyName = "transmit_interval")]
        public long? TransmitInterval { get; set; }
    }
}
