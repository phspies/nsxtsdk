// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Current running state of the directory domain in synchronization life cycle. It could be one of the following five states. SELECTIVE_FULL_SYNC and SELECTIVE_DELTA_SYNC are sync states for selective sync.
    /// </summary>
    [NSXTProperty(Description: @"Current running state of the directory domain in synchronization life cycle. It could be one of the following five states. SELECTIVE_FULL_SYNC and SELECTIVE_DELTA_SYNC are sync states for selective sync.")]
    public enum NSXTDirectoryDomainSyncStatsCurrentStateEnumType
    {
        [EnumMember(Value = "IDLE")]
        IDLE = 1,
        [EnumMember(Value = "FULL_SYNC")]
        FULLSYNC = 2,
        [EnumMember(Value = "DELTA_SYNC")]
        DELTASYNC = 3,
        [EnumMember(Value = "SELECTIVE_FULL_SYNC")]
        SELECTIVEFULLSYNC = 4,
        [EnumMember(Value = "SELECTIVE_DELTA_SYNC")]
        SELECTIVEDELTASYNC = 5,
    }
}
