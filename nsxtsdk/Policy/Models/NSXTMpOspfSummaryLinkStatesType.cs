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
    /// OSPF summary link state details.
    /// </summary>
    [NSXTProperty(Description: @"OSPF summary link state details.")]
    public class NSXTMpOspfSummaryLinkStatesType 
    {
        /// <summary>
        /// LSA age
        /// </summary>
        [JsonProperty(PropertyName = "up_time")]
        public long? UpTime { get; set; }
        /// <summary>
        /// Sequence number
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        public string? SequenceNumber { get; set; }
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
        /// OSPF summary address
        /// </summary>
        [JsonProperty(PropertyName = "summary_address")]
        public string? SummaryAddress { get; set; }
    }
}
