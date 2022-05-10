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
    /// Traffic statistics for a logical switch.
    /// </summary>
    [NSXTProperty(Description: @"Traffic statistics for a logical switch.")]
    public class NSXTL2VPNPerLSTrafficStatisticsType 
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
        /// Total number of outgoing Broadcast, Unknown unicast and Multicast (BUM) bytes.
        /// </summary>
        [JsonProperty(PropertyName = "bum_bytes_out")]
        public long? BumBytesOut { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "logical_switch")]
        public NSXTResourceReferenceType LogicalSwitch { get; set; }
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
