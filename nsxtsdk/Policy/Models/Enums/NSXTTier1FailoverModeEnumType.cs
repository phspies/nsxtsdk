// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Determines the behavior when a Tier-1 instance restarts after afailure. If set to PREEMPTIVE, the preferred node will take over,even if it causes another failure. If set to NON_PREEMPTIVE,then the instance that restarted will remain secondary.Only applicable when edge cluster is configured in Tier1locale-service.
    /// </summary>
    [NSXTProperty(Description: @"Determines the behavior when a Tier-1 instance restarts after afailure. If set to PREEMPTIVE, the preferred node will take over,even if it causes another failure. If set to NON_PREEMPTIVE,then the instance that restarted will remain secondary.Only applicable when edge cluster is configured in Tier1locale-service.")]
    public enum NSXTTier1FailoverModeEnumType
    {
        [EnumMember(Value = "PREEMPTIVE")]
        PREEMPTIVE = 1,
        [EnumMember(Value = "NON_PREEMPTIVE")]
        NONPREEMPTIVE = 0,
    }
}
