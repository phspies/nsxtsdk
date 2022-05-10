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
    public class NSXTEthernetHeaderType 
    {
        /// <summary>
        /// The destination MAC address of form:
        /// "^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$". For example: 00:00:00:00:00:00.
        /// </summary>
        [JsonProperty(PropertyName = "dst_mac")]
        public string? DstMac { get; set; }
        /// <summary>
        /// This field defaults to IPv4.
        /// </summary>
        [JsonProperty(PropertyName = "eth_type")]
        public long? EthType { get; set; }
        /// <summary>
        /// The source MAC address of form:
        /// "^([0-9A-Fa-f]{2}[:-]){5}([0-9A-Fa-f]{2})$". For example: 00:00:00:00:00:00.
        /// </summary>
        [JsonProperty(PropertyName = "src_mac")]
        public string? SrcMac { get; set; }
    }
}
