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
    /// Specify which HostSwitch from this TransportNode is used handle traffic for given TransportZone
    /// </summary>
    [NSXTProperty(Description: @"Specify which HostSwitch from this TransportNode is used handle traffic for given TransportZone")]
    public class NSXTTransportZoneEndPointType 
    {
        /// <summary>
        /// Unique ID identifying the transport zone for this endpoint
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Unique ID identifying the transport zone for this endpoint")]
        [System.ComponentModel.DataAnnotations.Required]
        public string TransportZoneId { get; set; }
        /// <summary>
        /// Identifiers of the transport zone profiles associated with this transport zone endpoint on this transport node.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_profile_ids")]
        [NSXTProperty(IsRequired: false, Description: @"Identifiers of the transport zone profiles associated with this transport zone endpoint on this transport node.")]
        public IList<NSXTTransportZoneProfileTypeIdEntryType> TransportZoneProfileIds { get; set; }
    }
}