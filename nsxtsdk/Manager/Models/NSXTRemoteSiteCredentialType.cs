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
    /// Contains the information needed to communicate with another site.
    /// </summary>
    [NSXTProperty(Description: @"Contains the information needed to communicate with another site.")]
    public class NSXTRemoteSiteCredentialType 
    {
        /// <summary>
        /// Username of the site
        /// </summary>
        [JsonProperty(PropertyName = "username", Required = Required.AllowNull)]
        public string Username { get; set; }
        /// <summary>
        /// Sha256 thumbprint of API certificate of the remote site
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string? Thumbprint { get; set; }
        /// <summary>
        /// Password of the site
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Address of the site (IPv4:port)
        /// </summary>
        [JsonProperty(PropertyName = "address", Required = Required.AllowNull)]
        public string Address { get; set; }
    }
}
