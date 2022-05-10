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
    public class NSXTMacDiscoveryProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Indicates how long learned MAC address remain.
        /// </summary>
        [JsonProperty(PropertyName = "mac_learning_aging_time")]
        public int? MacLearningAgingTime { get; set; }
        /// <summary>
        /// Allowing source MAC address learning
        /// </summary>
        [JsonProperty(PropertyName = "mac_learning_enabled", Required = Required.AllowNull)]
        public bool MacLearningEnabled { get; set; }
        /// <summary>
        /// The policy after MAC Limit is exceeded
        /// </summary>
        [JsonProperty(PropertyName = "mac_limit_policy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMacDiscoveryProfileMacLimitPolicyEnumType? MacLimitPolicy { get; set; }
        /// <summary>
        /// The maximum number of mac addresses learnt on an overlay logical switch, irrespective of whether mac learning
        /// is enabled on the segment ports. When this limit is reached, traffic for mac addresses that are not learnt
        /// will be flooded.
        /// </summary>
        [JsonProperty(PropertyName = "remote_overlay_mac_limit")]
        public int? RemoteOverlayMacLimit { get; set; }
        /// <summary>
        /// The maximum number of mac addresses that can be learnt on this port when mac learning is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "mac_limit")]
        public int? MacLimit { get; set; }
        /// <summary>
        /// Allowing source MAC address change
        /// </summary>
        [JsonProperty(PropertyName = "mac_change_enabled")]
        public bool? MacChangeEnabled { get; set; }
        /// <summary>
        /// Allowing flooding for unlearned MAC for ingress traffic
        /// </summary>
        [JsonProperty(PropertyName = "unknown_unicast_flooding_enabled")]
        public bool? UnknownUnicastFloodingEnabled { get; set; }
    }
}
