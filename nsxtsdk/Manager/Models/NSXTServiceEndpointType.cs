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
    public class NSXTServiceEndpointType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "certificate_sha256_thumbprint")]
        public string? CertificateSha256Thumbprint { get; set; }
        /// <summary>
        /// Certificate or certificate chain
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public string? Certificate { get; set; }
        /// <summary>
        /// List of entities hosted on accessible through the service endpoint
        /// </summary>
        [JsonProperty(PropertyName = "entities_hosted")]
        public IList<NSXTHostedEntityInfoType> EntitiesHosted { get; set; }
        /// <summary>
        /// IPv4 or IPv6 address
        /// </summary>
        [JsonProperty(PropertyName = "ip_address", Required = Required.AllowNull)]
        public string IpAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "fqdn")]
        public string? Fqdn { get; set; }
        /// <summary>
        /// Unique identifier of this service endpoint
        /// </summary>
        [JsonProperty(PropertyName = "service_endpoint_uuid")]
        public string? ServiceEndpointUuid { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "port", Required = Required.AllowNull)]
        public long Port { get; set; }
    }
}
