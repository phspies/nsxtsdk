// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Type of source entity. Currently source value can be resolved to VIF and Virtual Machine.
    /// </summary>
    [NSXTProperty(Description: @"Type of source entity. Currently source value can be resolved to VIF and Virtual Machine.")]
    public enum NSXTSourceEntitySourceEntityTypeEnumType
    {
        [EnumMember(Value = "VIRTUAL_NETWORK_INTERFACE")]
        VIRTUALNETWORKINTERFACE = 1,
        [EnumMember(Value = "VIRTUAL_MACHINE")]
        VIRTUALMACHINE = 2,
    }
}
