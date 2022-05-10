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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPortMirroringFilterType 
    {
        /// <summary>
        /// If set to MIRROR, packets will be mirrored. If set to DO_NOT_MIRROR, packets will not be mirrored.
        /// </summary>
        [JsonProperty(PropertyName = "filter_action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPortMirroringFilterFilterActionEnumType? FilterAction { get; set; }
        /// <summary>
        /// The transport protocols of TCP or UDP, used to match the transport protocol of a packet. If not provided, no filtering
        /// by IP protocols is performed.
        /// </summary>
        [JsonProperty(PropertyName = "ip_protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPortMirroringFilterIpProtocolEnumType? IpProtocol { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "src_ips")]
        public NSXTIPAddressesType SrcIps { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dst_ips")]
        public NSXTIPAddressesType DstIps { get; set; }
        /// <summary>
        /// Destination port in the form of a port or port range, used to match the destination port of a packet. If not provided,
        /// no filtering by destination port is performed.
        /// </summary>
        [JsonProperty(PropertyName = "dst_ports")]
        public string? DstPorts { get; set; }
        /// <summary>
        /// Source port in the form of a port or port range, used to match the source port of a packet. If not provided, no
        /// filtering by source port is performed.
        /// </summary>
        [JsonProperty(PropertyName = "src_ports")]
        public string? SrcPorts { get; set; }
    }
}
