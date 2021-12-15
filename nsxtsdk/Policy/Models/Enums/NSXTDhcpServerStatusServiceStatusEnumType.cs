// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// UP means the dhcp service is working fine on both active transport-nodeand stand-by transport-node (if have), hence fail-over can work at thistime if there is failure happens on one of the transport-node;DOWN means the dhcp service is down on both active transport-node andstand-by node (if have), hence the dhcp-service will not repsonse anydhcp request;Error means error happens on transport-node(s) or no status is reported fromtransport-node(s). The dhcp service may be working (or not working);NO_STANDBY means dhcp service is working in one of the transport node whilenot in the other transport-node (if have). Hence if the dhcp service inthe working transport-node is down, fail-over will not happen and thedhcp service will go down.
    /// </summary>
    [NSXTProperty(Description: @"UP means the dhcp service is working fine on both active transport-nodeand stand-by transport-node (if have), hence fail-over can work at thistime if there is failure happens on one of the transport-node;DOWN means the dhcp service is down on both active transport-node andstand-by node (if have), hence the dhcp-service will not repsonse anydhcp request;Error means error happens on transport-node(s) or no status is reported fromtransport-node(s). The dhcp service may be working (or not working);NO_STANDBY means dhcp service is working in one of the transport node whilenot in the other transport-node (if have). Hence if the dhcp service inthe working transport-node is down, fail-over will not happen and thedhcp service will go down.")]
    public enum NSXTDhcpServerStatusServiceStatusEnumType
    {
        [EnumMember(Value = "UP")]
        UP = 1,
        [EnumMember(Value = "DOWN")]
        DOWN = 2,
        [EnumMember(Value = "ERROR")]
        ERROR = 3,
        [EnumMember(Value = "NO_STANDBY")]
        NOSTANDBY = 4,
    }
}
