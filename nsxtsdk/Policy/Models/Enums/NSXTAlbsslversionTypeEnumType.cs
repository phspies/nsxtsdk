// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Enum options - SSL_VERSION_SSLV3, SSL_VERSION_TLS1,SSL_VERSION_TLS1_1, SSL_VERSION_TLS1_2, SSL_VERSION_TLS1_3.Allowed in Basic(Allowed values-SSL_VERSION_SSLV3,SSL_VERSION_TLS1,SSL_VERSION_TLS1_1,SSL_VERSION_TLS1_2)edition, Essentials(Allowed values-SSL_VERSION_SSLV3,SSL_VERSION_TLS1,SSL_VERSION_TLS1_1,SSL_VERSION_TLS1_2)edition, Enterprise edition.Default value when not specified in API or module isinterpreted by ALB Controller as SSL_VERSION_TLS1_1.
    /// </summary>
    [NSXTProperty(Description: @"Enum options - SSL_VERSION_SSLV3, SSL_VERSION_TLS1,SSL_VERSION_TLS1_1, SSL_VERSION_TLS1_2, SSL_VERSION_TLS1_3.Allowed in Basic(Allowed values-SSL_VERSION_SSLV3,SSL_VERSION_TLS1,SSL_VERSION_TLS1_1,SSL_VERSION_TLS1_2)edition, Essentials(Allowed values-SSL_VERSION_SSLV3,SSL_VERSION_TLS1,SSL_VERSION_TLS1_1,SSL_VERSION_TLS1_2)edition, Enterprise edition.Default value when not specified in API or module isinterpreted by ALB Controller as SSL_VERSION_TLS1_1.")]
    public enum NSXTAlbsslversionTypeEnumType
    {
        [EnumMember(Value = "SSL_VERSION_SSLV3")]
        SSLVERSIONSSLV3 = 1,
        [EnumMember(Value = "SSL_VERSION_TLS1")]
        SSLVERSIONTLS1 = 2,
        [EnumMember(Value = "SSL_VERSION_TLS1_1")]
        SSLVERSIONTLS11 = 0,
        [EnumMember(Value = "SSL_VERSION_TLS1_2")]
        SSLVERSIONTLS12 = 1,
        [EnumMember(Value = "SSL_VERSION_TLS1_3")]
        SSLVERSIONTLS13 = 2,
    }
}
