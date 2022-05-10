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
    public class NSXTUdpHeaderType 
    {
        /// <summary>
        /// Source port of udp header
        /// </summary>
        [JsonProperty(PropertyName = "src_port")]
        public long? SrcPort { get; set; }
        /// <summary>
        /// Destination port of udp header
        /// </summary>
        [JsonProperty(PropertyName = "dst_port")]
        public long? DstPort { get; set; }
    }
}
