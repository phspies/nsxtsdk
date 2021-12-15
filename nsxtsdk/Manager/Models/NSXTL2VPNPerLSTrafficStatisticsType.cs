// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: false, Description: @"Total number of outgoing packets.")]
        public long? PacketsOut { get; set; }
        /// <summary>
        /// Total number of incoming packets dropped.
        /// </summary>
        [JsonProperty(PropertyName = "packets_receive_error")]
        [NSXTProperty(IsRequired: false, Description: @"Total number of incoming packets dropped.")]
        public long? PacketsReceiveError { get; set; }
        /// <summary>
        /// Total number of incoming bytes.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_in")]
        [NSXTProperty(IsRequired: false, Description: @"Total number of incoming bytes.")]
        public long? BytesIn { get; set; }
        /// <summary>
        /// Total number of incoming Broadcast, Unknown unicast and Multicast (BUM) packets.
        /// </summary>
        [JsonProperty(PropertyName = "bum_packets_in")]
        [NSXTProperty(IsRequired: false, Description: @"Total number of incoming Broadcast, Unknown unicast and Multicast (BUM) packets.")]
        public long? BumPacketsIn { get; set; }
        /// <summary>
        /// Total number of outgoing Broadcast, Unknown unicast and Multicast (BUM) bytes.
        /// </summary>
        [JsonProperty(PropertyName = "bum_bytes_out")]
        [NSXTProperty(IsRequired: false, Description: @"Total number of outgoing Broadcast, Unknown unicast and Multicast (BUM) bytes.")]
        public long? BumBytesOut { get; set; }
        /// <summary>
        /// Logical switch
        /// </summary>
        [JsonProperty(PropertyName = "logical_switch")]
        [NSXTProperty(IsRequired: false, Description: @"Logical switch")]
        public NSXTResourceReferenceType LogicalSwitch { get; set; }
        /// <summary>
        /// Total number of outgoing bytes.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_out")]
        [NSXTProperty(IsRequired: false, Description: @"Total number of outgoing bytes.")]
        public long? BytesOut { get; set; }
        /// <summary>
        /// Total number of packets dropped while sending for any reason.
        /// </summary>
        [JsonProperty(PropertyName = "packets_sent_error")]
        [NSXTProperty(IsRequired: false, Description: @"Total number of packets dropped while sending for any reason.")]
        public long? PacketsSentError { get; set; }
        /// <summary>
        /// Total number of outgoing Broadcast, Unknown unicast and Multicast (BUM) packets.
        /// </summary>
        [JsonProperty(PropertyName = "bum_packets_out")]
        [NSXTProperty(IsRequired: false, Description: @"Total number of outgoing Broadcast, Unknown unicast and Multicast (BUM) packets.")]
        public long? BumPacketsOut { get; set; }
        /// <summary>
        /// Total number of incoming packets.
        /// </summary>
        [JsonProperty(PropertyName = "packets_in")]
        [NSXTProperty(IsRequired: false, Description: @"Total number of incoming packets.")]
        public long? PacketsIn { get; set; }
        /// <summary>
        /// Total number of incoming Broadcast, Unknown unicast and Multicast (BUM) bytes.
        /// </summary>
        [JsonProperty(PropertyName = "bum_bytes_in")]
        [NSXTProperty(IsRequired: false, Description: @"Total number of incoming Broadcast, Unknown unicast and Multicast (BUM) bytes.")]
        public long? BumBytesIn { get; set; }
    }
}
