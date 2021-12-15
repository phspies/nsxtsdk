// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// STANDARD mode applies to all the hypervisors. ENS mode stands for Enhanced Networking Stack. This feature is only available for ESX hypervisor. It is not available on KVM, EDGE and Public Cloud Gateway etc. When a Transport Zone mode is set to ENS, only Transport Nodes of type ESX can participate in such a Transport Zone.
    /// </summary>
    [NSXTProperty(Description: @"STANDARD mode applies to all the hypervisors. ENS mode stands for Enhanced Networking Stack. This feature is only available for ESX hypervisor. It is not available on KVM, EDGE and Public Cloud Gateway etc. When a Transport Zone mode is set to ENS, only Transport Nodes of type ESX can participate in such a Transport Zone.")]
    public enum NSXTTransportZoneHostSwitchModeEnumType
    {
        [EnumMember(Value = "STANDARD")]
        STANDARD = 1,
        [EnumMember(Value = "ENS")]
        ENS = 2,
    }
}
