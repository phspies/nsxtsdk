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
    public class NSXTSIPacketTypeAndCounterType 
    {
        /// <summary>
        /// The number of packets.
        /// </summary>
        [JsonProperty(PropertyName = "counter", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The number of packets.")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Counter { get; set; }
        /// <summary>
        /// The type of the packets
        /// </summary>
        [JsonProperty(PropertyName = "packet_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The type of the packets")]
        [System.ComponentModel.DataAnnotations.Required]
        public string PacketType { get; set; }
    }
}
