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
    public class NSXTIpv4HeaderType 
    {
        /// <summary>
        /// The source ip address.
        /// </summary>
        [JsonProperty(PropertyName = "src_ip")]
        public string? SrcIp { get; set; }
        /// <summary>
        /// IP flags
        /// </summary>
        [JsonProperty(PropertyName = "flags")]
        public long? Flags { get; set; }
        /// <summary>
        /// The destination ip address.
        /// </summary>
        [JsonProperty(PropertyName = "dst_ip")]
        public string? DstIp { get; set; }
        /// <summary>
        /// This is used together with src_ip to calculate dst_ip for broadcast when dst_ip is not given; not used in all other
        /// cases.
        /// </summary>
        [JsonProperty(PropertyName = "src_subnet_prefix_len")]
        public long? SrcSubnetPrefixLen { get; set; }
        /// <summary>
        /// Time to live (ttl)
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        public long? Ttl { get; set; }
        /// <summary>
        /// IP protocol - defaults to ICMP
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public long? Protocol { get; set; }
    }
}
