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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTBFDDiagnosticCountType 
    {
        public NSXTBFDDiagnosticCountType()
        {
        }
        /// <summary>
        /// Number of tunnels with concatenated path down diagnostic message
        /// </summary>
        [JsonProperty(PropertyName = "concatenated_path_down_count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of tunnels with concatenated path down diagnostic message")]
        public long? ConcatenatedPathDownCount { get; set; }
        /// <summary>
        /// Number of tunnels with administratively down diagnostic message
        /// </summary>
        [JsonProperty(PropertyName = "administratively_down_count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of tunnels with administratively down diagnostic message")]
        public long? AdministrativelyDownCount { get; set; }
        /// <summary>
        /// Number of tunnels with no diagnostic
        /// </summary>
        [JsonProperty(PropertyName = "no_diagnostic_count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of tunnels with no diagnostic")]
        public long? NoDiagnosticCount { get; set; }
        /// <summary>
        /// Number of tunnels with path down diagnostic message
        /// </summary>
        [JsonProperty(PropertyName = "path_down_count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of tunnels with path down diagnostic message")]
        public long? PathDownCount { get; set; }
        /// <summary>
        /// Number of tunnels with reverse concatenated path down diagnostic message
        /// </summary>
        [JsonProperty(PropertyName = "reverse_concatenated_path_down_count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of tunnels with reverse concatenated path down diagnostic message")]
        public long? ReverseConcatenatedPathDownCount { get; set; }
        /// <summary>
        /// Number of tunnels neighbor signaled session down
        /// </summary>
        [JsonProperty(PropertyName = "neighbor_signaled_session_down_count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of tunnels neighbor signaled session down")]
        public long? NeighborSignaledSessionDownCount { get; set; }
        /// <summary>
        /// Number of tunnels with control detection time expired diagnostic message
        /// </summary>
        [JsonProperty(PropertyName = "control_detection_time_expired_count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of tunnels with control detection time expired diagnostic message")]
        public long? ControlDetectionTimeExpiredCount { get; set; }
        /// <summary>
        /// Number of tunnels with echo function failed diagnostic message
        /// </summary>
        [JsonProperty(PropertyName = "echo_function_failed_count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of tunnels with echo function failed diagnostic message")]
        public long? EchoFunctionFailedCount { get; set; }
        /// <summary>
        /// Number of tunnels with forwarding plane reset diagnostic message
        /// </summary>
        [JsonProperty(PropertyName = "forwarding_plane_reset_count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of tunnels with forwarding plane reset diagnostic message")]
        public long? ForwardingPlaneResetCount { get; set; }
    }
}
