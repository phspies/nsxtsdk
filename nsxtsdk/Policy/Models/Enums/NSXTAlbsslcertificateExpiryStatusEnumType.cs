// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Enum options - SSL_CERTIFICATE_GOOD,SSL_CERTIFICATE_EXPIRY_WARNING, SSL_CERTIFICATE_EXPIRED.Default value when not specified in API or module isinterpreted by ALB Controller as SSL_CERTIFICATE_GOOD.
    /// </summary>
    [NSXTProperty(Description: @"Enum options - SSL_CERTIFICATE_GOOD,SSL_CERTIFICATE_EXPIRY_WARNING, SSL_CERTIFICATE_EXPIRED.Default value when not specified in API or module isinterpreted by ALB Controller as SSL_CERTIFICATE_GOOD.")]
    public enum NSXTAlbsslcertificateExpiryStatusEnumType
    {
        [EnumMember(Value = "SSL_CERTIFICATE_GOOD")]
        SSLCERTIFICATEGOOD = 1,
        [EnumMember(Value = "SSL_CERTIFICATE_EXPIRY_WARNING")]
        SSLCERTIFICATEEXPIRYWARNING = 2,
        [EnumMember(Value = "SSL_CERTIFICATE_EXPIRED")]
        SSLCERTIFICATEEXPIRED = 3,
    }
}
