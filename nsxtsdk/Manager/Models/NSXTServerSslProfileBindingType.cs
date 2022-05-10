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
    public class NSXTServerSslProfileBindingType 
    {
        /// <summary>
        /// A Certificate Revocation List (CRL) can be specified in the server-side
        /// SSL profile binding to disallow compromised server certificates.
        /// </summary>
        [JsonProperty(PropertyName = "server_auth_crl_ids")]
        public IList<string> ServerAuthCrlIds { get; set; }
        /// <summary>
        /// server authentication mode
        /// </summary>
        [JsonProperty(PropertyName = "server_auth")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTServerSslProfileBindingServerAuthEnumType? ServerAuth { get; set; }
        /// <summary>
        /// authentication depth is used to set the verification depth in the server
        /// certificates chain.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_chain_depth")]
        public long? CertificateChainDepth { get; set; }
        /// <summary>
        /// To support client authentication (load balancer acting as a client
        /// authenticating to the backend server), client certificate can be
        /// specified in the server-side SSL profile binding
        /// </summary>
        [JsonProperty(PropertyName = "client_certificate_id")]
        public string? ClientCertificateId { get; set; }
        /// <summary>
        /// If server auth type is REQUIRED, server certificate must be signed by
        /// one of the trusted Certificate Authorities (CAs), also referred to as
        /// root CAs, whose self signed certificates are specified.
        /// </summary>
        [JsonProperty(PropertyName = "server_auth_ca_ids")]
        public IList<string> ServerAuthCaIds { get; set; }
        /// <summary>
        /// Server SSL profile defines reusable, application-independent server side
        /// SSL properties.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_profile_id")]
        public string? SslProfileId { get; set; }
    }
}
