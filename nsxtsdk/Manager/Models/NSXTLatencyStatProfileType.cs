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
    public class NSXTLatencyStatProfileType : NSXTManagedResourceType
    {
        /// <summary>
        /// Event nth milliseconds packet is sampled. When a value less than
        /// 1000 is given, the realized sampling interval will be 1000 milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "sampling_interval")]
        public long? SamplingInterval { get; set; }
        /// <summary>
        /// Event nth packet is sampled.
        /// </summary>
        [JsonProperty(PropertyName = "sampling_rate")]
        public long? SamplingRate { get; set; }
        /// <summary>
        /// Enable or Disable pnic latency.
        /// </summary>
        [JsonProperty(PropertyName = "pnic_latency_enabled")]
        public bool? PnicLatencyEnabled { get; set; }
    }
}
