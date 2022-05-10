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
    public class NSXTLbStatisticsCounterType 
    {
        /// <summary>
        /// Number of source IP persistence entries
        /// </summary>
        [JsonProperty(PropertyName = "source_ip_persistence_entry_size")]
        public long? SourceIpPersistenceEntrySize { get; set; }
        /// <summary>
        /// Number of packets out
        /// </summary>
        [JsonProperty(PropertyName = "packets_out")]
        public long? PacketsOut { get; set; }
        /// <summary>
        /// The total number of dropped TCP SYN or UDP packets by access list
        /// control.
        /// </summary>
        [JsonProperty(PropertyName = "dropped_packets_by_access_list")]
        public long? DroppedPacketsByAccessList { get; set; }
        /// <summary>
        /// The average number of outbound bytes per second, the number is
        /// averaged over the last 5 one-second intervals.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_out_rate")]
        public double? BytesOutRate { get; set; }
        /// <summary>
        /// Number of total sessions
        /// </summary>
        [JsonProperty(PropertyName = "total_sessions", Required = Required.AllowNull)]
        public long TotalSessions { get; set; }
        /// <summary>
        /// The average number of http requests per second, the number is
        /// averaged over the last 5 one-second intervals.
        /// </summary>
        [JsonProperty(PropertyName = "http_request_rate")]
        public double? HttpRequestRate { get; set; }
        /// <summary>
        /// Number of bytes out
        /// </summary>
        [JsonProperty(PropertyName = "bytes_out", Required = Required.AllowNull)]
        public long BytesOut { get; set; }
        /// <summary>
        /// The average number of inbound packets per second, the number is
        /// averaged over the last 5 one-second intervals.
        /// </summary>
        [JsonProperty(PropertyName = "packets_in_rate")]
        public double? PacketsInRate { get; set; }
        /// <summary>
        /// The average number of inbound bytes per second, the number is
        /// averaged over the last 5 one-second intervals.
        /// </summary>
        [JsonProperty(PropertyName = "bytes_in_rate")]
        public double? BytesInRate { get; set; }
        /// <summary>
        /// Number of current sessions
        /// </summary>
        [JsonProperty(PropertyName = "current_sessions", Required = Required.AllowNull)]
        public long CurrentSessions { get; set; }
        /// <summary>
        /// Number of maximum sessions
        /// </summary>
        [JsonProperty(PropertyName = "max_sessions", Required = Required.AllowNull)]
        public long MaxSessions { get; set; }
        /// <summary>
        /// The average number of outbound packets per second, the number is
        /// averaged over the last 5 one-second intervals.
        /// </summary>
        [JsonProperty(PropertyName = "packets_out_rate")]
        public double? PacketsOutRate { get; set; }
        /// <summary>
        /// The total number of http requests.
        /// </summary>
        [JsonProperty(PropertyName = "http_requests")]
        public long? HttpRequests { get; set; }
        /// <summary>
        /// Number of bytes in
        /// </summary>
        [JsonProperty(PropertyName = "bytes_in", Required = Required.AllowNull)]
        public long BytesIn { get; set; }
        /// <summary>
        /// The average number of current sessions per second, the number is
        /// averaged over the last 5 one-second intervals.
        /// </summary>
        [JsonProperty(PropertyName = "current_session_rate")]
        public double? CurrentSessionRate { get; set; }
        /// <summary>
        /// The total number of dropped sessions by LB rule action.
        /// </summary>
        [JsonProperty(PropertyName = "dropped_sessions_by_lbrule_action")]
        public long? DroppedSessionsByLbruleAction { get; set; }
        /// <summary>
        /// Number of packets in
        /// </summary>
        [JsonProperty(PropertyName = "packets_in")]
        public long? PacketsIn { get; set; }
    }
}
