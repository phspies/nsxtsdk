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
    /// PIM (Protocol Independent Multicast) RP (Randezvous Point) mapping details.
    /// </summary>
    [NSXTProperty(Description: @"PIM (Protocol Independent Multicast) RP (Randezvous Point) mapping details.")]
    public class NSXTPimRpMappingType 
    {
        /// <summary>
        /// Value of this field will be true if this edge transport node
        /// acts as rendezvous point, otherwise false.
        /// </summary>
        [JsonProperty(PropertyName = "is_rp")]
        public bool? IsRp { get; set; }
        /// <summary>
        /// Outgoing/Egress interface for multicast traffic.
        /// </summary>
        [JsonProperty(PropertyName = "outgoing_interface")]
        public string? OutgoingInterface { get; set; }
        /// <summary>
        /// Multicast group address.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string? Group { get; set; }
        /// <summary>
        /// RP (Randezvous Point) address.
        /// </summary>
        [JsonProperty(PropertyName = "rp_address")]
        public string? RpAddress { get; set; }
        /// <summary>
        /// Source of learning RP information. Either Static RP configured or
        /// RP learned via BSR (Bootstrap Router).
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string? Source { get; set; }
    }
}
