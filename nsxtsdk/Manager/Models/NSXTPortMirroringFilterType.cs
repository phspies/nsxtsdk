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
        [NSXTProperty(IsRequired: false, Description: @"If set to MIRROR, packets will be mirrored. If set to DO_NOT_MIRROR, packets will not be mirrored.")]
        [NSXTDefaultProperty(Default: "MIRROR")]
        public NSXTPortMirroringFilterFilterActionEnumType? FilterAction { get; set; }
        /// <summary>
        /// The transport protocols of TCP or UDP, used to match the transport protocol of a packet. If not provided, no filtering
        /// by IP protocols is performed.
        /// </summary>
        [JsonProperty(PropertyName = "ip_protocol")]
        [NSXTProperty(IsRequired: false, Description: @"The transport protocols of TCP or UDP, used to match the transport protocol of a packet. If not provided, no filtering by IP protocols is performed.")]
        public NSXTPortMirroringFilterIpProtocolEnumType? IpProtocol { get; set; }
        /// <summary>
        /// Source IP in the form of IPAddresses, used to match the source IP of a packet. If not provided, no filtering by source
        /// IPs is performed.
        /// </summary>
        [JsonProperty(PropertyName = "src_ips")]
        [NSXTProperty(IsRequired: false, Description: @"Source IP in the form of IPAddresses, used to match the source IP of a packet. If not provided, no filtering by source IPs is performed.")]
        public NSXTIPAddressesType SrcIps { get; set; }
        /// <summary>
        /// Destination IP in the form of IPAddresses, used to match the destination IP of a packet. If not provided, no filtering
        /// by destination IPs is performed.
        /// </summary>
        [JsonProperty(PropertyName = "dst_ips")]
        [NSXTProperty(IsRequired: false, Description: @"Destination IP in the form of IPAddresses, used to match the destination IP of a packet. If not provided, no filtering by destination IPs is performed.")]
        public NSXTIPAddressesType DstIps { get; set; }
        /// <summary>
        /// Destination port in the form of a port or port range, used to match the destination port of a packet. If not provided,
        /// no filtering by destination port is performed.
        /// </summary>
        [JsonProperty(PropertyName = "dst_ports")]
        [NSXTProperty(IsRequired: false, Description: @"Destination port in the form of a port or port range, used to match the destination port of a packet. If not provided, no filtering by destination port is performed.")]
        public string? DstPorts { get; set; }
        /// <summary>
        /// Source port in the form of a port or port range, used to match the source port of a packet. If not provided, no
        /// filtering by source port is performed.
        /// </summary>
        [JsonProperty(PropertyName = "src_ports")]
        [NSXTProperty(IsRequired: false, Description: @"Source port in the form of a port or port range, used to match the source port of a packet. If not provided, no filtering by source port is performed.")]
        public string? SrcPorts { get; set; }
    }
}
