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
    /// TAP (Terminal access point) traffic statistics for L2VPN.
    /// </summary>
    [NSXTProperty(Description: @"TAP (Terminal access point) traffic statistics for L2VPN.")]
    public class NSXTL2VPNTapStatisticsType 
    {
        /// <summary>
        /// Total number of outgoing packets.
        /// </summary>
        [JsonProperty(PropertyName = "packets_out")]
        public long? PacketsOut { get; set; }
        /// <summary>
        /// Total number of incoming bytes.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_in")]
        public long? BytesIn { get; set; }
        /// <summary>
        /// Total number of packets dropped while sending for any reason.
        /// </summary>
        [JsonProperty(PropertyName = "packets_sent_error")]
        public long? PacketsSentError { get; set; }
        /// <summary>
        /// Total number of incoming packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "packets_receive_error")]
        public long? PacketsReceiveError { get; set; }
        /// <summary>
        /// Total number of incoming packets.
        /// </summary>
        [JsonProperty(PropertyName = "packets_in")]
        public long? PacketsIn { get; set; }
        /// <summary>
        /// Total number of outgoing bytes.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_out")]
        public long? BytesOut { get; set; }
    }
}
