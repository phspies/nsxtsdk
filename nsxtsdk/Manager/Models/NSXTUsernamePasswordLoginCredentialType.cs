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
    public class NSXTUsernamePasswordLoginCredentialType : NSXTLoginCredentialType
    {
        /// <summary>
        /// The username for login
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// The authentication password for login
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Thumbprint of the login server
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string? Thumbprint { get; set; }
    }
}
