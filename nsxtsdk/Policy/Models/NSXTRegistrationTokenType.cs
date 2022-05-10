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
    /// Appliance registration access token
    /// </summary>
    [NSXTProperty(Description: @"Appliance registration access token")]
    public class NSXTRegistrationTokenType 
    {
        /// <summary>
        /// Access token
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string? Token { get; set; }
        /// <summary>
        /// User delegated by token
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string? User { get; set; }
        /// <summary>
        /// List results
        /// </summary>
        [JsonProperty(PropertyName = "roles", Required = Required.AllowNull)]
        public IList<string> Roles { get; set; }
    }
}
