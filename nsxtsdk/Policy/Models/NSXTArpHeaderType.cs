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
    public class NSXTArpHeaderType 
    {
        /// <summary>
        /// This field specifies the nature of the Arp message being sent.
        /// </summary>
        [JsonProperty(PropertyName = "op_code", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"This field specifies the nature of the Arp message being sent.")]
        [System.ComponentModel.DataAnnotations.Required]
        [NSXTDefaultProperty(Default: "ARP_REQUEST")]
        public NSXTArpHeaderOpCodeEnumType OpCode { get; set; }
        /// <summary>
        /// This field specifies the IP address of the sender. If omitted, the src_ip is set to 0.0.0.0.
        /// </summary>
        [JsonProperty(PropertyName = "src_ip")]
        [NSXTProperty(IsRequired: false, Description: @"This field specifies the IP address of the sender. If omitted, the src_ip is set to 0.0.0.0.")]
        public string? SrcIp { get; set; }
        /// <summary>
        /// The destination IP address
        /// </summary>
        [JsonProperty(PropertyName = "dst_ip", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The destination IP address")]
        [System.ComponentModel.DataAnnotations.Required]
        public string DstIp { get; set; }
    }
}
