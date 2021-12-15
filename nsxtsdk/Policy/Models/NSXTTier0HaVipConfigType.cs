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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Tier0 HA VIP Config
    /// </summary>
    [NSXTProperty(Description: @"Tier0 HA VIP Config")]
    public class NSXTTier0HaVipConfigType 
    {
        /// <summary>
        /// Policy paths to Tier0 external interfaces which are to be paired to provide redundancy. Floating IP will be owned by one
        /// of these interfaces depending upon which edge node is Active.
        /// </summary>
        [JsonProperty(PropertyName = "external_interface_paths", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Policy paths to Tier0 external interfaces which are to be paired to provide redundancy. Floating IP will be owned by one of these interfaces depending upon which edge node is Active.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> ExternalInterfacePaths { get; set; }
        /// <summary>
        /// Array of IP address subnets which will be used as floating IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "vip_subnets", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Array of IP address subnets which will be used as floating IP addresses.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTInterfaceSubnetType> VipSubnets { get; set; }
        /// <summary>
        /// Flag to enable this HA VIP config.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to enable this HA VIP config.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? Enabled { get; set; }
    }
}
