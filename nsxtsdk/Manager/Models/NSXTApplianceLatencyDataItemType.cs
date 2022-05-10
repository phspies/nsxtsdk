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
    /// Describes appliance latency data in detail.
    /// </summary>
    [NSXTProperty(Description: @"Describes appliance latency data in detail.")]
    public class NSXTApplianceLatencyDataItemType 
    {
        /// <summary>
        /// Display the connection status between source node and destination node.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTApplianceLatencyDataItemStatusEnumType? Status { get; set; }
        /// <summary>
        /// Display the transmitted packets in Ping
        /// </summary>
        [JsonProperty(PropertyName = "packet_transmitted")]
        public long? PacketTransmitted { get; set; }
        /// <summary>
        /// Display the appliance node id.
        /// </summary>
        [JsonProperty(PropertyName = "destination_node_id")]
        public string? DestinationNodeId { get; set; }
        /// <summary>
        /// Display the appliance node ip.
        /// </summary>
        [JsonProperty(PropertyName = "destination_node_ip")]
        public string? DestinationNodeIp { get; set; }
        /// <summary>
        /// Display the average Round Trip Time in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "rtt_avg")]
        public double? RttAvg { get; set; }
        /// <summary>
        /// Display the appliance node ip.
        /// </summary>
        [JsonProperty(PropertyName = "source_node_ip")]
        public string? SourceNodeIp { get; set; }
        /// <summary>
        /// Display the percentage of lost packet.
        /// </summary>
        [JsonProperty(PropertyName = "packet_loss_percent")]
        public string? PacketLossPercent { get; set; }
        /// <summary>
        /// Display the min Round Trip Time in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "rtt_min")]
        public double? RttMin { get; set; }
        /// <summary>
        /// Display the max Round Trip Time in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "rtt_max")]
        public double? RttMax { get; set; }
        /// <summary>
        /// Display the total time of sending and receiving packets in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "total_time")]
        public long? TotalTime { get; set; }
        /// <summary>
        /// Display the received packets.
        /// </summary>
        [JsonProperty(PropertyName = "packet_received")]
        public long? PacketReceived { get; set; }
        /// <summary>
        /// Display the appliance node name.
        /// </summary>
        [JsonProperty(PropertyName = "destination_node_name")]
        public string? DestinationNodeName { get; set; }
        /// <summary>
        /// Display the mean Round Trip Time in milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "rtt_mdev")]
        public double? RttMdev { get; set; }
    }
}
