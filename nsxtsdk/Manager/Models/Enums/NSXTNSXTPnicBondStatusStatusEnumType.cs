// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Status of pNIC/bond
    /// </summary>
    [NSXTProperty(Description: @"Status of pNIC/bond")]
    public enum NSXTPnicBondStatusStatusEnumType
    {
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 1,
        [EnumMember(Value = "UP")]
        UP = 2,
        [EnumMember(Value = "DOWN")]
        DOWN = 3,
        [EnumMember(Value = "DEGRADED")]
        DEGRADED = 4,
    }
}
