// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Owner virtual machine type; Edge, Service VM or other.
    /// </summary>
    [NSXTProperty(Description: @"Owner virtual machine type; Edge, Service VM or other.")]
    public enum NSXTVirtualNetworkInterfaceOwnerVmTypeEnumType
    {
        [EnumMember(Value = "EDGE")]
        EDGE = 1,
        [EnumMember(Value = "SERVICE")]
        SERVICE = 2,
        [EnumMember(Value = "REGULAR")]
        REGULAR = 3,
    }
}