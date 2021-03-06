// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Assigned Internet Protocol in IP header, TCP, UDP are supported.
    /// </summary>
    [NSXTProperty(Description: @"Assigned Internet Protocol in IP header, TCP, UDP are supported.")]
    public enum NSXTLbVirtualServerIpProtocolEnumType
    {
        [EnumMember(Value = "TCP")]
        TCP = 1,
        [EnumMember(Value = "UDP")]
        UDP = 2,
    }
}
