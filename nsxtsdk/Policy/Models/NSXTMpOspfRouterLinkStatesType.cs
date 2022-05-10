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
    /// OSPF router link state details.
    /// </summary>
    [NSXTProperty(Description: @"OSPF router link state details.")]
    public class NSXTMpOspfRouterLinkStatesType 
    {
        /// <summary>
        /// Number of router links
        /// </summary>
        [JsonProperty(PropertyName = "router_links")]
        public long? RouterLinks { get; set; }
        /// <summary>
        /// LSA age
        /// </summary>
        [JsonProperty(PropertyName = "up_time")]
        public long? UpTime { get; set; }
        /// <summary>
        /// OSPF advertised router
        /// </summary>
        [JsonProperty(PropertyName = "advertised_router")]
        public string? AdvertisedRouter { get; set; }
        /// <summary>
        /// OSPF link id
        /// </summary>
        [JsonProperty(PropertyName = "link_state_id")]
        public string? LinkStateId { get; set; }
        /// <summary>
        /// Cost of the route
        /// </summary>
        [JsonProperty(PropertyName = "checksum")]
        public string? Checksum { get; set; }
        /// <summary>
        /// Sequence number
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        public string? SequenceNumber { get; set; }
    }
}
