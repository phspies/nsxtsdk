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
    public class NSXTSamlTokenLoginCredentialType : NSXTLoginCredentialType
    {
        /// <summary>
        /// The saml token to login to server.
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string? Token { get; set; }
        /// <summary>
        /// Thumbprint of the server.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string? Thumbprint { get; set; }
    }
}
