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
    public class NSXTPluginFilePropertiesType : NSXTResourceType
    {
        /// <summary>
        /// Upload status
        /// </summary>
        [JsonProperty(PropertyName = "status", Required = Required.AllowNull)]
        public string Status { get; set; }
        /// <summary>
        /// File name
        /// </summary>
        [JsonProperty(PropertyName = "file_name", Required = Required.AllowNull)]
        public string FileName { get; set; }
        /// <summary>
        /// Plugin id
        /// </summary>
        [JsonProperty(PropertyName = "plugin_id", Required = Required.AllowNull)]
        public string PluginId { get; set; }
    }
}
