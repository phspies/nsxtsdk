// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public long? PacketsOut { get; set; }
        /// <summary>
        /// Total number of incoming packets dropped.
        /// </summary>
        public long? PacketsReceiveError { get; set; }
        /// <summary>
        /// Total number of incoming bytes.
        /// </summary>
        public long? BytesIn { get; set; }
        /// <summary>
        /// Total number of incoming Broadcast, Unknown unicast and Multicast (BUM) packets.
        /// </summary>
        public long? BumPacketsIn { get; set; }
        /// <summary>
        /// Policy path referencing the segment on which stats are gathered.
        /// </summary>
        public string? SegmentPath { get; set; }
        /// <summary>
        /// Total number of outgoing Broadcast, Unknown unicast and Multicast (BUM) bytes.
        /// </summary>
        public long? BumBytesOut { get; set; }
        /// <summary>
        /// Total number of outgoing bytes.
        /// </summary>
        public long? BytesOut { get; set; }
        /// <summary>
        /// Total number of packets dropped while sending for any reason.
        /// </summary>
        public long? PacketsSentError { get; set; }
        /// <summary>
        /// Total number of outgoing Broadcast, Unknown unicast and Multicast (BUM) packets.
        /// </summary>
        public long? BumPacketsOut { get; set; }
        /// <summary>
        /// Total number of incoming packets.
        /// </summary>
        public long? PacketsIn { get; set; }
        /// <summary>
        /// Total number of incoming Broadcast, Unknown unicast and Multicast (BUM) bytes.
        /// </summary>
        public long? BumBytesIn { get; set; }
    }
}
