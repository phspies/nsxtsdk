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
    /// IGMP (Internet Group Management Protocol) membership details.
    /// </summary>
    [NSXTProperty(Description: @"IGMP (Internet Group Management Protocol) membership details.")]
    public class NSXTIgmpMembershipType 
    {
        /// <summary>
        /// Multicast group membership active time.
        /// </summary>
        [JsonProperty(PropertyName = "uptime")]
        [NSXTProperty(IsRequired: false, Description: @"Multicast group membership active time.")]
        public string? Uptime { get; set; }
        /// <summary>
        /// Multicast group address.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        [NSXTProperty(IsRequired: false, Description: @"Multicast group address.")]
        public string? Group { get; set; }
        /// <summary>
        /// Interface on which multicast group membership is learned.
        /// </summary>
        [JsonProperty(PropertyName = "interface")]
        [NSXTProperty(IsRequired: false, Description: @"Interface on which multicast group membership is learned.")]
        public string? Interface { get; set; }
        /// <summary>
        /// Number of multicast sources.
        /// </summary>
        [JsonProperty(PropertyName = "no_of_sources")]
        [NSXTProperty(IsRequired: false, Description: @"Number of multicast sources.")]
        public string? NoOfSources { get; set; }
        /// <summary>
        /// IP address of multicast source.
        /// </summary>
        [JsonProperty(PropertyName = "source_address")]
        [NSXTProperty(IsRequired: false, Description: @"IP address of multicast source.")]
        public string? SourceAddress { get; set; }
        /// <summary>
        /// IGMP version.
        /// </summary>
        [JsonProperty(PropertyName = "igmp_version")]
        [NSXTProperty(IsRequired: false, Description: @"IGMP version.")]
        public long? IgmpVersion { get; set; }
    }
}