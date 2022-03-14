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
    /// Advanced load balancer SSLCertificate object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SSLCertificate object")]
    public class NSXTALBSSLCertificateType 
    {
        /// <summary>
        /// subjectAltName that provides additional subject identities.
        /// </summary>
        public IList<string> SubjectAltNames { get; set; }
        /// <summary>
        /// public_key of SSLCertificate.
        /// </summary>
        public string? PublicKey { get; set; }
        /// <summary>
        /// Placeholder for description of property self_signed of obj
        /// type SSLCertificate field type str  type boolean.
        /// </summary>
        public bool? SelfSigned { get; set; }
        /// <summary>
        /// certificate of SSLCertificate.
        /// </summary>
        public string? Certificate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTALBSSLCertificateDescriptionType Issuer { get; set; }
        /// <summary>
        /// certificate_signing_request of SSLCertificate.
        /// </summary>
        public string? CertificateSigningRequest { get; set; }
        /// <summary>
        /// not_after of SSLCertificate.
        /// </summary>
        public string? NotAfter { get; set; }
        /// <summary>
        /// signature_algorithm of SSLCertificate.
        /// </summary>
        public string? SignatureAlgorithm { get; set; }
        /// <summary>
        /// Enum options - SSL_CERTIFICATE_GOOD,
        /// SSL_CERTIFICATE_EXPIRY_WARNING, SSL_CERTIFICATE_EXPIRED.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as SSL_CERTIFICATE_GOOD.
        /// </summary>
        public NSXTAlbsslcertificateExpiryStatusEnumType? ExpiryStatus { get; set; }
        /// <summary>
        /// Placeholder for description of property chain_verified of
        /// obj type SSLCertificate field type str  type boolean.
        /// </summary>
        public bool? ChainVerified { get; set; }
        /// <summary>
        /// version of SSLCertificate.
        /// </summary>
        public string? Version { get; set; }
        /// <summary>
        /// text of SSLCertificate.
        /// </summary>
        public string? Text { get; set; }
        /// <summary>
        /// fingerprint of SSLCertificate.
        /// </summary>
        public string? Fingerprint { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTALBSSLKeyParamsType KeyParams { get; set; }
        /// <summary>
        /// serial_number of SSLCertificate.
        /// </summary>
        public string? SerialNumber { get; set; }
        /// <summary>
        /// Number of days_until_expire.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 365.
        /// </summary>
        public long? DaysUntilExpire { get; set; }
        /// <summary>
        /// signature of SSLCertificate.
        /// </summary>
        public string? Signature { get; set; }
        /// <summary>
        /// not_before of SSLCertificate.
        /// </summary>
        public string? NotBefore { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTALBSSLCertificateDescriptionType Subject { get; set; }
    }
}
