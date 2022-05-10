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
    /// Advanced load balancer SamlServiceProviderNode object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SamlServiceProviderNode object")]
    public class NSXTALBSamlServiceProviderNodeType 
    {
        /// <summary>
        /// Single Signon URL to be programmed on the IDP.
        /// </summary>
        [JsonProperty(PropertyName = "single_signon_url")]
        public string? SingleSignonUrl { get; set; }
        /// <summary>
        /// Globally unique entityID for this node.
        /// Entity ID on the IDP should match this.
        /// </summary>
        [JsonProperty(PropertyName = "entity_id")]
        public string? EntityId { get; set; }
        /// <summary>
        /// Refers to the Cluster name identifier (Virtual IP or FQDN).
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Service Engines will use this SSL certificate to sign
        /// assertions going to the IdP.
        /// It is a reference to an object of type
        /// SSLKeyAndCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "signing_ssl_key_and_certificate_path")]
        public string? SigningSslKeyAndCertificatePath { get; set; }
    }
}
