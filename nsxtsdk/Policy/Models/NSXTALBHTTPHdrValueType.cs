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
    /// Advanced load balancer HTTPHdrValue object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPHdrValue object")]
    public class NSXTALBHTTPHdrValueType 
    {
        /// <summary>
        /// Variable.
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
        [JsonProperty(PropertyName = "var")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbhttphdrValueVarEnumType? Var { get; set; }
        /// <summary>
        /// HTTP header value or variable representing an HTTP header.
        /// </summary>
        [JsonProperty(PropertyName = "val")]
        public string? Val { get; set; }
    }
}
