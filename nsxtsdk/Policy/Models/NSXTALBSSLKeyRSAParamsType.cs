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
    /// Advanced load balancer SSLKeyRSAParams object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SSLKeyRSAParams object")]
    public class NSXTALBSSLKeyRSAParamsType 
    {
        /// <summary>
        /// Enum options - SSL_KEY_1024_BITS, SSL_KEY_2048_BITS,
        /// SSL_KEY_3072_BITS, SSL_KEY_4096_BITS.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as SSL_KEY_2048_BITS.
        /// </summary>
        [JsonProperty(PropertyName = "key_size")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbsslkeyRsaparamsKeySizeEnumType? KeySize { get; set; }
        /// <summary>
        /// Number of exponent.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 65537.
        /// </summary>
        [JsonProperty(PropertyName = "exponent")]
        public long? Exponent { get; set; }
    }
}
