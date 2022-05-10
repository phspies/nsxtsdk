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
    /// Specify which HostSwitch from this TransportNode is used handle traffic for given TransportZone
    /// </summary>
    [NSXTProperty(Description: @"Specify which HostSwitch from this TransportNode is used handle traffic for given TransportZone")]
    public class NSXTTransportZoneEndPointType 
    {
        /// <summary>
        /// For MP APIs provide UUID of transport zone. For Policy APIs provide policyPath of transport zone.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_id", Required = Required.AllowNull)]
        public string TransportZoneId { get; set; }
        /// <summary>
        /// For MP APIs provide UUID of transport zone profiles. For Policy APIs provide policyPath of transport zone profiles.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_profile_ids")]
        public IList<NSXTTransportZoneProfileTypeIdEntryType> TransportZoneProfileIds { get; set; }
    }
}
