// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Status of pre/post-upgrade check
    /// </summary>
    [NSXTProperty(Description: @"Status of pre/post-upgrade check")]
    public enum NSXTUpgradeCheckStatusEnumType
    {
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 1,
        [EnumMember(Value = "FAILURE")]
        FAILURE = 2,
        [EnumMember(Value = "WARNING")]
        WARNING = 3,
    }
}
