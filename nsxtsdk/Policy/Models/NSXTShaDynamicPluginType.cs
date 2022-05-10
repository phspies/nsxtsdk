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
    public class NSXTShaDynamicPluginType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// The Policy group path to apply the changes on Sha Plugin.
        /// It can be pre-defined plugin or dynamic created plugin.
        /// </summary>
        [JsonProperty(PropertyName = "applied_to_group_path")]
        public string? AppliedToGroupPath { get; set; }
        /// <summary>
        /// Flag to show the dynamic plugin zip file is uploaded.
        /// </summary>
        [JsonProperty(PropertyName = "is_plugin_uploaded")]
        public bool? IsPluginUploaded { get; set; }
    }
}
