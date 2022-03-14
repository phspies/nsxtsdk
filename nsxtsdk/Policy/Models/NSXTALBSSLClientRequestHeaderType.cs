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
    /// Advanced load balancer SSLClientRequestHeader object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SSLClientRequestHeader object")]
    public class NSXTALBSSLClientRequestHeaderType 
    {
        /// <summary>
        /// Set the request header with the value as indicated by this
        /// SSL variable.
        /// Eg.
        /// send the whole certificate in PEM format.
        /// Enum options - HTTP_POLICY_VAR_CLIENT_IP,
        /// HTTP_POLICY_VAR_VS_PORT, HTTP_POLICY_VAR_VS_IP,
        /// HTTP_POLICY_VAR_HTTP_HDR,
        /// HTTP_POLICY_VAR_SSL_CLIENT_FINGERPRINT,
        /// HTTP_POLICY_VAR_SSL_CLIENT_SERIAL,
        /// HTTP_POLICY_VAR_SSL_CLIENT_ISSUER,
        /// HTTP_POLICY_VAR_SSL_CLIENT_SUBJECT,
        /// HTTP_POLICY_VAR_SSL_CLIENT_RAW,
        /// HTTP_POLICY_VAR_SSL_PROTOCOL,
        /// HTTP_POLICY_VAR_SSL_SERVER_NAME, HTTP_POLICY_VAR_USER_NAME,
        /// HTTP_POLICY_VAR_SSL_CIPHER, HTTP_POLICY_VAR_REQUEST_ID,
        /// HTTP_POLICY_VAR_SSL_CLIENT_VERSION,
        /// HTTP_POLICY_VAR_SSL_CLIENT_SIGALG,
        /// HTTP_POLICY_VAR_SSL_CLIENT_NOTVALIDBEFORE,
        /// HTTP_POLICY_VAR_SSL_CLIENT_NOTVALIDAFTER.
        /// </summary>
        public NSXTAlbsslclientRequestHeaderRequestHeaderValueEnumType? RequestHeaderValue { get; set; }
        /// <summary>
        /// If this header exists, reset the connection.
        /// If the ssl variable is specified, add a header with this
        /// value.
        /// </summary>
        public string? RequestHeader { get; set; }
    }
}
