// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Action to take when TLS handshake fails.
    /// </summary>
    [NSXTProperty(Description: @"Action to take when TLS handshake fails.")]
    public enum NSXTTlsInspectionExternalProfileDecryptionFailActionEnumType
    {
        [EnumMember(Value = "BLOCK")]
        BLOCK = 1,
        [EnumMember(Value = "BYPASS")]
        BYPASS = 0,
    }
}