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
    /// SSL protocol
    /// </summary>
    [NSXTProperty(Description: @"SSL protocol")]
    public class NSXTLbSslProtocolInfoType 
    {
        /// <summary>
        /// Default SSL protocol flag
        /// </summary>
        [JsonProperty(PropertyName = "is_default", Required = Required.AllowNull)]
        public bool IsDefault { get; set; }
        /// <summary>
        /// Secure/insecure SSL protocol flag
        /// </summary>
        [JsonProperty(PropertyName = "is_secure", Required = Required.AllowNull)]
        public bool IsSecure { get; set; }
        /// <summary>
        /// SSL protocol
        /// </summary>
        [JsonProperty(PropertyName = "protocol", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbSslProtocolInfoProtocolEnumType Protocol { get; set; }
    }
}
