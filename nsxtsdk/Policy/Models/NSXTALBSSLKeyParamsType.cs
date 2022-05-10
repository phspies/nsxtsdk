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
    /// Advanced load balancer SSLKeyParams object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SSLKeyParams object")]
    public class NSXTALBSSLKeyParamsType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ec_params")]
        public NSXTALBSSLKeyECParamsType EcParams { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rsa_params")]
        public NSXTALBSSLKeyRSAParamsType RsaParams { get; set; }
        /// <summary>
        /// Enum options - SSL_KEY_ALGORITHM_RSA, SSL_KEY_ALGORITHM_EC.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as SSL_KEY_ALGORITHM_RSA.
        /// </summary>
        [JsonProperty(PropertyName = "algorithm", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbsslkeyParamsAlgorithmEnumType Algorithm { get; set; }
    }
}
