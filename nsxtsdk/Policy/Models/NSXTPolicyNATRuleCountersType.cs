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
    /// Gives the statistics count of a NAT rule.
    /// </summary>
    [NSXTProperty(Description: @"Gives the statistics count of a NAT rule.")]
    public class NSXTPolicyNATRuleCountersType 
    {
        /// <summary>
        /// Gives the total number of packets.
        /// </summary>
        [JsonProperty(PropertyName = "total_packets")]
        public long? TotalPackets { get; set; }
        /// <summary>
        /// Gives the total number of active sessions.
        /// </summary>
        [JsonProperty(PropertyName = "active_sessions")]
        public long? ActiveSessions { get; set; }
        /// <summary>
        /// Gives the total number of bytes.
        /// </summary>
        [JsonProperty(PropertyName = "total_bytes")]
        public long? TotalBytes { get; set; }
    }
}
