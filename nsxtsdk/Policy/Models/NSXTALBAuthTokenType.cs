// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public string? Token { get; set; }
        /// <summary>
        /// Expiry time of the token will be set by LCM at the time of Enforcement Point Creation.
        /// </summary>
        public string? ExpiresAt { get; set; }
    }
}
