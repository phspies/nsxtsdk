// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public bool? IsRp { get; set; }
        /// <summary>
        /// Transport node uuid or policy path.
        /// </summary>
        public string? TransportNode { get; set; }
        /// <summary>
        /// Multicast group address.
        /// </summary>
        public string? Group { get; set; }
        /// <summary>
        /// Source of learning RP information. Either Static RP configured or
        /// RP learned via BSR (Bootstrap Router).
        /// </summary>
        public string? Source { get; set; }
        /// <summary>
        /// Outgoing/Egress interface for multicast traffic.
        /// </summary>
        public string? OutgoingInterface { get; set; }
        /// <summary>
        /// RP (Randezvous Point) address.
        /// </summary>
        public string? RpAddress { get; set; }
    }
}
