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
    /// install-upgrade service properties
    /// </summary>
    [NSXTProperty(Description: @"install-upgrade service properties")]
    public class NSXTInstallUpgradeServicePropertiesType 
    {
        /// <summary>
        /// IP of manager on which install-upgrade is enabled
        /// </summary>
        [JsonProperty(PropertyName = "enabled_on")]
        public string? EnabledOn { get; set; }
        /// <summary>
        /// True if service enabled; otherwise, false
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
    }
}
