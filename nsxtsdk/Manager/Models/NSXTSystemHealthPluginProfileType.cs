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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSystemHealthPluginProfileType : NSXTManagedResourceType
    {
        public NSXTSystemHealthPluginProfileType()
        {
            Type = test
        }
        /// <summary>
        /// Display the running node types of pre-defined plugin.
        /// The config can be changed by API /systemhealth/profiles.
        /// To see the effective status on given node, use the status API per node
        /// /systemhealth/plugins/status/<node-id>.
        /// </summary>
        [JsonProperty(PropertyName = "node_types")]
        [NSXTProperty(IsRequired: false, Description: @"Display the running node types of pre-defined plugin.The config can be changed by API /systemhealth/profiles.To see the effective status on given node, use the status API per node/systemhealth/plugins/status/&lt;node-id&gt;.")]
        public IList<string> NodeTypes { get; set; }
        /// <summary>
        /// The publisher of System Health Agent plugin
        /// </summary>
        [JsonProperty(PropertyName = "publisher")]
        [NSXTProperty(IsRequired: false, Description: @"The publisher of System Health Agent plugin")]
        public string? Publisher { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "config")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTSHAPredefinedPluginProfileDataType Config { get; set; }
        /// <summary>
        /// Display the default on-off switch of pre defined plugin.
        /// The config can be changed by API /systemhealth/profiles.
        /// To see the effective status on given node, use the status API per node
        /// /systemhealth/plugins/status/<node-id>.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Display the default on-off switch of pre defined plugin.The config can be changed by API /systemhealth/profiles.To see the effective status on given node, use the status API per node/systemhealth/plugins/status/&lt;node-id&gt;.")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// The type of System Health Agent plugin
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [NSXTProperty(IsRequired: false, Description: @"The type of System Health Agent plugin")]
        public NSXTSystemHealthPluginProfileTypeEnumType? Type { get; set; }
    }
}
