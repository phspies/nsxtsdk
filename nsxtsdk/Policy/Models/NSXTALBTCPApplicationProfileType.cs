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
    /// Advanced load balancer TCPApplicationProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer TCPApplicationProfile object")]
    public class NSXTALBTCPApplicationProfileType 
    {
        /// <summary>
        /// Version of proxy protocol to be used to convey client
        /// connection information to the back-end servers.
        /// Enum options - PROXY_PROTOCOL_VERSION_1,
        /// PROXY_PROTOCOL_VERSION_2.
        /// Allowed in Basic(Allowed values- PROXY_PROTOCOL_VERSION_1)
        /// edition, Essentials(Allowed values-
        /// PROXY_PROTOCOL_VERSION_1) edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as PROXY_PROTOCOL_VERSION_1.
        /// </summary>
        [JsonProperty(PropertyName = "proxy_protocol_version")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbtcpapplicationProfileProxyProtocolVersionEnumType? ProxyProtocolVersion { get; set; }
        /// <summary>
        /// Specifies whether the client side verification is set to
        /// none, request or require.
        /// Enum options - SSL_CLIENT_CERTIFICATE_NONE,
        /// SSL_CLIENT_CERTIFICATE_REQUEST,
        /// SSL_CLIENT_CERTIFICATE_REQUIRE.
        /// Allowed in Basic(Allowed values-
        /// SSL_CLIENT_CERTIFICATE_NONE) edition, Essentials(Allowed
        /// values- SSL_CLIENT_CERTIFICATE_NONE) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as
        /// SSL_CLIENT_CERTIFICATE_NONE.
        /// </summary>
        [JsonProperty(PropertyName = "ssl_client_certificate_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbtcpapplicationProfileSslClientCertificateModeEnumType? SslClientCertificateMode { get; set; }
        /// <summary>
        /// Select the PKI profile to be associated with the Virtual
        /// Service.
        /// This profile defines the Certificate Authority and
        /// Revocation List.
        /// It is a reference to an object of type PKIProfile.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "pki_profile_path")]
        public string? PkiProfilePath { get; set; }
        /// <summary>
        /// Enable/Disable the usage of proxy protocol to convey client
        /// connection information to the back-end servers.
        /// Valid only for L4 application profiles and TCP proxy.
        /// Allowed in Basic(Allowed values- false) edition,
        /// Essentials(Allowed values- false) edition, Enterprise
        /// edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "proxy_protocol_enabled")]
        public bool? ProxyProtocolEnabled { get; set; }
    }
}
