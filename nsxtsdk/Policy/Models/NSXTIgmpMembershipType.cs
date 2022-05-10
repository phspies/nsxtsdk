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
    /// IGMP (Internet Group Management Protocol) membership details.
    /// </summary>
    [NSXTProperty(Description: @"IGMP (Internet Group Management Protocol) membership details.")]
    public class NSXTIgmpMembershipType 
    {
        /// <summary>
        /// Multicast group membership active time.
        /// </summary>
        [JsonProperty(PropertyName = "uptime")]
        public string? Uptime { get; set; }
        /// <summary>
        /// Multicast group address.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string? Group { get; set; }
        /// <summary>
        /// Interface on which multicast group membership is learned.
        /// </summary>
        [JsonProperty(PropertyName = "interface")]
        public string? Interface { get; set; }
        /// <summary>
        /// Number of multicast sources.
        /// </summary>
        [JsonProperty(PropertyName = "no_of_sources")]
        public string? NoOfSources { get; set; }
        /// <summary>
        /// IP address of multicast source.
        /// </summary>
        [JsonProperty(PropertyName = "source_address")]
        public string? SourceAddress { get; set; }
        /// <summary>
        /// IGMP version.
        /// </summary>
        [JsonProperty(PropertyName = "igmp_version")]
        public long? IgmpVersion { get; set; }
    }
}
