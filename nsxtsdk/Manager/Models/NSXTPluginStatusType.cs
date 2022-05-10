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
    /// Describes plugin status on node
    /// </summary>
    [NSXTProperty(Description: @"Describes plugin status on node")]
    public class NSXTPluginStatusType 
    {
        /// <summary>
        /// Plugin status.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPluginStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Display the plugin profile content.
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public string? Profile { get; set; }
        /// <summary>
        /// Detail information of plugin.
        /// </summary>
        [JsonProperty(PropertyName = "detail")]
        public string? Detail { get; set; }
        /// <summary>
        /// Plugin id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Plugin name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
