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
    /// Node AAA provider vIDM properties
    /// </summary>
    [NSXTProperty(Description: @"Node AAA provider vIDM properties")]
    public class NSXTNodeAuthProviderVidmPropertiesType 
    {
        /// <summary>
        /// vIDM client secret
        /// </summary>
        [JsonProperty(PropertyName = "client_secret")]
        public string? ClientSecret { get; set; }
        /// <summary>
        /// Fully Qualified Domain Name(FQDN) of vIDM
        /// </summary>
        [JsonProperty(PropertyName = "host_name", Required = Required.AllowNull)]
        public string HostName { get; set; }
        /// <summary>
        /// vIDM client id
        /// </summary>
        [JsonProperty(PropertyName = "client_id", Required = Required.AllowNull)]
        public string ClientId { get; set; }
        /// <summary>
        /// vIDM enable flag
        /// </summary>
        [JsonProperty(PropertyName = "vidm_enable")]
        public bool? VidmEnable { get; set; }
        /// <summary>
        /// Load Balancer enable flag
        /// </summary>
        [JsonProperty(PropertyName = "lb_enable")]
        public bool? LbEnable { get; set; }
        /// <summary>
        /// Hexadecimal SHA256 hash of the vIDM server's X.509 certificate
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint", Required = Required.AllowNull)]
        public string Thumbprint { get; set; }
        /// <summary>
        /// host name to use when creating the redirect URL for clients to follow after authenticating to vIDM
        /// </summary>
        [JsonProperty(PropertyName = "node_host_name", Required = Required.AllowNull)]
        public string NodeHostName { get; set; }
    }
}
