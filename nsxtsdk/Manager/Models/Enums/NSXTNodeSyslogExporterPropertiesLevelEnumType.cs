// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Logging level to export
    /// </summary>
    [NSXTProperty(Description: @"Logging level to export")]
    public enum NSXTNodeSyslogExporterPropertiesLevelEnumType
    {
        [EnumMember(Value = "EMERG")]
        EMERG = 1,
        [EnumMember(Value = "ALERT")]
        ALERT = 2,
        [EnumMember(Value = "CRIT")]
        CRIT = 3,
        [EnumMember(Value = "ERR")]
        ERR = 4,
        [EnumMember(Value = "WARNING")]
        WARNING = 5,
        [EnumMember(Value = "NOTICE")]
        NOTICE = 6,
        [EnumMember(Value = "INFO")]
        INFO = 7,
        [EnumMember(Value = "DEBUG")]
        DEBUG = 8,
    }
}
