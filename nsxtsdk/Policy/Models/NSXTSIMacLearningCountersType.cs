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
    public class NSXTSIMacLearningCountersType 
    {
        /// <summary>
        /// Number of MACs learned
        /// </summary>
        [JsonProperty(PropertyName = "macs_learned")]
        public long? MacsLearned { get; set; }
        /// <summary>
        /// The number of packets with unknown source MAC address that are dropped without learning the source MAC address.
        /// Applicable only when the MAC limit is reached and MAC Limit policy is MAC_LEARNING_LIMIT_POLICY_DROP.
        /// </summary>
        [JsonProperty(PropertyName = "mac_not_learned_packets_dropped")]
        public long? MacNotLearnedPacketsDropped { get; set; }
        /// <summary>
        /// The number of packets with unknown source MAC address that are dispatched without learning the source MAC address.
        /// Applicable only when the MAC limit is reached and MAC Limit policy is MAC_LEARNING_LIMIT_POLICY_ALLOW.
        /// </summary>
        [JsonProperty(PropertyName = "mac_not_learned_packets_allowed")]
        public long? MacNotLearnedPacketsAllowed { get; set; }
    }
}
