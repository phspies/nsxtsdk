// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSystemHealthPluginProfileType : NSXTManagedResourceType
    {
        /// <summary>
        /// Display the running node types of pre-defined plugin.
        /// The config can be changed by API /systemhealth/profiles.
        /// To see the effective status on given node, use the status API per node
        /// /systemhealth/plugins/status/<node-id>.
        /// </summary>
        public IList<string> NodeTypes { get; set; }
        /// <summary>
        /// The publisher of System Health Agent plugin
        /// </summary>
        public string? Publisher { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTSHAPredefinedPluginProfileDataType Config { get; set; }
        /// <summary>
        /// Display the default on-off switch of pre defined plugin.
        /// The config can be changed by API /systemhealth/profiles.
        /// To see the effective status on given node, use the status API per node
        /// /systemhealth/plugins/status/<node-id>.
        /// </summary>
        public bool? Enabled { get; set; }
        /// <summary>
        /// The type of System Health Agent plugin
        /// </summary>
        public NSXTSystemHealthPluginProfileTypeEnumType? Type { get; set; }
    }
}
