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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTInfraSecurityConfigType : NSXTManagedResourceType
    {
        /// <summary>
        /// When this flag is set to true, during certificate checking the Extended Key Usage extension is expected to be present,
        /// indicating whether the certificate is to be used a client certificate or server certificate. Setting this value to false
        /// is not recommended as it leads to lower security and operational risk.
        /// </summary>
        [JsonProperty(PropertyName = "eku_checking_enabled")]
        public bool? EkuCheckingEnabled { get; set; }
        /// <summary>
        /// When this flag is set to true (for NDcPP compliance) only ca-signed certificates will be allowed to be applied as server
        /// certificates.
        /// </summary>
        [JsonProperty(PropertyName = "ca_signed_only")]
        public bool? CaSignedOnly { get; set; }
        /// <summary>
        /// When this flag is set to true, during certificate checking the CRL is fetched and checked whether the certificate is
        /// revoked or not.  Setting this property to false results in lower security.  It is not advisible to import certificate
        /// without CRL info while CRL checking is disabled, and then re-enable CRL checking.
        /// </summary>
        [JsonProperty(PropertyName = "crl_checking_enabled")]
        public bool? CrlCheckingEnabled { get; set; }
    }
}
