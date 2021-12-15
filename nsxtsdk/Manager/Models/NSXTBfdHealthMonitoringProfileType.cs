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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTBfdHealthMonitoringProfileType : NSXTTransportZoneProfileType
    {
        /// <summary>
        /// The time interval (in millisec) between probe packets for tunnels between transport nodes.
        /// </summary>
        [JsonProperty(PropertyName = "probe_interval")]
        [NSXTProperty(IsRequired: false, Description: @"The time interval (in millisec) between probe packets for tunnels between transport nodes.")]
        //[System.ComponentModel.DataAnnotations.MinLength(300)]
        [NSXTDefaultProperty(Default: "")]
        public long? ProbeInterval { get; set; }
        /// <summary>
        /// The flag is to turn on/off latency. A POST or PUT request with "latency_enabled" true will enable NSX to send the
        /// networking latency data to thrid-party monitoring tools like vRNI.
        /// </summary>
        [JsonProperty(PropertyName = "latency_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"The flag is to turn on/off latency. A POST or PUT request with &quot;latency_enabled&quot; true will enable NSX to send the networking latency data to thrid-party monitoring tools like vRNI.")]
        public bool? LatencyEnabled { get; set; }
        /// <summary>
        /// Whether the heartbeat is enabled. A POST or PUT request with "enabled" false (with no probe intervals) will set (POST)
        /// or reset (PUT) the probe_interval to their default value.
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Whether the heartbeat is enabled. A POST or PUT request with &quot;enabled&quot; false (with no probe intervals) will set (POST) or reset (PUT) the probe_interval to their default value.")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Enabled { get; set; }
    }
}
