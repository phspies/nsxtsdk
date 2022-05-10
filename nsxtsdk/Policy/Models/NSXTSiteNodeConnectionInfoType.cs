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
    /// Credential info to connect to a node in the federated remote site.
    /// </summary>
    [NSXTProperty(Description: @"Credential info to connect to a node in the federated remote site.")]
    public class NSXTSiteNodeConnectionInfoType 
    {
        /// <summary>
        /// Username to connect to Site's Local Manager.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// Password to connect to Site's Local Manager.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Please specify the fqdn of the Management Node of your site.
        /// </summary>
        [JsonProperty(PropertyName = "fqdn", Required = Required.AllowNull)]
        public string Fqdn { get; set; }
        /// <summary>
        /// Thumbprint of Site's Local Manager in the form of a SHA-256 hash represented in lower case HEX.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string? Thumbprint { get; set; }
    }
}
