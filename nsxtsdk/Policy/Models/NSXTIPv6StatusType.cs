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
    /// IPv6 status
    /// </summary>
    [NSXTProperty(Description: @"IPv6 status")]
    public class NSXTIPv6StatusType 
    {
        /// <summary>
        /// Tier-0 Gateway this router Link belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "tier0_gateway")]
        public string? Tier0Gateway { get; set; }
        /// <summary>
        /// Tier-1 Gateway this router Link belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "tier1_gateway")]
        public string? Tier1Gateway { get; set; }
        /// <summary>
        /// Array of DAD status which contains DAD information for IP addresses
        /// on the interface.
        /// </summary>
        [JsonProperty(PropertyName = "dad_statuses")]
        public IList<NSXTIPv6DADStatusType> DadStatuses { get; set; }
        /// <summary>
        /// Path of the segment attached to the interface.
        /// </summary>
        [JsonProperty(PropertyName = "connected_segment_path")]
        public string? ConnectedSegmentPath { get; set; }
        /// <summary>
        /// Policy path or realization ID of interface for which IPv6 DAD
        /// status is returned.
        /// </summary>
        [JsonProperty(PropertyName = "interface_id")]
        public string? InterfaceId { get; set; }
    }
}
