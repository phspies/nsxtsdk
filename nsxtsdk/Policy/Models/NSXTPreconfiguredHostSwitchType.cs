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
    /// Preconfigured host switch is used for manually configured transport node.
    /// </summary>
    [NSXTProperty(Description: @"Preconfigured host switch is used for manually configured transport node.")]
    public class NSXTPreconfiguredHostSwitchType 
    {
        /// <summary>
        /// External Id of the preconfigured host switch.
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_id", Required = Required.AllowNull)]
        public string HostSwitchId { get; set; }
        /// <summary>
        /// List of virtual tunnel endpoints which are preconfigured on this host switch
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public IList<NSXTPreconfiguredEndpointType> Endpoints { get; set; }
        /// <summary>
        /// List of TransportZones that are to be associated with specified host switch.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_endpoints")]
        public IList<NSXTTransportZoneEndPointType> TransportZoneEndpoints { get; set; }
    }
}
