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
    public class NSXTSessionLoginCredentialType : NSXTLoginCredentialType
    {
        /// <summary>
        /// The session_id to login to server.
        /// </summary>
        [JsonProperty(PropertyName = "session_id")]
        public string? SessionId { get; set; }
        /// <summary>
        /// Thumbprint of the login server.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string? Thumbprint { get; set; }
    }
}
