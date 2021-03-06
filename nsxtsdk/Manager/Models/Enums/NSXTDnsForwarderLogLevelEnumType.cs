// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Log level of the DNS forwarder
    /// </summary>
    [NSXTProperty(Description: @"Log level of the DNS forwarder")]
    public enum NSXTDnsForwarderLogLevelEnumType
    {
        [EnumMember(Value = "DEBUG")]
        DEBUG = 1,
        [EnumMember(Value = "INFO")]
        INFO = 0,
        [EnumMember(Value = "WARNING")]
        WARNING = 1,
        [EnumMember(Value = "ERROR")]
        ERROR = 2,
        [EnumMember(Value = "FATAL")]
        FATAL = 3,
    }
}
