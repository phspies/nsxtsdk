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
    /// OSPF router link state details.
    /// </summary>
    [NSXTProperty(Description: @"OSPF router link state details.")]
    public class NSXTMpOspfNetworkLinkStatesType 
    {
        /// <summary>
        /// Cost of the route
        /// </summary>
        [JsonProperty(PropertyName = "checksum")]
        [NSXTProperty(IsRequired: false, Description: @"Cost of the route")]
        public string? Checksum { get; set; }
        /// <summary>
        /// LSA age
        /// </summary>
        [JsonProperty(PropertyName = "up_time")]
        [NSXTProperty(IsRequired: false, Description: @"LSA age")]
        public long? UpTime { get; set; }
        /// <summary>
        /// Sequence number
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        [NSXTProperty(IsRequired: false, Description: @"Sequence number")]
        public string? SequenceNumber { get; set; }
        /// <summary>
        /// OSPF advertised router
        /// </summary>
        [JsonProperty(PropertyName = "advertised_router")]
        [NSXTProperty(IsRequired: false, Description: @"OSPF advertised router")]
        public string? AdvertisedRouter { get; set; }
        /// <summary>
        /// OSPF link id
        /// </summary>
        [JsonProperty(PropertyName = "link_state_id")]
        [NSXTProperty(IsRequired: false, Description: @"OSPF link id")]
        public string? LinkStateId { get; set; }
    }
}