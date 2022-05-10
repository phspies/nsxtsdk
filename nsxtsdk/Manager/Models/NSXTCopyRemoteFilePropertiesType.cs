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
    public class NSXTCopyRemoteFilePropertiesType 
    {
        /// <summary>
        /// URI of file to copy
        /// </summary>
        [JsonProperty(PropertyName = "uri", Required = Required.AllowNull)]
        public string Uri { get; set; }
        /// <summary>
        /// Server port
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
        /// <summary>
        /// Remote server hostname or IP address
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        public string Server { get; set; }
    }
}
