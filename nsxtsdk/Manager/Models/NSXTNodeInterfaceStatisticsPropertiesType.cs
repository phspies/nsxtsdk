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
    public class NSXTNodeInterfaceStatisticsPropertiesType : NSXTResourceType
    {
        /// <summary>
        /// Number of packets dropped
        /// </summary>
        [JsonProperty(PropertyName = "tx_dropped")]
        public long? TxDropped { get; set; }
        /// <summary>
        /// Number of packets received
        /// </summary>
        [JsonProperty(PropertyName = "rx_packets")]
        public long? RxPackets { get; set; }
        /// <summary>
        /// Number of carrier losses detected
        /// </summary>
        [JsonProperty(PropertyName = "tx_carrier")]
        public long? TxCarrier { get; set; }
        /// <summary>
        /// Number of bytes received
        /// </summary>
        [JsonProperty(PropertyName = "rx_bytes")]
        public long? RxBytes { get; set; }
        /// <summary>
        /// Number of transmit errors
        /// </summary>
        [JsonProperty(PropertyName = "tx_errors")]
        public long? TxErrors { get; set; }
        /// <summary>
        /// Interface ID
        /// </summary>
        [JsonProperty(PropertyName = "interface_id")]
        public string? InterfaceId { get; set; }
        /// <summary>
        /// Number of collisions detected
        /// </summary>
        [JsonProperty(PropertyName = "tx_colls")]
        public long? TxColls { get; set; }
        /// <summary>
        /// Number of framing errors
        /// </summary>
        [JsonProperty(PropertyName = "rx_frame")]
        public long? RxFrame { get; set; }
        /// <summary>
        /// Number of receive errors
        /// </summary>
        [JsonProperty(PropertyName = "rx_errors")]
        public long? RxErrors { get; set; }
        /// <summary>
        /// Number of bytes transmitted
        /// </summary>
        [JsonProperty(PropertyName = "tx_bytes")]
        public long? TxBytes { get; set; }
        /// <summary>
        /// Number of packets dropped
        /// </summary>
        [JsonProperty(PropertyName = "rx_dropped")]
        public long? RxDropped { get; set; }
        /// <summary>
        /// Number of packets transmitted
        /// </summary>
        [JsonProperty(PropertyName = "tx_packets")]
        public long? TxPackets { get; set; }
        /// <summary>
        /// Source of status data.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeInterfaceStatisticsPropertiesSourceEnumType? Source { get; set; }
    }
}
