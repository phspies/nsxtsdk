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
    /// Advanced load balancer SSLKeyECParams object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SSLKeyECParams object")]
    public class NSXTALBSSLKeyECParamsType 
    {
        /// <summary>
        /// Enum options - SSL_KEY_EC_CURVE_SECP256R1,
        /// SSL_KEY_EC_CURVE_SECP384R1, SSL_KEY_EC_CURVE_SECP521R1.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as SSL_KEY_EC_CURVE_SECP256R1.
        /// </summary>
        [JsonProperty(PropertyName = "curve")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbsslkeyEcparamsCurveEnumType? Curve { get; set; }
    }
}
