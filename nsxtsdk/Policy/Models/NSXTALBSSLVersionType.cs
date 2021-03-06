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
    /// Advanced load balancer SSLVersion object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SSLVersion object")]
    public class NSXTALBSSLVersionType 
    {
        /// <summary>
        /// Enum options - SSL_VERSION_SSLV3, SSL_VERSION_TLS1,
        /// SSL_VERSION_TLS1_1, SSL_VERSION_TLS1_2, SSL_VERSION_TLS1_3.
        /// Allowed in Basic(Allowed values-
        /// SSL_VERSION_SSLV3,SSL_VERSION_TLS1,SSL_VERSION_TLS1_1,SSL_VERSION_TLS1_2)
        /// edition, Essentials(Allowed values-
        /// SSL_VERSION_SSLV3,SSL_VERSION_TLS1,SSL_VERSION_TLS1_1,SSL_VERSION_TLS1_2)
        /// edition, Enterprise edition.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as SSL_VERSION_TLS1_1.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbsslversionTypeEnumType Type { get; set; }
    }
}
