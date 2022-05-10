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
    [JsonInheritanceAttribute("ShaDynamicPluginProfile", typeof(NSXTShaDynamicPluginProfileType))]
    [JsonInheritanceAttribute("ShaPredefinedPluginProfile", typeof(NSXTShaPredefinedPluginProfileType))]
    [NSXTProperty(Description: @"")]
    public class NSXTShaPluginProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The Policy group path to apply the changes on Sha Plugin.
        /// It can be pre-defined plugin or dynamic created plugin.
        /// </summary>
        [JsonProperty(PropertyName = "applied_to_group_path")]
        public string? AppliedToGroupPath { get; set; }
        /// <summary>
        /// The policy path of Sha Plugin. It can be pre-defined plugin or dynamic created plugin.
        /// </summary>
        [JsonProperty(PropertyName = "plugin_path", Required = Required.AllowNull)]
        public string PluginPath { get; set; }
        /// <summary>
        /// The on-off switch of System Health Plugin
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
        /// <summary>
        /// Valid System Health plugin types
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTShaPluginProfileResourceTypeEnumType ResourceType { get; set; }
    }
}
