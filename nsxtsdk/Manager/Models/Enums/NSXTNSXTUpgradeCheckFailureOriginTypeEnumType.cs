// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Type of origin of pre/post-upgrade check failure
    /// </summary>
    [NSXTProperty(Description: @"Type of origin of pre/post-upgrade check failure")]
    public enum NSXTUpgradeCheckFailureOriginTypeEnumType
    {
        [EnumMember(Value = "COMPONENT")]
        COMPONENT = 1,
        [EnumMember(Value = "UPGRADE_UNIT")]
        UPGRADEUNIT = 2,
    }
}
