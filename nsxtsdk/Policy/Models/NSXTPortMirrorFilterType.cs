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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPortMirrorFilterType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "destination_ips")]
        public NSXTIPAddressesType DestinationIps { get; set; }
        /// <summary>
        /// Destination port in the form of a port or port range, used to match the destination port of a packet. If not provided,
        /// no filtering by destination port is performed.
        /// </summary>
        [JsonProperty(PropertyName = "destination_ports")]
        public string? DestinationPorts { get; set; }
        /// <summary>
        /// The transport protocols of TCP or UDP, used to match the transport protocol of a packet. If not provided, no filtering
        /// by IP protocols is performed.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPortMirrorFilterProtocolEnumType? Protocol { get; set; }
        /// <summary>
        /// Source port in the form of a port or port range, used to match the source port of a packet. If not provided, no
        /// filtering by source port is performed.
        /// </summary>
        [JsonProperty(PropertyName = "source_ports")]
        public string? SourcePorts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "source_ips")]
        public NSXTIPAddressesType SourceIps { get; set; }
    }
}
