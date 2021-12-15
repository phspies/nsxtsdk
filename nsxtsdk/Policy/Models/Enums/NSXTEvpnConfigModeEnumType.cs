// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// In INLINE mode, edge nodes participate both in the BGP EVPN controlplane route exchange and in data path tunneling between edge nodesand data center gateways. In ROUTE_SERVER mode, edge nodes participatein the BGP EVPN control plane route exchanges only and do not participatein the data forwarding, i.e., the data path tunnels are directlyestablished between the hypervisors and the data center gateways.DISABLE mode disables EVPN service capability.
    /// </summary>
    [NSXTProperty(Description: @"In INLINE mode, edge nodes participate both in the BGP EVPN controlplane route exchange and in data path tunneling between edge nodesand data center gateways. In ROUTE_SERVER mode, edge nodes participatein the BGP EVPN control plane route exchanges only and do not participatein the data forwarding, i.e., the data path tunnels are directlyestablished between the hypervisors and the data center gateways.DISABLE mode disables EVPN service capability.")]
    public enum NSXTEvpnConfigModeEnumType
    {
        [EnumMember(Value = "INLINE")]
        INLINE = 1,
        [EnumMember(Value = "ROUTE_SERVER")]
        ROUTESERVER = 2,
        [EnumMember(Value = "DISABLE")]
        DISABLE = 0,
    }
}
