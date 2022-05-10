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
    /// TLS protocol version
    /// </summary>
    [NSXTProperty(Description: @"TLS protocol version")]
    public class NSXTProtocolVersionType 
    {
        /// <summary>
        /// Enable status for this protocol version
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
        /// <summary>
        /// Name of the TLS protocol version
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
    }
}
