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
    /// ALB Auth Token
    /// </summary>
    [NSXTProperty(Description: @"ALB Auth Token")]
    public class NSXTALBAuthTokenType 
    {
        /// <summary>
        /// controller username.
        /// </summary>
        [JsonProperty(PropertyName = "username", Required = Required.AllowNull)]
        public string Username { get; set; }
        /// <summary>
        /// Hours to validate the token
        /// </summary>
        [JsonProperty(PropertyName = "hours", Required = Required.AllowNull)]
        public string Hours { get; set; }
        /// <summary>
        /// Token for Avi Controller.
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string? Token { get; set; }
        /// <summary>
        /// Expiry time of the token will be set by LCM at the time of Enforcement Point Creation.
        /// </summary>
        [JsonProperty(PropertyName = "expires_at")]
        public string? ExpiresAt { get; set; }
    }
}
