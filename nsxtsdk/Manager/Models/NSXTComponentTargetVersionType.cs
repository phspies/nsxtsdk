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
    public class NSXTComponentTargetVersionType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "target_version")]
        public string? TargetVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "component_type")]
        public string? ComponentType { get; set; }
    }
}
