// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Enum options - SSL_CERTIFICATE_TYPE_VIRTUALSERVICE,SSL_CERTIFICATE_TYPE_SYSTEM, SSL_CERTIFICATE_TYPE_CA.
    /// </summary>
    [NSXTProperty(Description: @"Enum options - SSL_CERTIFICATE_TYPE_VIRTUALSERVICE,SSL_CERTIFICATE_TYPE_SYSTEM, SSL_CERTIFICATE_TYPE_CA.")]
    public enum NSXTAlbsslkeyAndCertificateTypeEnumType
    {
        [EnumMember(Value = "SSL_CERTIFICATE_TYPE_VIRTUALSERVICE")]
        SSLCERTIFICATETYPEVIRTUALSERVICE = 1,
        [EnumMember(Value = "SSL_CERTIFICATE_TYPE_SYSTEM")]
        SSLCERTIFICATETYPESYSTEM = 2,
        [EnumMember(Value = "SSL_CERTIFICATE_TYPE_CA")]
        SSLCERTIFICATETYPECA = 3,
    }
}
