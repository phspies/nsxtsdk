// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Overall state of N-VDSes on the TransportNodes
    /// </summary>
    [NSXTProperty(Description: @"Overall state of N-VDSes on the TransportNodes")]
    public enum NSXTNvdsUpgradeHostStateOverallStateEnumType
    {
        [EnumMember(Value = "UPGRADE_READY")]
        UPGRADEREADY = 1,
        [EnumMember(Value = "UPGRADE_PROCESSING")]
        UPGRADEPROCESSING = 2,
        [EnumMember(Value = "UPGRADE_QUEUED")]
        UPGRADEQUEUED = 3,
        [EnumMember(Value = "UPGRADE_IN_PROGRESS")]
        UPGRADEINPROGRESS = 4,
        [EnumMember(Value = "UPGRADE_FAILED")]
        UPGRADEFAILED = 5,
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 6,
    }
}
