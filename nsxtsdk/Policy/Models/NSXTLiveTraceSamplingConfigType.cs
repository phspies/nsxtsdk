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
    /// Sampling parameter for a livetrace action
    /// </summary>
    [NSXTProperty(Description: @"Sampling parameter for a livetrace action")]
    public class NSXTLiveTraceSamplingConfigType 
    {
        /// <summary>
        /// A packet is sampled for every given time interval in ms.
        /// </summary>
        [JsonProperty(PropertyName = "sampling_interval")]
        public long? SamplingInterval { get; set; }
        /// <summary>
        /// First N packets are sampled. The upper limits of sampling number for trace and packet capture actions
        /// are 50 and 500, respectively.
        /// </summary>
        [JsonProperty(PropertyName = "match_number")]
        public long? MatchNumber { get; set; }
        /// <summary>
        /// 1 out of N packets is sampled on average.
        /// </summary>
        [JsonProperty(PropertyName = "sampling_rate")]
        public long? SamplingRate { get; set; }
    }
}
