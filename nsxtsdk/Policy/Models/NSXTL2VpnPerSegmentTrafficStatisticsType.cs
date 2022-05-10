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
    /// Traffic statistics for a segment.
    /// </summary>
    [NSXTProperty(Description: @"Traffic statistics for a segment.")]
    public class NSXTL2VpnPerSegmentTrafficStatisticsType 
    {
        /// <summary>
        /// Total number of outgoing packets.
        /// </summary>
        [JsonProperty(PropertyName = "packets_out")]
        public long? PacketsOut { get; set; }
        /// <summary>
        /// Total number of incoming packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "packets_receive_error")]
        public long? PacketsReceiveError { get; set; }
        /// <summary>
        /// Total number of incoming bytes.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_in")]
        public long? BytesIn { get; set; }
        /// <summary>
        /// Total number of incoming Broadcast, Unknown unicast and Multicast (BUM) packets.
        /// </summary>
        [JsonProperty(PropertyName = "bum_packets_in")]
        public long? BumPacketsIn { get; set; }
        /// <summary>
        /// Policy path referencing the segment on which stats are gathered.
        /// </summary>
        [JsonProperty(PropertyName = "segment_path")]
        public string? SegmentPath { get; set; }
        /// <summary>
        /// Total number of outgoing Broadcast, Unknown unicast and Multicast (BUM) bytes.
        /// </summary>
        [JsonProperty(PropertyName = "bum_bytes_out")]
        public long? BumBytesOut { get; set; }
        /// <summary>
        /// Total number of outgoing bytes.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_out")]
        public long? BytesOut { get; set; }
        /// <summary>
        /// Total number of packets dropped while sending for any reason.
        /// </summary>
        [JsonProperty(PropertyName = "packets_sent_error")]
        public long? PacketsSentError { get; set; }
        /// <summary>
        /// Total number of outgoing Broadcast, Unknown unicast and Multicast (BUM) packets.
        /// </summary>
        [JsonProperty(PropertyName = "bum_packets_out")]
        public long? BumPacketsOut { get; set; }
        /// <summary>
        /// Total number of incoming packets.
        /// </summary>
        [JsonProperty(PropertyName = "packets_in")]
        public long? PacketsIn { get; set; }
        /// <summary>
        /// Total number of incoming Broadcast, Unknown unicast and Multicast (BUM) bytes.
        /// </summary>
        [JsonProperty(PropertyName = "bum_bytes_in")]
        public long? BumBytesIn { get; set; }
    }
}
