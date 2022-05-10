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
    public class NSXTSIPacketTypeAndCounterType 
    {
        /// <summary>
        /// The number of packets.
        /// </summary>
        [JsonProperty(PropertyName = "counter", Required = Required.AllowNull)]
        public long Counter { get; set; }
        /// <summary>
        /// The type of the packets
        /// </summary>
        [JsonProperty(PropertyName = "packet_type", Required = Required.AllowNull)]
        public string PacketType { get; set; }
    }
}
