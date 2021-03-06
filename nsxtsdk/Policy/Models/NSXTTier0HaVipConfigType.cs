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
        public IList<string> ExternalInterfacePaths { get; set; }
        /// <summary>
        /// Array of IP address subnets which will be used as floating IP addresses.
        /// </summary>
        [JsonProperty(PropertyName = "vip_subnets", Required = Required.AllowNull)]
        public IList<NSXTInterfaceSubnetType> VipSubnets { get; set; }
        /// <summary>
        /// Flag to enable this HA VIP config.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
    }
}
