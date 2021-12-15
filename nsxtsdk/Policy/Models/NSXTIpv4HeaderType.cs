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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIpv4HeaderType 
    {
        /// <summary>
        /// The source ip address.
        /// </summary>
        [JsonProperty(PropertyName = "src_ip")]
        [NSXTProperty(IsRequired: false, Description: @"The source ip address.")]
        public string? SrcIp { get; set; }
        /// <summary>
        /// IP flags
        /// </summary>
        [JsonProperty(PropertyName = "flags")]
        [NSXTProperty(IsRequired: false, Description: @"IP flags")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(8)]
        [NSXTDefaultProperty(Default: "")]
        public long? Flags { get; set; }
        /// <summary>
        /// The destination ip address.
        /// </summary>
        [JsonProperty(PropertyName = "dst_ip")]
        [NSXTProperty(IsRequired: false, Description: @"The destination ip address.")]
        public string? DstIp { get; set; }
        /// <summary>
        /// This is used together with src_ip to calculate dst_ip for broadcast when dst_ip is not given; not used in all other
        /// cases.
        /// </summary>
        [JsonProperty(PropertyName = "src_subnet_prefix_len")]
        [NSXTProperty(IsRequired: false, Description: @"This is used together with src_ip to calculate dst_ip for broadcast when dst_ip is not given; not used in all other cases.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(32)]
        public long? SrcSubnetPrefixLen { get; set; }
        /// <summary>
        /// Time to live (ttl)
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        [NSXTProperty(IsRequired: false, Description: @"Time to live (ttl)")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(255)]
        [NSXTDefaultProperty(Default: "")]
        public long? Ttl { get; set; }
        /// <summary>
        /// IP protocol - defaults to ICMP
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [NSXTProperty(IsRequired: false, Description: @"IP protocol - defaults to ICMP")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(255)]
        [NSXTDefaultProperty(Default: "")]
        public long? Protocol { get; set; }
    }
}
