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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTBfdConfigType : NSXTManagedResourceType
    {
        /// <summary>
        /// the time interval (in milliseconds) between heartbeat packets for BFD when receiving heartbeats.
        /// </summary>
        [JsonProperty(PropertyName = "receive_interval")]
        [NSXTProperty(IsRequired: false, Description: @"the time interval (in milliseconds) between heartbeat packets for BFD when receiving heartbeats.")]
        //[System.ComponentModel.DataAnnotations.MinLength(50)]
        //[System.ComponentModel.DataAnnotations.MaxLength(60000)]
        [NSXTDefaultProperty(Default: "")]
        public long? ReceiveInterval { get; set; }
        /// <summary>
        /// Number of times a packet is missed before BFD declares the neighbor down.
        /// </summary>
        [JsonProperty(PropertyName = "declare_dead_multiple")]
        [NSXTProperty(IsRequired: false, Description: @"Number of times a packet is missed before BFD declares the neighbor down.")]
        //[System.ComponentModel.DataAnnotations.MinLength(2)]
        //[System.ComponentModel.DataAnnotations.MaxLength(16)]
        [NSXTDefaultProperty(Default: "")]
        public long? DeclareDeadMultiple { get; set; }
        /// <summary>
        /// Flag to enable BFD for this LogicalRouter
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to enable BFD for this LogicalRouter")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Logical router id
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        [NSXTProperty(IsRequired: false, Description: @"Logical router id")]
        public string? LogicalRouterId { get; set; }
        /// <summary>
        /// the time interval (in milliseconds) between heartbeat packets for BFD when sending heartbeats.
        /// </summary>
        [JsonProperty(PropertyName = "transmit_interval")]
        [NSXTProperty(IsRequired: false, Description: @"the time interval (in milliseconds) between heartbeat packets for BFD when sending heartbeats.")]
        //[System.ComponentModel.DataAnnotations.MinLength(50)]
        //[System.ComponentModel.DataAnnotations.MaxLength(60000)]
        [NSXTDefaultProperty(Default: "")]
        public long? TransmitInterval { get; set; }
    }
}
