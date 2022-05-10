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
    public class NSXTNSXVConnectionInfoType : NSXTEnforcementPointConnectionInfoType
    {
        /// <summary>
        /// Username.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// Password.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Thumbprint of EnforcementPoint in the form of a SHA-256 hash represented in lower case HEX.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint", Required = Required.AllowNull)]
        public string Thumbprint { get; set; }
    }
}
