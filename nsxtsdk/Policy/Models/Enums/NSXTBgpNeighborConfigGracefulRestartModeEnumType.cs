// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// If mode is DISABLE, then graceful restart and helper modes are disabled.If mode is GR_AND_HELPER, then both graceful restart and helper modes are enabled.If mode is HELPER_ONLY, then helper mode is enabled.HELPER_ONLY mode is the ability for a BGP speaker to indicate its abilityto preserve forwarding state during BGP restart.GRACEFUL_RESTART mode is the ability of a BGP speaker to advertise its restartto its peers.
    /// </summary>
    [NSXTProperty(Description: @"If mode is DISABLE, then graceful restart and helper modes are disabled.If mode is GR_AND_HELPER, then both graceful restart and helper modes are enabled.If mode is HELPER_ONLY, then helper mode is enabled.HELPER_ONLY mode is the ability for a BGP speaker to indicate its abilityto preserve forwarding state during BGP restart.GRACEFUL_RESTART mode is the ability of a BGP speaker to advertise its restartto its peers.")]
    public enum NSXTBgpNeighborConfigGracefulRestartModeEnumType
    {
        [EnumMember(Value = "DISABLE")]
        DISABLE = 1,
        [EnumMember(Value = "GR_AND_HELPER")]
        GRANDHELPER = 2,
        [EnumMember(Value = "HELPER_ONLY")]
        HELPERONLY = 3,
    }
}