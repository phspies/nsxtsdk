// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Service logging level
    /// </summary>
    [NSXTProperty(Description: @"Service logging level")]
    public enum NSXTLoggingServicePropertiesLoggingLevelEnumType
    {
        [EnumMember(Value = "OFF")]
        OFF = 1,
        [EnumMember(Value = "FATAL")]
        FATAL = 2,
        [EnumMember(Value = "ERROR")]
        ERROR = 3,
        [EnumMember(Value = "WARN")]
        WARN = 4,
        [EnumMember(Value = "INFO")]
        INFO = 5,
        [EnumMember(Value = "DEBUG")]
        DEBUG = 6,
        [EnumMember(Value = "TRACE")]
        TRACE = 7,
    }
}
