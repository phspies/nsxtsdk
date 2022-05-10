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
    public class NSXTTlsCertificateType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Purpose of this certificate. Can be empty or set to "signing-ca".
        /// </summary>
        [JsonProperty(PropertyName = "purpose")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTlsCertificatePurposeEnumType? Purpose { get; set; }
        /// <summary>
        /// Classification of the TlsCertificate helps differentiate how a TlsCertificate could be
        /// used for various components either as a client trust certificate; CERTIFICATE_CA, or
        /// as a server identity certificate; CERTIFICATE_SIGNED,or CERTIFICATE_SELF_SIGNED.
        /// </summary>
        [JsonProperty(PropertyName = "tls_certificate_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTlsCertificateTlsCertificateTypeEnumType? TlsCertificateType { get; set; }
        /// <summary>
        /// list of X509Certificates.
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public IList<NSXTX509CertificateType> Details { get; set; }
        /// <summary>
        /// pem encoded certificate data.
        /// </summary>
        [JsonProperty(PropertyName = "pem_encoded", Required = Required.AllowNull)]
        public string PemEncoded { get; set; }
        /// <summary>
        /// whether we have the private key for this certificate.
        /// </summary>
        [JsonProperty(PropertyName = "has_private_key")]
        public bool? HasPrivateKey { get; set; }
    }
}
