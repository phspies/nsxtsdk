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
    public class NSXTIpv6HeaderType 
    {
        /// <summary>
        /// The source ip address.
        /// </summary>
        [JsonProperty(PropertyName = "src_ip")]
        public string? SrcIp { get; set; }
        /// <summary>
        /// The destination ip address.
        /// </summary>
        [JsonProperty(PropertyName = "dst_ip")]
        public string? DstIp { get; set; }
        /// <summary>
        /// Identifies the type of header immediately following the IPv6 header.
        /// </summary>
        [JsonProperty(PropertyName = "next_header")]
        public long? NextHeader { get; set; }
        /// <summary>
        /// Decremented by 1 by each node that forwards the packets. The packet is discarded if Hop Limit is decremented to zero.
        /// </summary>
        [JsonProperty(PropertyName = "hop_limit")]
        public long? HopLimit { get; set; }
    }
}
