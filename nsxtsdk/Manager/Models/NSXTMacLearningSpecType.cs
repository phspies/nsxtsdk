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
    /// MAC learning configuration
    /// </summary>
    [NSXTProperty(Description: @"MAC learning configuration")]
    public class NSXTMacLearningSpecType 
    {
        /// <summary>
        /// This property specifies the limit on the maximum number of MAC
        /// addresses that can be learned on a port. It is consumed by vswitch
        /// kernel module on the hypervisor while learning MACs per port for
        /// VMs that are local to the host.
        /// </summary>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }
        /// <summary>
        /// The policy after MAC Limit is exceeded
        /// </summary>
        [JsonProperty(PropertyName = "limit_policy")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMacLearningSpecLimitPolicyEnumType? LimitPolicy { get; set; }
        /// <summary>
        /// This property specifies the limit on the maximum number of MACs
        /// learned for a remote Virtual Machine's MAC to vtep binding per
        /// overlay logical switch.
        /// </summary>
        [JsonProperty(PropertyName = "remote_overlay_mac_limit")]
        public int? RemoteOverlayMacLimit { get; set; }
        /// <summary>
        /// Aging time in sec for learned MAC address
        /// </summary>
        [JsonProperty(PropertyName = "aging_time")]
        public int? AgingTime { get; set; }
        /// <summary>
        /// Allowing source MAC address learning
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
        /// <summary>
        /// Allowing flooding for unlearned MAC for ingress traffic
        /// </summary>
        [JsonProperty(PropertyName = "unicast_flooding_allowed")]
        public bool? UnicastFloodingAllowed { get; set; }
    }
}
