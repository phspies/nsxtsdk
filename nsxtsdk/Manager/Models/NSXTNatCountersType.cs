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
    public class NSXTNatCountersType 
    {
        /// <summary>
        /// The number of packets
        /// </summary>
        [JsonProperty(PropertyName = "total_packets")]
        public long? TotalPackets { get; set; }
        /// <summary>
        /// The number of bytes
        /// </summary>
        [JsonProperty(PropertyName = "total_bytes")]
        public long? TotalBytes { get; set; }
        /// <summary>
        /// The number of active sessions
        /// </summary>
        [JsonProperty(PropertyName = "active_sessions")]
        public long? ActiveSessions { get; set; }
    }
}
