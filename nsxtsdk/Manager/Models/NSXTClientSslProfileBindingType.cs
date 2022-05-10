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
    public class NSXTClientSslProfileBindingType 
    {
        /// <summary>
        /// client authentication mode
        /// </summary>
        [JsonProperty(PropertyName = "client_auth")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTClientSslProfileBindingClientAuthEnumType? ClientAuth { get; set; }
        /// <summary>
        /// Client SSL profile defines reusable, application-independent client side
        /// SSL properties.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_profile_id")]
        public string? SslProfileId { get; set; }
        /// <summary>
        /// authentication depth is used to set the verification depth in the client
        /// certificates chain.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_chain_depth")]
        public long? CertificateChainDepth { get; set; }
        /// <summary>
        /// If client auth type is REQUIRED, client certificate must be signed by
        /// one of the trusted Certificate Authorities (CAs), also referred to as
        /// root CAs, whose self signed certificates are specified.
        /// </summary>
        [JsonProperty(PropertyName = "client_auth_ca_ids")]
        public IList<string> ClientAuthCaIds { get; set; }
        /// <summary>
        /// A default certificate should be specified which will be used if the
        /// server does not host multiple hostnames on the same IP address or if
        /// the client does not support SNI extension.
        /// </summary>
        [JsonProperty(PropertyName = "default_certificate_id", Required = Required.AllowNull)]
        public string DefaultCertificateId { get; set; }
        /// <summary>
        /// Client-side SSL profile binding allows multiple certificates, for
        /// different hostnames, to be bound to the same virtual server.
        /// </summary>
        [JsonProperty(PropertyName = "sni_certificate_ids")]
        public IList<string> SniCertificateIds { get; set; }
        /// <summary>
        /// A Certificate Revocation List (CRL) can be specified in the client-side
        /// SSL profile binding to disallow compromised client certificates.
        /// </summary>
        [JsonProperty(PropertyName = "client_auth_crl_ids")]
        public IList<string> ClientAuthCrlIds { get; set; }
    }
}
