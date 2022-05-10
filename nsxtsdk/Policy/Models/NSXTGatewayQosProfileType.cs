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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTGatewayQosProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Burst size in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "burst_size")]
        public int? BurstSize { get; set; }
        /// <summary>
        /// Action on traffic exceeding bandwidth.
        /// </summary>
        [JsonProperty(PropertyName = "excess_action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTGatewayQosProfileExcessActionEnumType? ExcessAction { get; set; }
        /// <summary>
        /// Committed bandwidth in both directions specified in Mbps.
        /// Bandwidth is limited to line rate when the value configured is greater
        /// than line rate.
        /// This property is deprecated, use committed_bandwidth instead.
        /// </summary>
        [JsonProperty(PropertyName = "committed_bandwitdth")]
        public int? CommittedBandwitdth { get; set; }
        /// <summary>
        /// Committed bandwidth in both directions specified in Mbps.
        /// Bandwidth is limited to line rate when the value configured is greater
        /// than line rate.
        /// </summary>
        [JsonProperty(PropertyName = "committed_bandwidth")]
        public int? CommittedBandwidth { get; set; }
    }
}
