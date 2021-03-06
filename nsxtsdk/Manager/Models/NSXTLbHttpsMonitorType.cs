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
    public class NSXTLbHttpsMonitorType : NSXTLbActiveMonitorType
    {
        /// <summary>
        /// The HTTP response status code should be a valid HTTP status code.
        /// </summary>
        [JsonProperty(PropertyName = "response_status_codes")]
        public int? ResponseStatusCodes { get; set; }
        /// <summary>
        /// A Certificate Revocation List (CRL) can be specified in the server-side
        /// SSL profile binding to disallow compromised server certificates.
        /// </summary>
        [JsonProperty(PropertyName = "server_auth_crl_ids")]
        public IList<string> ServerAuthCrlIds { get; set; }
        /// <summary>
        /// If server auth type is REQUIRED, server certificate must be signed by
        /// one of the trusted Certificate Authorities (CAs), also referred to as
        /// root CAs, whose self signed certificates are specified.
        /// </summary>
        [JsonProperty(PropertyName = "server_auth_ca_ids")]
        public IList<string> ServerAuthCaIds { get; set; }
        /// <summary>
        /// server authentication mode
        /// </summary>
        [JsonProperty(PropertyName = "server_auth")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbHttpsMonitorServerAuthEnumType? ServerAuth { get; set; }
        /// <summary>
        /// String to send as part of HTTP health check request body. Valid only
        /// for certain HTTP methods like POST.
        /// </summary>
        [JsonProperty(PropertyName = "request_body")]
        public string? RequestBody { get; set; }
        /// <summary>
        /// If HTTP response body match string (regular expressions not supported)
        /// is specified (using LbHttpMonitor.response_body) then the
        /// healthcheck HTTP response body is matched against the specified string
        /// and server is considered healthy only if there is a match.
        /// If the response body string is not specified, HTTP healthcheck is
        /// considered successful if the HTTP response status code is 2xx, but it
        /// can be configured to accept other status codes as successful.
        /// </summary>
        [JsonProperty(PropertyName = "response_body")]
        public string? ResponseBody { get; set; }
        /// <summary>
        /// supported SSL cipher list to servers
        /// </summary>
        [JsonProperty(PropertyName = "ciphers")]
        public IList<string> Ciphers { get; set; }
        /// <summary>
        /// Array of HTTP request headers
        /// </summary>
        [JsonProperty(PropertyName = "request_headers")]
        public IList<NSXTLbHttpRequestHeaderType> RequestHeaders { get; set; }
        /// <summary>
        /// client certificate can be specified to support client authentication.
        /// </summary>
        [JsonProperty(PropertyName = "client_certificate_id")]
        public string? ClientCertificateId { get; set; }
        /// <summary>
        /// the health check method for HTTP monitor type
        /// </summary>
        [JsonProperty(PropertyName = "request_method")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbHttpsMonitorRequestMethodEnumType? RequestMethod { get; set; }
        /// <summary>
        /// This flag is set to true when all the ciphers and protocols are FIPS
        /// compliant. It is set to false when one of the ciphers or protocols are
        /// not FIPS compliant..
        /// </summary>
        [JsonProperty(PropertyName = "is_fips")]
        public bool? IsFips { get; set; }
        /// <summary>
        /// authentication depth is used to set the verification depth in the server
        /// certificates chain.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_chain_depth")]
        public long? CertificateChainDepth { get; set; }
        /// <summary>
        /// This flag is set to true when all the ciphers and protocols are secure.
        /// It is set to false when one of the ciphers or protocols is insecure.
        /// </summary>
        [JsonProperty(PropertyName = "is_secure")]
        public bool? IsSecure { get; set; }
        /// <summary>
        /// URL used for HTTP monitor
        /// </summary>
        [JsonProperty(PropertyName = "request_url")]
        public string? RequestUrl { get; set; }
        /// <summary>
        /// It is a label of cipher group which is mostly consumed by GUI.
        /// </summary>
        [JsonProperty(PropertyName = "cipher_group_label")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbHttpsMonitorCipherGroupLabelEnumType? CipherGroupLabel { get; set; }
        /// <summary>
        /// HTTP request version
        /// </summary>
        [JsonProperty(PropertyName = "request_version")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLbHttpsMonitorRequestVersionEnumType? RequestVersion { get; set; }
        /// <summary>
        /// SSL versions TLS1.1 and TLS1.2 are supported and enabled by default.
        /// SSLv2, SSLv3, and TLS1.0 are supported, but disabled by default.
        /// </summary>
        [JsonProperty(PropertyName = "protocols")]
        public IList<string> Protocols { get; set; }
    }
}
