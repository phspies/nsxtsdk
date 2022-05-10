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
    public class NSXTLbActiveMonitorType : NSXTLbMonitorType
    {
        /// <summary>
        /// If the monitor port is specified, it would override pool member port
        /// setting for healthcheck. A port range is not supported.
        /// For ICMP monitor, monitor_port is not required.
        /// </summary>
        [JsonProperty(PropertyName = "monitor_port")]
        public string? MonitorPort { get; set; }
        /// <summary>
        /// num of consecutive checks must fail before marking it down
        /// </summary>
        [JsonProperty(PropertyName = "fall_count")]
        public long? FallCount { get; set; }
        /// <summary>
        /// the frequency at which the system issues the monitor check (in second)
        /// </summary>
        [JsonProperty(PropertyName = "interval")]
        public long? Interval { get; set; }
        /// <summary>
        /// num of consecutive checks must pass before marking it up
        /// </summary>
        [JsonProperty(PropertyName = "rise_count")]
        public long? RiseCount { get; set; }
        /// <summary>
        /// the number of seconds the target has in which to respond to the monitor
        /// request
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public long? Timeout { get; set; }
    }
}
