// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Route type
    /// </summary>
    [NSXTProperty(Description: @"Route type")]
    public enum NSXTNodeRoutePropertiesRouteTypeEnumType
    {
        [EnumMember(Value = "DEFAULT")]
        Default = 1,
        [EnumMember(Value = "STATIC")]
        Static = 2,
        [EnumMember(Value = "BLACKHOLE")]
        Blackhole = 3,
        [EnumMember(Value = "PROHIBIT")]
        Prohibit = 4,
        [EnumMember(Value = "THROW")]
        Throw = 5,
        [EnumMember(Value = "UNREACHABLE")]
        Unreachable = 6,
    }
}
