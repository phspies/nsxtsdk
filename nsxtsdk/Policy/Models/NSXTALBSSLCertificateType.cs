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
    /// Advanced load balancer SSLCertificate object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SSLCertificate object")]
    public class NSXTALBSSLCertificateType 
    {
        /// <summary>
        /// subjectAltName that provides additional subject identities.
        /// </summary>
        [JsonProperty(PropertyName = "subject_alt_names")]
        public IList<string> SubjectAltNames { get; set; }
        /// <summary>
        /// public_key of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "public_key")]
        public string? PublicKey { get; set; }
        /// <summary>
        /// Placeholder for description of property self_signed of obj
        /// type SSLCertificate field type str  type boolean.
        /// </summary>
        [JsonProperty(PropertyName = "self_signed")]
        public bool? SelfSigned { get; set; }
        /// <summary>
        /// certificate of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public string? Certificate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        public NSXTALBSSLCertificateDescriptionType Issuer { get; set; }
        /// <summary>
        /// certificate_signing_request of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_signing_request")]
        public string? CertificateSigningRequest { get; set; }
        /// <summary>
        /// not_after of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "not_after")]
        public string? NotAfter { get; set; }
        /// <summary>
        /// signature_algorithm of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "signature_algorithm")]
        public string? SignatureAlgorithm { get; set; }
        /// <summary>
        /// Enum options - SSL_CERTIFICATE_GOOD,
        /// SSL_CERTIFICATE_EXPIRY_WARNING, SSL_CERTIFICATE_EXPIRED.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as SSL_CERTIFICATE_GOOD.
        /// </summary>
        [JsonProperty(PropertyName = "expiry_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbsslcertificateExpiryStatusEnumType? ExpiryStatus { get; set; }
        /// <summary>
        /// Placeholder for description of property chain_verified of
        /// obj type SSLCertificate field type str  type boolean.
        /// </summary>
        [JsonProperty(PropertyName = "chain_verified")]
        public bool? ChainVerified { get; set; }
        /// <summary>
        /// version of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
        /// <summary>
        /// text of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string? Text { get; set; }
        /// <summary>
        /// fingerprint of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "fingerprint")]
        public string? Fingerprint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "key_params")]
        public NSXTALBSSLKeyParamsType KeyParams { get; set; }
        /// <summary>
        /// serial_number of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "serial_number")]
        public string? SerialNumber { get; set; }
        /// <summary>
        /// Number of days_until_expire.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 365.
        /// </summary>
        [JsonProperty(PropertyName = "days_until_expire")]
        public long? DaysUntilExpire { get; set; }
        /// <summary>
        /// signature of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "signature")]
        public string? Signature { get; set; }
        /// <summary>
        /// not_before of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "not_before")]
        public string? NotBefore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        public NSXTALBSSLCertificateDescriptionType Subject { get; set; }
    }
}
