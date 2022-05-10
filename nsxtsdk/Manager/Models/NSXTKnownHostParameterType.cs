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
    public class NSXTKnownHostParameterType 
    {
        /// <summary>
        /// Known host hostname or IP address
        /// </summary>
        [JsonProperty(PropertyName = "host", Required = Required.AllowNull)]
        public string Host { get; set; }
        /// <summary>
        /// Known host port
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
    }
}
