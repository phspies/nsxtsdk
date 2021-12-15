// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Determines the behavior when a logical router instance restarts aftera failure. If set to PREEMPTIVE, the preferred node will take over,even if it causes another failure. If set to NON_PREEMPTIVE, then theinstance that restarted will remain secondary.This property must not be populated unless the high_availability_mode propertyis set to ACTIVE_STANDBY.If high_availability_mode property is set to ACTIVE_STANDBY and this propertyis not specified then default will be NON_PREEMPTIVE.
    /// </summary>
    [NSXTProperty(Description: @"Determines the behavior when a logical router instance restarts aftera failure. If set to PREEMPTIVE, the preferred node will take over,even if it causes another failure. If set to NON_PREEMPTIVE, then theinstance that restarted will remain secondary.This property must not be populated unless the high_availability_mode propertyis set to ACTIVE_STANDBY.If high_availability_mode property is set to ACTIVE_STANDBY and this propertyis not specified then default will be NON_PREEMPTIVE.")]
    public enum NSXTLogicalRouterFailoverModeEnumType
    {
        [EnumMember(Value = "PREEMPTIVE")]
        PREEMPTIVE = 1,
        [EnumMember(Value = "NON_PREEMPTIVE")]
        NONPREEMPTIVE = 2,
    }
}