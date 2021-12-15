// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// The Operational status of the logical port
    /// </summary>
    [NSXTProperty(Description: @"The Operational status of the logical port")]
    public enum NSXTLogicalPortOperationalStatusStatusEnumType
    {
        [EnumMember(Value = "UP")]
        UP = 1,
        [EnumMember(Value = "DOWN")]
        DOWN = 2,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 3,
    }
}
