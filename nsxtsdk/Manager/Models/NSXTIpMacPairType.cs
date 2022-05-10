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
    /// IP and MAC pair.
    /// </summary>
    [NSXTProperty(Description: @"IP and MAC pair.")]
    public class NSXTIpMacPairType 
    {
        /// <summary>
        /// IP address
        /// </summary>
        [JsonProperty(PropertyName = "ip", Required = Required.AllowNull)]
        public string Ip { get; set; }
        /// <summary>
        /// MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac")]
        public string? Mac { get; set; }
    }
}
