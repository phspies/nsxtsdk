// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Type of IP packet that should be matched while enforcing the rule.
    /// </summary>
    [NSXTProperty(Description: @"Type of IP packet that should be matched while enforcing the rule.")]
    public enum NSXTDsruleIpProtocolEnumType
    {
        [EnumMember(Value = "IPV4")]
        IPV4 = 1,
        [EnumMember(Value = "IPV6")]
        IPV6 = 2,
        [EnumMember(Value = "IPV4_IPV6")]
        IPV4IPV6 = 0,
    }
}
