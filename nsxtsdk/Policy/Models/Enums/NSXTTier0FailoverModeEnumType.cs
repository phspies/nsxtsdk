// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Determines the behavior when a Tier-0 instance in ACTIVE-STANDBYhigh-availability mode restarts after a failure. If set toPREEMPTIVE, the preferred node will take over, even if it causesanother failure. If set to NON_PREEMPTIVE, then the instance thatrestarted will remain secondary. This property is not used whenthe ha_mode property is set to ACTIVE_ACTIVE.Only applicable when edge cluster is configured in Tier0locale-service.
    /// </summary>
    [NSXTProperty(Description: @"Determines the behavior when a Tier-0 instance in ACTIVE-STANDBYhigh-availability mode restarts after a failure. If set toPREEMPTIVE, the preferred node will take over, even if it causesanother failure. If set to NON_PREEMPTIVE, then the instance thatrestarted will remain secondary. This property is not used whenthe ha_mode property is set to ACTIVE_ACTIVE.Only applicable when edge cluster is configured in Tier0locale-service.")]
    public enum NSXTTier0FailoverModeEnumType
    {
        [EnumMember(Value = "PREEMPTIVE")]
        PREEMPTIVE = 1,
        [EnumMember(Value = "NON_PREEMPTIVE")]
        NONPREEMPTIVE = 0,
    }
}
