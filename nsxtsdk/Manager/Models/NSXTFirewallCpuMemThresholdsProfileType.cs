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
    public class NSXTFirewallCpuMemThresholdsProfileType : NSXTBaseFirewallProfileType
    {
        /// <summary>
        /// Heap memory threshold percentage to monitor and report for distributed firewall.
        /// </summary>
        [JsonProperty(PropertyName = "mem_threshold_percentage", Required = Required.AllowNull)]
        public long MemThresholdPercentage { get; set; }
        /// <summary>
        /// CPU utilization threshold percentage to monitor and report for distributed firewall.
        /// </summary>
        [JsonProperty(PropertyName = "cpu_threshold_percentage", Required = Required.AllowNull)]
        public long CpuThresholdPercentage { get; set; }
    }
}
