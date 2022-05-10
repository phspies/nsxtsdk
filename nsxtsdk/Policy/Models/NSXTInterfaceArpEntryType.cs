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
    public class NSXTInterfaceArpEntryType 
    {
        /// <summary>
        /// The IP address
        /// </summary>
        [JsonProperty(PropertyName = "ip", Required = Required.AllowNull)]
        public string Ip { get; set; }
        /// <summary>
        /// The MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac_address", Required = Required.AllowNull)]
        public string MacAddress { get; set; }
    }
}
