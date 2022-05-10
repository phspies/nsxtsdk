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
    /// Health Status of a third party partner VM.
    /// </summary>
    [NSXTProperty(Description: @"Health Status of a third party partner VM.")]
    public class NSXTServiceInstanceHealthStatusType 
    {
        /// <summary>
        /// Protocol version might be different in both Mux and SVA.
        /// </summary>
        [JsonProperty(PropertyName = "is_sva_mux_incompatible")]
        public bool? IsSvaMuxIncompatible { get; set; }
        /// <summary>
        /// Latest timestamp when mux was connected to SVA.
        /// </summary>
        [JsonProperty(PropertyName = "connect_timestamp")]
        public string? ConnectTimestamp { get; set; }
        /// <summary>
        /// Mux version when Mux and SVA are incompatible
        /// </summary>
        [JsonProperty(PropertyName = "mux_incompatible_version")]
        public string? MuxIncompatibleVersion { get; set; }
        /// <summary>
        /// Version of third party partner solution application.
        /// </summary>
        [JsonProperty(PropertyName = "solution_version")]
        public string? SolutionVersion { get; set; }
        /// <summary>
        /// Latest timestamp when health status is received.
        /// </summary>
        [JsonProperty(PropertyName = "sync_time")]
        public string? SyncTime { get; set; }
        /// <summary>
        /// Status of third party partner solution application.
        /// </summary>
        [JsonProperty(PropertyName = "solution_status")]
        public string? SolutionStatus { get; set; }
        /// <summary>
        /// The parameter is set if the last received health status is older
        /// than the predefined interval.
        /// </summary>
        [JsonProperty(PropertyName = "is_stale")]
        public bool? IsStale { get; set; }
        /// <summary>
        /// Status of multiplexer which forwards the events from guest virtual machines to the partner appliance.
        /// </summary>
        [JsonProperty(PropertyName = "mux_connected_status")]
        public string? MuxConnectedStatus { get; set; }
    }
}
