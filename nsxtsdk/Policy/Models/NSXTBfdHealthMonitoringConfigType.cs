using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Bfd Health Monitoring Options used specific to BFD Transport Zone profiles
    /// </summary>
    [NSXTProperty(Description: @"Bfd Health Monitoring Options used specific to BFD Transport Zone profiles")]
    public class NSXTBfdHealthMonitoringConfigType 
    {
        /// <summary>
        /// The time interval (in millisec) between probe packets for tunnels between transport nodes.
        /// </summary>
        [JsonProperty(PropertyName = "probe_interval")]
        public long? ProbeInterval { get; set; }
        /// <summary>
        /// The flag is to turn on/off latency. A PATCH or PUT request with "latency_enabled" true will enable NSX to send the
        /// networking latency data to thrid-party monitoring tools like vRNI.
        /// </summary>
        [JsonProperty(PropertyName = "latency_enabled")]
        public bool? LatencyEnabled { get; set; }
        /// <summary>
        /// Whether the heartbeat is enabled. A PATCH or PUT request with "enabled" false (with no probe intervals) will set or
        /// reset the probe_interval to their default value.
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
    }
}
