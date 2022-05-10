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
    public class NSXTTransportInfoType 
    {
        /// <summary>
        /// Source port
        /// </summary>
        [JsonProperty(PropertyName = "src_port")]
        public long? SrcPort { get; set; }
        /// <summary>
        /// Protocol type over IP layer
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTransportInfoProtocolEnumType? Protocol { get; set; }
        /// <summary>
        /// Destination port
        /// </summary>
        [JsonProperty(PropertyName = "dst_port")]
        public long? DstPort { get; set; }
    }
}
