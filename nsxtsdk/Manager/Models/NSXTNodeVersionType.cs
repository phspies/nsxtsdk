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
    public class NSXTNodeVersionType 
    {
        /// <summary>
        /// Product version
        /// </summary>
        [JsonProperty(PropertyName = "product_version")]
        public string? ProductVersion { get; set; }
        /// <summary>
        /// Node version
        /// </summary>
        [JsonProperty(PropertyName = "node_version")]
        public string? NodeVersion { get; set; }
    }
}
