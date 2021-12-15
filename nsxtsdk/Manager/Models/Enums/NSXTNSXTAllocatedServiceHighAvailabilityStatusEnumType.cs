// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Represents the active or the standby state of the service.
    /// </summary>
    [NSXTProperty(Description: @"Represents the active or the standby state of the service.")]
    public enum NSXTAllocatedServiceHighAvailabilityStatusEnumType
    {
        [EnumMember(Value = "ACTIVE")]
        ACTIVE = 1,
        [EnumMember(Value = "STANDBY")]
        STANDBY = 2,
        [EnumMember(Value = "DOWN")]
        DOWN = 3,
        [EnumMember(Value = "SYNC")]
        SYNC = 4,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 5,
    }
}
