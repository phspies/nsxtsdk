// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Server&apos;s minimum TLS version to enforce. Required if CryptoEnforcement is ENFORCE. Supported versions are TLS1.1 and TLS1.2.
    /// </summary>
    [NSXTProperty(Description: @"Server&apos;s minimum TLS version to enforce. Required if CryptoEnforcement is ENFORCE. Supported versions are TLS1.1 and TLS1.2.")]
    public enum NSXTTlsInspectionExternalProfileServerMinTlsVersionEnumType
    {
        [EnumMember(Value = "TLS_V1_2")]
        TLSV12 = 1,
        [EnumMember(Value = "TLS_V1_1")]
        TLSV11 = 0,
        [EnumMember(Value = "TLS_V1_0")]
        TLSV10 = 1,
    }
}
