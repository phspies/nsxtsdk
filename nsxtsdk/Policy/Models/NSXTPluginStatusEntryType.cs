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
    /// Describes plugin status
    /// </summary>
    [NSXTProperty(Description: @"Describes plugin status")]
    public class NSXTPluginStatusEntryType 
    {
        public NSXTPluginStatusEntryType()
        {
        }
        /// <summary>
        /// Plugin status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"Plugin status.")]
        public NSXTPluginStatusEntryStatusEnumType? Status { get; set; }
        /// <summary>
        /// Display the plugin configß content.
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        [NSXTProperty(IsRequired: false, Description: @"Display the plugin configß content.")]
        public string? Profile { get; set; }
        /// <summary>
        /// Plugin id.
        /// </summary>
        [JsonProperty(PropertyName = "plugin_path")]
        [NSXTProperty(IsRequired: false, Description: @"Plugin id.")]
        public string? PluginPath { get; set; }
        /// <summary>
        /// Detail information of plugin.
        /// </summary>
        [JsonProperty(PropertyName = "detail")]
        [NSXTProperty(IsRequired: false, Description: @"Detail information of plugin.")]
        public string? Detail { get; set; }
    }
}