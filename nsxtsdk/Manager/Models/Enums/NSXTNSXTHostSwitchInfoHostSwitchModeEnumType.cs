// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Mode of host switch
    /// </summary>
    [NSXTProperty(Description: @"Mode of host switch")]
    public enum NSXTHostSwitchInfoHostSwitchModeEnumType
    {
        [EnumMember(Value = "STANDARD")]
        STANDARD = 1,
        [EnumMember(Value = "ENS")]
        ENS = 2,
        [EnumMember(Value = "ENS_INTERRUPT")]
        ENSINTERRUPT = 3,
    }
}