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
    /// BPDU filter configuration
    /// </summary>
    [NSXTProperty(Description: @"BPDU filter configuration")]
    public class NSXTBpduFilterType 
    {
        /// <summary>
        /// Pre-defined list of allowed MAC addresses to be excluded from BPDU filtering
        /// </summary>
        [JsonProperty(PropertyName = "white_list")]
        public IList<string> WhiteList { get; set; }
        /// <summary>
        /// Indicates whether BPDU filter is enabled
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
    }
}
