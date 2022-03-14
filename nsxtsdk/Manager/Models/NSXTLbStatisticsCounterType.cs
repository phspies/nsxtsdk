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
        public long? SourceIpPersistenceEntrySize { get; set; }
        /// <summary>
        /// Number of packets out
        /// </summary>
        public long? PacketsOut { get; set; }
        /// <summary>
        /// The total number of dropped TCP SYN or UDP packets by access list
        /// control.
        /// </summary>
        public long? DroppedPacketsByAccessList { get; set; }
        /// <summary>
        /// The average number of outbound bytes per second, the number is
        /// averaged over the last 5 one-second intervals.
        /// </summary>
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
        public double? PacketsInRate { get; set; }
        /// <summary>
        /// The average number of inbound bytes per second, the number is
        /// averaged over the last 5 one-second intervals.
        /// </summary>
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
        public double? PacketsOutRate { get; set; }
        /// <summary>
        /// The total number of http requests.
        /// </summary>
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
        public double? CurrentSessionRate { get; set; }
        /// <summary>
        /// The total number of dropped sessions by LB rule action.
        /// </summary>
        public long? DroppedSessionsByLbruleAction { get; set; }
        /// <summary>
        /// Number of packets in
        /// </summary>
        public long? PacketsIn { get; set; }
    }
}
