// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Faileover mode can be preemmptive or non-preemptive
    /// </summary>
    [NSXTProperty(Description: @"Faileover mode can be preemmptive or non-preemptive")]
    public enum NSXTBridgeEndpointProfileFailoverModeEnumType
    {
        [EnumMember(Value = "PREEMPTIVE")]
        PREEMPTIVE = 1,
        [EnumMember(Value = "NON_PREEMPTIVE")]
        NONPREEMPTIVE = 2,
    }
}