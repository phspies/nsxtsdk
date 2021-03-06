// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// High Availability status of a service router on the edge node.
    /// </summary>
    [NSXTProperty(Description: @"High Availability status of a service router on the edge node.")]
    public enum NSXTL2ForwarderStatusPerNodeHighAvailabilityStatusEnumType
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
