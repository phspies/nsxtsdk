// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Gives session status consolidated using IKE status and tunnel status. It can be UP, DOWN, DEGRADED. If IKE and all tunnels are UP status will be UP, if all down it will be DOWN, otherwise it will be DEGRADED.
    /// </summary>
    [NSXTProperty(Description: @"Gives session status consolidated using IKE status and tunnel status. It can be UP, DOWN, DEGRADED. If IKE and all tunnels are UP status will be UP, if all down it will be DOWN, otherwise it will be DEGRADED.")]
    public enum NSXTIpsecVpnsessionStatusSessionStatusEnumType
    {
        [EnumMember(Value = "UP")]
        UP = 1,
        [EnumMember(Value = "DOWN")]
        DOWN = 2,
        [EnumMember(Value = "DEGRADED")]
        DEGRADED = 3,
    }
}