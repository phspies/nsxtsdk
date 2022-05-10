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
    public class NSXTPktcapActionArgumentType 
    {
        /// <summary>
        /// Type of packet capture
        /// </summary>
        [JsonProperty(PropertyName = "pktcap_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPktcapActionArgumentPktcapTypeEnumType? PktcapType { get; set; }
        /// <summary>
        /// It is required only when the type of packet capture is bidirectional. Please keep this aligned with the
        /// destination logical port of trace action config when the type of trace action is bidirectional.
        /// </summary>
        [JsonProperty(PropertyName = "dest_lport")]
        public string? DestLport { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "reverse_filter")]
        public NSXTLiveTraceFilterDataType ReverseFilter { get; set; }
    }
}
