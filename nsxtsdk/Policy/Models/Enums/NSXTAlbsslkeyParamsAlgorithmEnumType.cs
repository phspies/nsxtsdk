// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Enum options - SSL_KEY_ALGORITHM_RSA, SSL_KEY_ALGORITHM_EC.Default value when not specified in API or module isinterpreted by ALB Controller as SSL_KEY_ALGORITHM_RSA.
    /// </summary>
    [NSXTProperty(Description: @"Enum options - SSL_KEY_ALGORITHM_RSA, SSL_KEY_ALGORITHM_EC.Default value when not specified in API or module isinterpreted by ALB Controller as SSL_KEY_ALGORITHM_RSA.")]
    public enum NSXTAlbsslkeyParamsAlgorithmEnumType
    {
        [EnumMember(Value = "SSL_KEY_ALGORITHM_RSA")]
        SSLKEYALGORITHMRSA = 1,
        [EnumMember(Value = "SSL_KEY_ALGORITHM_EC")]
        SSLKEYALGORITHMEC = 2,
    }
}