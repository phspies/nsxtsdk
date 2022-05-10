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
    public class NSXTBridgeHighAvailabilityClusterProfileType : NSXTClusterProfileType
    {
        /// <summary>
        /// whether the heartbeat is enabled
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// the time interval (in millisec) between probe packets for heartbeat purpose
        /// </summary>
        [JsonProperty(PropertyName = "bfd_probe_interval")]
        public long? BfdProbeInterval { get; set; }
    }
}
