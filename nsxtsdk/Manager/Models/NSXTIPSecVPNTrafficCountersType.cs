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
    /// Traffic counters for IPSec VPN session.
    /// </summary>
    [NSXTProperty(Description: @"Traffic counters for IPSec VPN session.")]
    public class NSXTIPSecVPNTrafficCountersType 
    {
        /// <summary>
        /// Total number of packets sent.
        /// </summary>
        [JsonProperty(PropertyName = "packets_out")]
        public long? PacketsOut { get; set; }
        /// <summary>
        /// Total number of outgoing packets dropped on outbound security association.
        /// </summary>
        [JsonProperty(PropertyName = "dropped_packets_out")]
        public long? DroppedPacketsOut { get; set; }
        /// <summary>
        /// Total number of bytes recevied.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_in")]
        public long? BytesIn { get; set; }
        /// <summary>
        /// Total number of bytes sent.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_out")]
        public long? BytesOut { get; set; }
        /// <summary>
        /// Total number of incoming packets dropped on inbound security association.
        /// </summary>
        [JsonProperty(PropertyName = "dropped_packets_in")]
        public long? DroppedPacketsIn { get; set; }
        /// <summary>
        /// Total number of packets received.
        /// </summary>
        [JsonProperty(PropertyName = "packets_in")]
        public long? PacketsIn { get; set; }
    }
}
