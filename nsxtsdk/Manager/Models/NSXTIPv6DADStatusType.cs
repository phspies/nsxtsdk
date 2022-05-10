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
    /// IPv6 DAD status
    /// </summary>
    [NSXTProperty(Description: @"IPv6 DAD status")]
    public class NSXTIPv6DADStatusType 
    {
        /// <summary>
        /// DAD status for IP address on the port.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpv6DadstatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Array of transport node id on which DAD status is reported for
        /// given IP address.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node")]
        public IList<NSXTResourceReferenceType> TransportNode { get; set; }
        /// <summary>
        /// IP address on the port for which DAD status is reported.
        /// </summary>
        [JsonProperty(PropertyName = "ip_address")]
        public string? IpAddress { get; set; }
    }
}
