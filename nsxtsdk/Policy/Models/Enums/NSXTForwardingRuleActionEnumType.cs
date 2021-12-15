// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The action to be applied to all the services
    /// </summary>
    [NSXTProperty(Description: @"The action to be applied to all the services")]
    public enum NSXTForwardingRuleActionEnumType
    {
        [EnumMember(Value = "ROUTE_TO_UNDERLAY")]
        ROUTETOUNDERLAY = 1,
        [EnumMember(Value = "ROUTE_TO_OVERLAY")]
        ROUTETOOVERLAY = 2,
        [EnumMember(Value = "ROUTE_FROM_UNDERLAY")]
        ROUTEFROMUNDERLAY = 3,
        [EnumMember(Value = "ROUTE_FROM_OVERLAY")]
        ROUTEFROMOVERLAY = 4,
        [EnumMember(Value = "NAT_FROM_UNDERLAY")]
        NATFROMUNDERLAY = 5,
        [EnumMember(Value = "NAT_TO_UNDERLAY")]
        NATTOUNDERLAY = 6,
    }
}