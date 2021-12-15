// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Gives session status consolidated using IKE status and tunnel status. It canbe UP, DOWN, DEGRADED. If IKE and all tunnels are UP status will be UP, ifall down it will be DOWN, otherwise it will be DEGRADED.
    /// </summary>
    [NSXTProperty(Description: @"Gives session status consolidated using IKE status and tunnel status. It canbe UP, DOWN, DEGRADED. If IKE and all tunnels are UP status will be UP, ifall down it will be DOWN, otherwise it will be DEGRADED.")]
    public enum NSXTIpsecVpnSessionStatusNsxTRuntimeStatusEnumType
    {
        [EnumMember(Value = "UP")]
        UP = 1,
        [EnumMember(Value = "DOWN")]
        DOWN = 2,
        [EnumMember(Value = "DEGRADED")]
        DEGRADED = 3,
    }
}