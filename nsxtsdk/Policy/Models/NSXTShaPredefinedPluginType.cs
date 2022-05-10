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
    [NSXTProperty(Description: @"")]
    public class NSXTShaPredefinedPluginType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "config")]
        public NSXTShaPredefinedPluginProfileDataType Config { get; set; }
        /// <summary>
        /// Display the running node types of predefined plugin.
        /// </summary>
        [JsonProperty(PropertyName = "supported_node_types")]
        public IList<string> SupportedNodeTypes { get; set; }
        /// <summary>
        /// The on-off switch of Sha plugin
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// The corresponding plugin will wait for config seconds after reboot.
        /// </summary>
        [JsonProperty(PropertyName = "delay_on_reboot")]
        public long? DelayOnReboot { get; set; }
        /// <summary>
        /// Display the pre-req conditions to run the predefined plugin.
        /// </summary>
        [JsonProperty(PropertyName = "pre_req_conditions")]
        public IList<string> PreReqConditions { get; set; }
    }
}
