// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Address family type.If not configured, this property automatically derived for IPv4 &amp; IPv6peer configuration.
    /// </summary>
    [NSXTProperty(Description: @"Address family type.If not configured, this property automatically derived for IPv4 &amp; IPv6peer configuration.")]
    public enum NSXTBgpRouteFilteringAddressFamilyEnumType
    {
        [EnumMember(Value = "IPV4")]
        IPV4 = 1,
        [EnumMember(Value = "IPV6")]
        IPV6 = 2,
        [EnumMember(Value = "L2VPN_EVPN")]
        L2VPNEVPN = 3,
    }
}
