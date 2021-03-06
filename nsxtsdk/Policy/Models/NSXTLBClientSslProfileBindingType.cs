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
    /// Client SSL profile binding.
        /// LBClientSslProfileBinding is deprecated as NSX-T Load Balancer is
        /// deprecated.
    /// </summary>
    [NSXTProperty(Description: @"Client SSL profile binding.LBClientSslProfileBinding is deprecated as NSX-T Load Balancer isdeprecated.")]
    public class NSXTLBClientSslProfileBindingType 
    {
        /// <summary>
        /// Client authentication mode.
        /// </summary>
        [JsonProperty(PropertyName = "client_auth")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbclientSslProfileBindingClientAuthEnumType? ClientAuth { get; set; }
        /// <summary>
        /// A Certificate Revocation List (CRL) can be specified in the client-side
        /// SSL profile binding to disallow compromised client certificates.
        /// </summary>
        [JsonProperty(PropertyName = "client_auth_crl_paths")]
        public IList<string> ClientAuthCrlPaths { get; set; }
        /// <summary>
        /// If client auth type is REQUIRED, client certificate must be signed by
        /// one of the trusted Certificate Authorities (CAs), also referred to as
        /// root CAs, whose self signed certificates are specified.
        /// </summary>
        [JsonProperty(PropertyName = "client_auth_ca_paths")]
        public IList<string> ClientAuthCaPaths { get; set; }
        /// <summary>
        /// Authentication depth is used to set the verification depth in the client
        /// certificates chain.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_chain_depth")]
        public long? CertificateChainDepth { get; set; }
        /// <summary>
        /// Client-side SSL profile binding allows multiple certificates, for
        /// different hostnames, to be bound to the same virtual server.
        /// </summary>
        [JsonProperty(PropertyName = "sni_certificate_paths")]
        public IList<string> SniCertificatePaths { get; set; }
        /// <summary>
        /// A default certificate should be specified which will be used if the
        /// server does not host multiple hostnames on the same IP address or if
        /// the client does not support SNI extension.
        /// </summary>
        [JsonProperty(PropertyName = "default_certificate_path", Required = Required.AllowNull)]
        public string DefaultCertificatePath { get; set; }
        /// <summary>
        /// Client SSL profile defines reusable, application-independent client side
        /// SSL properties.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_profile_path")]
        public string? SslProfilePath { get; set; }
    }
}
