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
    /// Software module details
    /// </summary>
    [NSXTProperty(Description: @"Software module details")]
    public class NSXTSoftwareModuleType 
    {
        /// <summary>
        /// Name of the module in the node
        /// </summary>
        [JsonProperty(PropertyName = "module_name", Required = Required.AllowNull)]
        public string ModuleName { get; set; }
        /// <summary>
        /// Version of the module in the node
        /// </summary>
        [JsonProperty(PropertyName = "module_version", Required = Required.AllowNull)]
        public string ModuleVersion { get; set; }
    }
}
