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
    public class NSXTDynamicPluginFilePropertiesType : NSXTResourceType
    {
        /// <summary>
        /// Upload status
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDynamicPluginFilePropertiesStatusEnumType Status { get; set; }
        /// <summary>
        /// File name
        /// </summary>
        [JsonProperty(PropertyName = "file_name", Required = Required.AllowNull)]
        public string FileName { get; set; }
        /// <summary>
        /// Plugin id
        /// </summary>
        [JsonProperty(PropertyName = "plugin_path", Required = Required.AllowNull)]
        public string PluginPath { get; set; }
    }
}
