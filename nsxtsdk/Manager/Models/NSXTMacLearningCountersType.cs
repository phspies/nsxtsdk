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
    public class NSXTMacLearningCountersType 
    {
        /// <summary>
        /// Number of MACs learned
        /// </summary>
        [JsonProperty(PropertyName = "macs_learned")]
        [NSXTProperty(IsRequired: false, Description: @"Number of MACs learned")]
        public long? MacsLearned { get; set; }
        /// <summary>
        /// The number of packets with unknown source MAC address that are dropped without learning the source MAC address.
        /// Applicable only when the MAC limit is reached and MAC Limit policy is MAC_LEARNING_LIMIT_POLICY_DROP.
        /// </summary>
        [JsonProperty(PropertyName = "mac_not_learned_packets_dropped")]
        [NSXTProperty(IsRequired: false, Description: @"The number of packets with unknown source MAC address that are dropped without learning the source MAC address. Applicable only when the MAC limit is reached and MAC Limit policy is MAC_LEARNING_LIMIT_POLICY_DROP.")]
        public long? MacNotLearnedPacketsDropped { get; set; }
        /// <summary>
        /// The number of packets with unknown source MAC address that are dispatched without learning the source MAC address.
        /// Applicable only when the MAC limit is reached and MAC Limit policy is MAC_LEARNING_LIMIT_POLICY_ALLOW.
        /// </summary>
        [JsonProperty(PropertyName = "mac_not_learned_packets_allowed")]
        [NSXTProperty(IsRequired: false, Description: @"The number of packets with unknown source MAC address that are dispatched without learning the source MAC address. Applicable only when the MAC limit is reached and MAC Limit policy is MAC_LEARNING_LIMIT_POLICY_ALLOW.")]
        public long? MacNotLearnedPacketsAllowed { get; set; }
    }
}
