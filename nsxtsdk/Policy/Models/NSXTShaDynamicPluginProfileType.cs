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
    public class NSXTShaDynamicPluginProfileType : NSXTShaPluginProfileType
    {
        /// <summary>
        /// Define the plugin configurtion.
        /// </summary>
        [JsonProperty(PropertyName = "config", Required = Required.AllowNull)]
        public string Config { get; set; }
    }
}
