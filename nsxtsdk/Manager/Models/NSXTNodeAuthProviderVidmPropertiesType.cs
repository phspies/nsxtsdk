// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Node AAA provider vIDM properties
    /// </summary>
    [NSXTProperty(Description: @"Node AAA provider vIDM properties")]
    public class NSXTNodeAuthProviderVidmPropertiesType 
    {
        public NSXTNodeAuthProviderVidmPropertiesType()
        {
        }
        /// <summary>
        /// vIDM client secret
        /// </summary>
        [JsonProperty(PropertyName = "client_secret")]
        [NSXTProperty(IsRequired: false, Description: @"vIDM client secret")]
        public string? ClientSecret { get; set; }
        /// <summary>
        /// Fully Qualified Domain Name(FQDN) of vIDM
        /// </summary>
        [JsonProperty(PropertyName = "host_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Fully Qualified Domain Name(FQDN) of vIDM")]
        [System.ComponentModel.DataAnnotations.Required]
        public string HostName { get; set; }
        /// <summary>
        /// vIDM client id
        /// </summary>
        [JsonProperty(PropertyName = "client_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"vIDM client id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ClientId { get; set; }
        /// <summary>
        /// vIDM enable flag
        /// </summary>
        [JsonProperty(PropertyName = "vidm_enable")]
        [NSXTProperty(IsRequired: false, Description: @"vIDM enable flag")]
        public bool? VidmEnable { get; set; }
        /// <summary>
        /// Load Balancer enable flag
        /// </summary>
        [JsonProperty(PropertyName = "lb_enable")]
        [NSXTProperty(IsRequired: false, Description: @"Load Balancer enable flag")]
        public bool? LbEnable { get; set; }
        /// <summary>
        /// Hexadecimal SHA256 hash of the vIDM server's X.509 certificate
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Hexadecimal SHA256 hash of the vIDM server&apos;s X.509 certificate")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Thumbprint { get; set; }
        /// <summary>
        /// host name to use when creating the redirect URL for clients to follow after authenticating to vIDM
        /// </summary>
        [JsonProperty(PropertyName = "node_host_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"host name to use when creating the redirect URL for clients to follow after authenticating to vIDM")]
        [System.ComponentModel.DataAnnotations.Required]
        public string NodeHostName { get; set; }
    }
}
