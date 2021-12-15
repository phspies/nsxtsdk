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
        [NSXTProperty(IsRequired: false, Description: @"This property specifies the limit on the maximum number of MACaddresses that can be learned on a port. It is consumed by vswitchkernel module on the hypervisor while learning MACs per port forVMs that are local to the host.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(4096)]
        [NSXTDefaultProperty(Default: "")]
        public int? Limit { get; set; }
        /// <summary>
        /// The policy after MAC Limit is exceeded
        /// </summary>
        [JsonProperty(PropertyName = "limit_policy")]
        [NSXTProperty(IsRequired: false, Description: @"The policy after MAC Limit is exceeded")]
        [NSXTDefaultProperty(Default: "ALLOW")]
        public NSXTMacLearningSpecLimitPolicyEnumType? LimitPolicy { get; set; }
        /// <summary>
        /// This property specifies the limit on the maximum number of MACs
        /// learned for a remote Virtual Machine's MAC to vtep binding per
        /// overlay logical switch.
        /// </summary>
        [JsonProperty(PropertyName = "remote_overlay_mac_limit")]
        [NSXTProperty(IsRequired: false, Description: @"This property specifies the limit on the maximum number of MACslearned for a remote Virtual Machine&apos;s MAC to vtep binding peroverlay logical switch.")]
        //[System.ComponentModel.DataAnnotations.MinLength(2048)]
        //[System.ComponentModel.DataAnnotations.MaxLength(8192)]
        [NSXTDefaultProperty(Default: "")]
        public int? RemoteOverlayMacLimit { get; set; }
        /// <summary>
        /// Aging time in sec for learned MAC address
        /// </summary>
        [JsonProperty(PropertyName = "aging_time")]
        [NSXTProperty(IsRequired: false, Description: @"Aging time in sec for learned MAC address")]
        [NSXTDefaultProperty(Default: "")]
        public int? AgingTime { get; set; }
        /// <summary>
        /// Allowing source MAC address learning
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Allowing source MAC address learning")]
        [System.ComponentModel.DataAnnotations.Required]
        public bool Enabled { get; set; }
        /// <summary>
        /// Allowing flooding for unlearned MAC for ingress traffic
        /// </summary>
        [JsonProperty(PropertyName = "unicast_flooding_allowed")]
        [NSXTProperty(IsRequired: false, Description: @"Allowing flooding for unlearned MAC for ingress traffic")]
        [NSXTDefaultProperty(Default: "")]
        public bool? UnicastFloodingAllowed { get; set; }
    }
}