// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Status of migration unit
    /// </summary>
    [NSXTProperty(Description: @"Status of migration unit")]
    public enum NSXTMigrationUnitAggregateInfoStatusEnumType
    {
        [EnumMember(Value = "SUCCESS")]
        SUCCESS = 1,
        [EnumMember(Value = "FAILED")]
        FAILED = 2,
        [EnumMember(Value = "IN_PROGRESS")]
        INPROGRESS = 3,
        [EnumMember(Value = "NOT_STARTED")]
        NOTSTARTED = 4,
        [EnumMember(Value = "PAUSING")]
        PAUSING = 5,
        [EnumMember(Value = "PAUSED")]
        PAUSED = 6,
    }
}
