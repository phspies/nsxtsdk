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
    /// Describes plugin status
    /// </summary>
    [NSXTProperty(Description: @"Describes plugin status")]
    public class NSXTPluginStatusEntryType 
    {
        /// <summary>
        /// Plugin status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPluginStatusEntryStatusEnumType? Status { get; set; }
        /// <summary>
        /// Display the plugin configß content.
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public string? Profile { get; set; }
        /// <summary>
        /// Plugin id.
        /// </summary>
        [JsonProperty(PropertyName = "plugin_path")]
        public string? PluginPath { get; set; }
        /// <summary>
        /// Detail information of plugin.
        /// </summary>
        [JsonProperty(PropertyName = "detail")]
        public string? Detail { get; set; }
    }
}
