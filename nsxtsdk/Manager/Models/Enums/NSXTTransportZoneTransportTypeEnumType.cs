// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// The transport type of this transport zone.
    /// </summary>
    [NSXTProperty(Description: @"The transport type of this transport zone.")]
    public enum NSXTTransportZoneTransportTypeEnumType
    {
        [EnumMember(Value = "OVERLAY")]
        OVERLAY = 1,
        [EnumMember(Value = "VLAN")]
        VLAN = 2,
    }
}
