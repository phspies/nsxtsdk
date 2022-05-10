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
    [JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritanceAttribute("DfwFirewallConfiguration", typeof(NSXTDfwFirewallConfigurationType))]
    [NSXTProperty(Description: @"")]
    public class NSXTFirewallConfigurationType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// To disable auto drafts, set it to true.
        /// By default, auto drafts are enabled.
        /// </summary>
        [JsonProperty(PropertyName = "disable_auto_drafts")]
        public bool? DisableAutoDrafts { get; set; }
        /// <summary>
        /// When this flag is set to true, global address set is enabled in Distributed Firewall.
        /// </summary>
        [JsonProperty(PropertyName = "global_addrset_mode_enabled")]
        public bool? GlobalAddrsetModeEnabled { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFirewallConfigurationResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// If set to true, Firewall is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enable_firewall")]
        public bool? EnableFirewall { get; set; }
    }
}
