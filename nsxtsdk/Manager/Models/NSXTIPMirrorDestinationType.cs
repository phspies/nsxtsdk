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
    public class NSXTIPMirrorDestinationType : NSXTMirrorDestinationType
    {
        public NSXTIPMirrorDestinationType()
        {
            EncapsulationType = test
        }
        /// <summary>
        /// The destination IPs of the mirror packet will be sent to.
        /// </summary>
        [JsonProperty(PropertyName = "destination_ips", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The destination IPs of the mirror packet will be sent to.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> DestinationIps { get; set; }
        /// <summary>
        /// You can choose GRE, ERSPAN II or ERSPAN III.
        /// </summary>
        [JsonProperty(PropertyName = "encapsulation_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"You can choose GRE, ERSPAN II or ERSPAN III.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTIpmirrorDestinationEncapsulationTypeEnumType EncapsulationType { get; set; }
        /// <summary>
        /// Used by physical switch for the mirror traffic forwarding.
        /// Must be provided and only effective when encapsulation type is
        /// ERSPAN type II or type III.
        /// </summary>
        [JsonProperty(PropertyName = "erspan_id")]
        [NSXTProperty(IsRequired: false, Description: @"Used by physical switch for the mirror traffic forwarding.Must be provided and only effective when encapsulation type isERSPAN type II or type III.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(1023)]
        public int? ErspanId { get; set; }
        /// <summary>
        /// User-configurable 32-bit key only for GRE
        /// </summary>
        [JsonProperty(PropertyName = "gre_key")]
        [NSXTProperty(IsRequired: false, Description: @"User-configurable 32-bit key only for GRE")]
        public int? GreKey { get; set; }
    }
}
