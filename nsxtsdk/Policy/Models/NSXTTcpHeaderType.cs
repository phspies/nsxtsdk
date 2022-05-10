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
    public class NSXTTcpHeaderType 
    {
        /// <summary>
        /// TCP flags (9bits)
        /// </summary>
        [JsonProperty(PropertyName = "tcp_flags")]
        public long? TcpFlags { get; set; }
        /// <summary>
        /// Source port of tcp header
        /// </summary>
        [JsonProperty(PropertyName = "src_port")]
        public long? SrcPort { get; set; }
        /// <summary>
        /// Destination port of tcp header
        /// </summary>
        [JsonProperty(PropertyName = "dst_port")]
        public long? DstPort { get; set; }
    }
}
