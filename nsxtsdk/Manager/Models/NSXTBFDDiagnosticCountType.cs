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
    public class NSXTBFDDiagnosticCountType 
    {
        /// <summary>
        /// Number of tunnels with concatenated path down diagnostic message
        /// </summary>
        [JsonProperty(PropertyName = "concatenated_path_down_count")]
        public long? ConcatenatedPathDownCount { get; set; }
        /// <summary>
        /// Number of tunnels with administratively down diagnostic message
        /// </summary>
        [JsonProperty(PropertyName = "administratively_down_count")]
        public long? AdministrativelyDownCount { get; set; }
        /// <summary>
        /// Number of tunnels with no diagnostic
        /// </summary>
        [JsonProperty(PropertyName = "no_diagnostic_count")]
        public long? NoDiagnosticCount { get; set; }
        /// <summary>
        /// Number of tunnels with path down diagnostic message
        /// </summary>
        [JsonProperty(PropertyName = "path_down_count")]
        public long? PathDownCount { get; set; }
        /// <summary>
        /// Number of tunnels with reverse concatenated path down diagnostic message
        /// </summary>
        [JsonProperty(PropertyName = "reverse_concatenated_path_down_count")]
        public long? ReverseConcatenatedPathDownCount { get; set; }
        /// <summary>
        /// Number of tunnels neighbor signaled session down
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_signaled_session_down_count")]
        public long? NeighborSignaledSessionDownCount { get; set; }
        /// <summary>
        /// Number of tunnels with control detection time expired diagnostic message
        /// </summary>
        [JsonProperty(PropertyName = "control_detection_time_expired_count")]
        public long? ControlDetectionTimeExpiredCount { get; set; }
        /// <summary>
        /// Number of tunnels with echo function failed diagnostic message
        /// </summary>
        [JsonProperty(PropertyName = "echo_function_failed_count")]
        public long? EchoFunctionFailedCount { get; set; }
        /// <summary>
        /// Number of tunnels with forwarding plane reset diagnostic message
        /// </summary>
        [JsonProperty(PropertyName = "forwarding_plane_reset_count")]
        public long? ForwardingPlaneResetCount { get; set; }
    }
}
