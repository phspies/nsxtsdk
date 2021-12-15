// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// This setting does not restrict configuration as per other modes. But the forwarding will only work as per the mode set here.
    /// </summary>
    [NSXTProperty(Description: @"This setting does not restrict configuration as per other modes. But the forwarding will only work as per the mode set here.")]
    public enum NSXTRoutingGlobalConfigL3ForwardingModeEnumType
    {
        [EnumMember(Value = "IPV4_ONLY")]
        IPV4ONLY = 1,
        [EnumMember(Value = "IPV4_AND_IPV6")]
        IPV4ANDIPV6 = 2,
    }
}