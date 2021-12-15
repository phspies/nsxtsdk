// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Log level for internet key exchange (IKE).
    /// </summary>
    [NSXTProperty(Description: @"Log level for internet key exchange (IKE).")]
    public enum NSXTIpsecVpnServiceIkeLogLevelEnumType
    {
        [EnumMember(Value = "DEBUG")]
        DEBUG = 1,
        [EnumMember(Value = "INFO")]
        INFO = 0,
        [EnumMember(Value = "WARN")]
        WARN = 1,
        [EnumMember(Value = "ERROR")]
        ERROR = 2,
        [EnumMember(Value = "EMERGENCY")]
        EMERGENCY = 3,
    }
}
