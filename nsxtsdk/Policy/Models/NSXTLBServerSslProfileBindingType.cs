// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Server SSL profile binding.
        /// LBServerSslProfileBinding is deprecated as NSX-T Load Balancer is
        /// deprecated.
    /// </summary>
    [NSXTProperty(Description: @"Server SSL profile binding.LBServerSslProfileBinding is deprecated as NSX-T Load Balancer isdeprecated.")]
    public class NSXTLBServerSslProfileBindingType 
    {
        /// <summary>
        /// If server auth type is REQUIRED, server certificate must be signed by
        /// one of the trusted Certificate Authorities (CAs), also referred to as
        /// root CAs, whose self signed certificates are specified.
        /// </summary>
        public IList<string> ServerAuthCaPaths { get; set; }
        /// <summary>
        /// To support client authentication (load balancer acting as a client
        /// authenticating to the backend server), client certificate can be
        /// specified in the server-side SSL profile binding
        /// </summary>
        public string? ClientCertificatePath { get; set; }
        /// <summary>
        /// Server authentication mode.
        /// </summary>
        public NSXTLbserverSslProfileBindingServerAuthEnumType? ServerAuth { get; set; }
        /// <summary>
        /// Authentication depth is used to set the verification depth in the server
        /// certificates chain.
        /// </summary>
        public long? CertificateChainDepth { get; set; }
        /// <summary>
        /// A Certificate Revocation List (CRL) can be specified in the server-side
        /// SSL profile binding to disallow compromised server certificates.
        /// </summary>
        public IList<string> ServerAuthCrlPaths { get; set; }
        /// <summary>
        /// Server SSL profile defines reusable, application-independent server side
        /// SSL properties.
        /// </summary>
        public string? SslProfilePath { get; set; }
    }
}
