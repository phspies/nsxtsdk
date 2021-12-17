// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// If enforced and if TLS protocol Client/Server Hello has none of thepermitted TLS versions or ciphers then the connection is immediately terminated.
    /// </summary>
    [NSXTProperty(Description: @"If enforced and if TLS protocol Client/Server Hello has none of thepermitted TLS versions or ciphers then the connection is immediately terminated.")]
    public enum NSXTTlsInspectionInternalProfileCryptoEnforcementEnumType
    {
        [EnumMember(Value = "ENFORCE")]
        ENFORCE = 1,
        [EnumMember(Value = "TRANSPARENT")]
        TRANSPARENT = 2,
    }
}
