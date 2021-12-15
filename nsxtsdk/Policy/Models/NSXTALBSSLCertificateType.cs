// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: false, Description: @"subjectAltName that provides additional subject identities.")]
        public IList<string> SubjectAltNames { get; set; }
        /// <summary>
        /// public_key of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "public_key")]
        [NSXTProperty(IsRequired: false, Description: @"public_key of SSLCertificate.")]
        public string? PublicKey { get; set; }
        /// <summary>
        /// Placeholder for description of property self_signed of obj
        /// type SSLCertificate field type str  type boolean.
        /// </summary>
        [JsonProperty(PropertyName = "self_signed")]
        [NSXTProperty(IsRequired: false, Description: @"Placeholder for description of property self_signed of objtype SSLCertificate field type str  type boolean.")]
        public bool? SelfSigned { get; set; }
        /// <summary>
        /// certificate of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        [NSXTProperty(IsRequired: false, Description: @"certificate of SSLCertificate.")]
        public string? Certificate { get; set; }
        /// <summary>
        /// Placeholder for description of property issuer of obj type
        /// SSLCertificate field type str  type ref.
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        [NSXTProperty(IsRequired: false, Description: @"Placeholder for description of property issuer of obj typeSSLCertificate field type str  type ref.")]
        public NSXTALBSSLCertificateDescriptionType Issuer { get; set; }
        /// <summary>
        /// certificate_signing_request of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "certificate_signing_request")]
        [NSXTProperty(IsRequired: false, Description: @"certificate_signing_request of SSLCertificate.")]
        public string? CertificateSigningRequest { get; set; }
        /// <summary>
        /// not_after of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "not_after")]
        [NSXTProperty(IsRequired: false, Description: @"not_after of SSLCertificate.")]
        public string? NotAfter { get; set; }
        /// <summary>
        /// signature_algorithm of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "signature_algorithm")]
        [NSXTProperty(IsRequired: false, Description: @"signature_algorithm of SSLCertificate.")]
        public string? SignatureAlgorithm { get; set; }
        /// <summary>
        /// Enum options - SSL_CERTIFICATE_GOOD,
        /// SSL_CERTIFICATE_EXPIRY_WARNING, SSL_CERTIFICATE_EXPIRED.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as SSL_CERTIFICATE_GOOD.
        /// </summary>
        [JsonProperty(PropertyName = "expiry_status")]
        [NSXTProperty(IsRequired: false, Description: @"Enum options - SSL_CERTIFICATE_GOOD,SSL_CERTIFICATE_EXPIRY_WARNING, SSL_CERTIFICATE_EXPIRED.Default value when not specified in API or module isinterpreted by ALB Controller as SSL_CERTIFICATE_GOOD.")]
        [NSXTDefaultProperty(Default: "SSL_CERTIFICATE_GOOD")]
        public NSXTAlbsslcertificateExpiryStatusEnumType? ExpiryStatus { get; set; }
        /// <summary>
        /// Placeholder for description of property chain_verified of
        /// obj type SSLCertificate field type str  type boolean.
        /// </summary>
        [JsonProperty(PropertyName = "chain_verified")]
        [NSXTProperty(IsRequired: false, Description: @"Placeholder for description of property chain_verified ofobj type SSLCertificate field type str  type boolean.")]
        public bool? ChainVerified { get; set; }
        /// <summary>
        /// version of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        [NSXTProperty(IsRequired: false, Description: @"version of SSLCertificate.")]
        public string? Version { get; set; }
        /// <summary>
        /// text of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        [NSXTProperty(IsRequired: false, Description: @"text of SSLCertificate.")]
        public string? Text { get; set; }
        /// <summary>
        /// fingerprint of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "fingerprint")]
        [NSXTProperty(IsRequired: false, Description: @"fingerprint of SSLCertificate.")]
        public string? Fingerprint { get; set; }
        /// <summary>
        /// Placeholder for description of property key_params of obj
        /// type SSLCertificate field type str  type ref.
        /// </summary>
        [JsonProperty(PropertyName = "key_params")]
        [NSXTProperty(IsRequired: false, Description: @"Placeholder for description of property key_params of objtype SSLCertificate field type str  type ref.")]
        public NSXTALBSSLKeyParamsType KeyParams { get; set; }
        /// <summary>
        /// serial_number of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "serial_number")]
        [NSXTProperty(IsRequired: false, Description: @"serial_number of SSLCertificate.")]
        public string? SerialNumber { get; set; }
        /// <summary>
        /// Number of days_until_expire.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 365.
        /// </summary>
        [JsonProperty(PropertyName = "days_until_expire")]
        [NSXTProperty(IsRequired: false, Description: @"Number of days_until_expire.Default value when not specified in API or module isinterpreted by ALB Controller as 365.")]
        [NSXTDefaultProperty(Default: "")]
        public long? DaysUntilExpire { get; set; }
        /// <summary>
        /// signature of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "signature")]
        [NSXTProperty(IsRequired: false, Description: @"signature of SSLCertificate.")]
        public string? Signature { get; set; }
        /// <summary>
        /// not_before of SSLCertificate.
        /// </summary>
        [JsonProperty(PropertyName = "not_before")]
        [NSXTProperty(IsRequired: false, Description: @"not_before of SSLCertificate.")]
        public string? NotBefore { get; set; }
        /// <summary>
        /// Placeholder for description of property subject of obj type
        /// SSLCertificate field type str  type ref.
        /// </summary>
        [JsonProperty(PropertyName = "subject")]
        [NSXTProperty(IsRequired: false, Description: @"Placeholder for description of property subject of obj typeSSLCertificate field type str  type ref.")]
        public NSXTALBSSLCertificateDescriptionType Subject { get; set; }
    }
}
