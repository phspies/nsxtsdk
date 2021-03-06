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
    /// Advanced load balancer IpAddr object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer IpAddr object")]
    public class NSXTALBIpAddrType 
    {
        /// <summary>
        /// Enum options - V4, DNS, V6.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbipAddrTypeEnumType Type { get; set; }
        /// <summary>
        /// IP address.
        /// </summary>
        [JsonProperty(PropertyName = "addr", Required = Required.AllowNull)]
        public string Addr { get; set; }
    }
}
