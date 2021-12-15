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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Server SSL profile binding.
    /// </summary>
    [NSXTProperty(Description: @"Server SSL profile binding.")]
    public class NSXTLBServerSslProfileBindingType 
    {
        /// <summary>
        /// If server auth type is REQUIRED, server certificate must be signed by
        /// one of the trusted Certificate Authorities (CAs), also referred to as
        /// root CAs, whose self signed certificates are specified.
        /// </summary>
        [JsonProperty(PropertyName = "server_auth_ca_paths")]
        [NSXTProperty(IsRequired: false, Description: @"If server auth type is REQUIRED, server certificate must be signed byone of the trusted Certificate Authorities (CAs), also referred to asroot CAs, whose self signed certificates are specified.")]
        public IList<string> ServerAuthCaPaths { get; set; }
        /// <summary>
        /// To support client authentication (load balancer acting as a client
        /// authenticating to the backend server), client certificate can be
        /// specified in the server-side SSL profile binding
        /// </summary>
        [JsonProperty(PropertyName = "client_certificate_path")]
        [NSXTProperty(IsRequired: false, Description: @"To support client authentication (load balancer acting as a clientauthenticating to the backend server), client certificate can bespecified in the server-side SSL profile binding")]
        public string? ClientCertificatePath { get; set; }
        /// <summary>
        /// Server authentication mode.
        /// </summary>
        [JsonProperty(PropertyName = "server_auth")]
        [NSXTProperty(IsRequired: false, Description: @"Server authentication mode.")]
        [NSXTDefaultProperty(Default: "AUTO_APPLY")]
        public NSXTLbserverSslProfileBindingServerAuthEnumType? ServerAuth { get; set; }
        /// <summary>
        /// Authentication depth is used to set the verification depth in the server
        /// certificates chain.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_chain_depth")]
        [NSXTProperty(IsRequired: false, Description: @"Authentication depth is used to set the verification depth in the servercertificates chain.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(2147483647)]
        [NSXTDefaultProperty(Default: "")]
        public long? CertificateChainDepth { get; set; }
        /// <summary>
        /// A Certificate Revocation List (CRL) can be specified in the server-side
        /// SSL profile binding to disallow compromised server certificates.
        /// </summary>
        [JsonProperty(PropertyName = "server_auth_crl_paths")]
        [NSXTProperty(IsRequired: false, Description: @"A Certificate Revocation List (CRL) can be specified in the server-sideSSL profile binding to disallow compromised server certificates.")]
        public IList<string> ServerAuthCrlPaths { get; set; }
        /// <summary>
        /// Server SSL profile defines reusable, application-independent server side
        /// SSL properties.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_profile_path")]
        [NSXTProperty(IsRequired: false, Description: @"Server SSL profile defines reusable, application-independent server sideSSL properties.")]
        public string? SslProfilePath { get; set; }
    }
}