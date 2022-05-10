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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSystemHealthAgentProfileType : NSXTManagedResourceType
    {
        /// <summary>
        /// The on-off switch of System Health Agent
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// The id of System Health Agent plugin
        /// </summary>
        [JsonProperty(PropertyName = "plugin_id", Required = Required.AllowNull)]
        public string PluginId { get; set; }
        /// <summary>
        /// The config content of System Health Agent
        /// </summary>
        [JsonProperty(PropertyName = "config", Required = Required.AllowNull)]
        public string Config { get; set; }
        /// <summary>
        /// The type of System Health Agent.
        /// The System Health Agent plugin associated with given plugin id has already defined the profile type.
        /// So the backend can obtain the type by the plugin definition directly. Mark this field as optional.
        /// If need to check the type value by given plugin id, please call /systemhealth/plugins/<plugin-id>.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSystemHealthAgentProfileTypeEnumType? Type { get; set; }
    }
}
