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
        [NSXTProperty(IsRequired: false, Description: @"To disable auto drafts, set it to true.By default, auto drafts are enabled.")]
        public bool? DisableAutoDrafts { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTFirewallConfigurationResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// If set to true, Firewall is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enable_firewall")]
        [NSXTProperty(IsRequired: false, Description: @"If set to true, Firewall is enabled.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? EnableFirewall { get; set; }
    }
}