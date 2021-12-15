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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPimRpMappingCsvRecordType : NSXTCsvRecordType
    {
        /// <summary>
        /// Value of this field will be true if this edge transport node
        /// acts as rendezvous point, otherwise false.
        /// </summary>
        [JsonProperty(PropertyName = "is_rp")]
        [NSXTProperty(IsRequired: false, Description: @"Value of this field will be true if this edge transport nodeacts as rendezvous point, otherwise false.")]
        public bool? IsRp { get; set; }
        /// <summary>
        /// Transport node uuid or policy path.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node")]
        [NSXTProperty(IsRequired: false, Description: @"Transport node uuid or policy path.")]
        public string? TransportNode { get; set; }
        /// <summary>
        /// Multicast group address.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        [NSXTProperty(IsRequired: false, Description: @"Multicast group address.")]
        public string? Group { get; set; }
        /// <summary>
        /// Source of learning RP information. Either Static RP configured or
        /// RP learned via BSR (Bootstrap Router).
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        [NSXTProperty(IsRequired: false, Description: @"Source of learning RP information. Either Static RP configured orRP learned via BSR (Bootstrap Router).")]
        public string? Source { get; set; }
        /// <summary>
        /// Outgoing/Egress interface for multicast traffic.
        /// </summary>
        [JsonProperty(PropertyName = "outgoing_interface")]
        [NSXTProperty(IsRequired: false, Description: @"Outgoing/Egress interface for multicast traffic.")]
        public string? OutgoingInterface { get; set; }
        /// <summary>
        /// RP (Randezvous Point) address.
        /// </summary>
        [JsonProperty(PropertyName = "rp_address")]
        [NSXTProperty(IsRequired: false, Description: @"RP (Randezvous Point) address.")]
        public string? RpAddress { get; set; }
    }
}
