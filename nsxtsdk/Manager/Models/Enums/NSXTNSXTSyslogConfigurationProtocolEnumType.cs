// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Supported Syslog protocol.
    /// </summary>
    [NSXTProperty(Description: @"Supported Syslog protocol.")]
    public enum NSXTSyslogConfigurationProtocolEnumType
    {
        [EnumMember(Value = "TCP")]
        TCP = 1,
        [EnumMember(Value = "UDP")]
        UDP = 0,
        [EnumMember(Value = "TLS")]
        TLS = 1,
        [EnumMember(Value = "LI")]
        LI = 2,
        [EnumMember(Value = "LI_TLS")]
        LITLS = 3,
    }
}