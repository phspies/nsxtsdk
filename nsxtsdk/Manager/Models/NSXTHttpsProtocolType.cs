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
    public class NSXTHttpsProtocolType : NSXTProtocolType
    {
        /// <summary>
        /// SSL thumbprint of server
        /// </summary>
        [JsonProperty(PropertyName = "sha256_thumbprint", Required = Required.AllowNull)]
        public string Sha256Thumbprint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "authentication_scheme")]
        public NSXTBasicAuthenticationSchemeType AuthenticationScheme { get; set; }
    }
}
