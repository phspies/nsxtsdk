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
    /// Meta-data of a pre/post-upgrade check
    /// </summary>
    [NSXTProperty(Description: @"Meta-data of a pre/post-upgrade check")]
    public class NSXTUpgradeCheckInfoType 
    {
        /// <summary>
        /// Display name of the pre/post-upgrade check
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Component type of the pre/post-upgrade check
        /// </summary>
        [JsonProperty(PropertyName = "component_type", Required = Required.AllowNull)]
        public string ComponentType { get; set; }
        /// <summary>
        /// Description of the pre/post-upgrade check
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
    }
}
