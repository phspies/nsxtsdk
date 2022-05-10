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
    /// Task properties
    /// </summary>
    [NSXTProperty(Description: @"Task properties")]
    public class NSXTUpgradeTaskPropertiesType 
    {
        /// <summary>
        /// Name of Bundle
        /// </summary>
        [JsonProperty(PropertyName = "bundle_name", Required = Required.AllowNull)]
        public string BundleName { get; set; }
        /// <summary>
        /// Step name
        /// </summary>
        [JsonProperty(PropertyName = "step")]
        public string? Step { get; set; }
        /// <summary>
        /// Bundle arguments
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public object? Parameters { get; set; }
    }
}
