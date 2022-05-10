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
    public class NSXTSshKeyBasePropertiesType 
    {
        /// <summary>
        /// Current password for user (required for users root and admin)
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// SSH key label (used to identify the key)
        /// </summary>
        [JsonProperty(PropertyName = "label", Required = Required.AllowNull)]
        public string Label { get; set; }
    }
}
