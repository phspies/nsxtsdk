// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Day of week on which data will be collected. Specify one of SUNDAY through SATURDAY.
    /// </summary>
    [NSXTProperty(Description: @"Day of week on which data will be collected. Specify one of SUNDAY through SATURDAY.")]
    public enum NSXTWeeklyTelemetryScheduleDayOfWeekEnumType
    {
        [EnumMember(Value = "SUNDAY")]
        SUNDAY = 1,
        [EnumMember(Value = "MONDAY")]
        MONDAY = 2,
        [EnumMember(Value = "TUESDAY")]
        TUESDAY = 3,
        [EnumMember(Value = "WEDNESDAY")]
        WEDNESDAY = 4,
        [EnumMember(Value = "THURSDAY")]
        THURSDAY = 5,
        [EnumMember(Value = "FRIDAY")]
        FRIDAY = 6,
        [EnumMember(Value = "SATURDAY")]
        SATURDAY = 7,
    }
}
