// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// LACP load balance Algorithm
    /// </summary>
    [NSXTProperty(Description: @"LACP load balance Algorithm")]
    public enum NSXTLagLoadBalanceAlgorithmEnumType
    {
        [EnumMember(Value = "SRCMAC")]
        SRCMAC = 1,
        [EnumMember(Value = "DESTMAC")]
        DESTMAC = 2,
        [EnumMember(Value = "SRCDESTMAC")]
        SRCDESTMAC = 3,
        [EnumMember(Value = "SRCDESTIPVLAN")]
        SRCDESTIPVLAN = 4,
        [EnumMember(Value = "SRCDESTMACIPPORT")]
        SRCDESTMACIPPORT = 5,
    }
}
