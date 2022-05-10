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
    public class NSXTArpHeaderType 
    {
        /// <summary>
        /// This field specifies the nature of the Arp message being sent.
        /// </summary>
        [JsonProperty(PropertyName = "op_code", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTArpHeaderOpCodeEnumType OpCode { get; set; }
        /// <summary>
        /// This field specifies the IP address of the sender. If omitted, the src_ip is set to 0.0.0.0.
        /// </summary>
        [JsonProperty(PropertyName = "src_ip")]
        public string? SrcIp { get; set; }
        /// <summary>
        /// The destination IP address
        /// </summary>
        [JsonProperty(PropertyName = "dst_ip", Required = Required.AllowNull)]
        public string DstIp { get; set; }
    }
}
