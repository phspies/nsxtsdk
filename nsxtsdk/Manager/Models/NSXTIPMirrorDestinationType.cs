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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIPMirrorDestinationType : NSXTMirrorDestinationType
    {
        /// <summary>
        /// The destination IPs of the mirror packet will be sent to.
        /// </summary>
        [JsonProperty(PropertyName = "destination_ips", Required = Required.AllowNull)]
        public IList<string> DestinationIps { get; set; }
        /// <summary>
        /// You can choose GRE, ERSPAN II or ERSPAN III.
        /// </summary>
        [JsonProperty(PropertyName = "encapsulation_type", Required = Required.AllowNull)]
        public NSXTIpmirrorDestinationEncapsulationTypeEnumType EncapsulationType { get; set; }
        /// <summary>
        /// Used by physical switch for the mirror traffic forwarding.
        /// Must be provided and only effective when encapsulation type is
        /// ERSPAN type II or type III.
        /// </summary>
        public int? ErspanId { get; set; }
        /// <summary>
        /// User-configurable 32-bit key only for GRE
        /// </summary>
        public int? GreKey { get; set; }
    }
}
