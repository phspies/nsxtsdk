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
    /// BFD configuration for the given Peer.
    /// </summary>
    [NSXTProperty(Description: @"BFD configuration for the given Peer.")]
    public class NSXTBfdConfigParametersType 
    {
        /// <summary>
        /// The time interval (in milliseconds) between heartbeat packets for BFD when receiving heartbeats.| For edge cluster type
        /// of bare metal, this value should be >= 50ms.| For edge cluster type of virtual machine or hybrid, this value should be
        /// >= 500ms.
        /// </summary>
        [JsonProperty(PropertyName = "receive_interval")]
        public long? ReceiveInterval { get; set; }
        /// <summary>
        /// Number of times a packet is missed before BFD declares the neighbor down.
        /// </summary>
        [JsonProperty(PropertyName = "declare_dead_multiple")]
        public long? DeclareDeadMultiple { get; set; }
        /// <summary>
        /// The time interval (in milliseconds) between heartbeat packets for BFD when sending heartbeats.| For edge cluster type of
        /// bare metal, this value should be >= 300ms.| For edge cluster type of virtual machine or hybrid, this value should be >=
        /// 1000ms.
        /// </summary>
        [JsonProperty(PropertyName = "transmit_interval")]
        public long? TransmitInterval { get; set; }
    }
}
