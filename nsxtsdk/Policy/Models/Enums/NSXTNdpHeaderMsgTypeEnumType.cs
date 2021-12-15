// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// This field specifies the type of the Neighbor discover message being sent. NEIGHBOR_SOLICITATION - Neighbor Solicitation message to discover the link-layer address of an on-link IPv6 node or to confirm a previously determined link-layer address. NEIGHBOR_ADVERTISEMENT - Neighbor Advertisement message in response to a Neighbor Solicitation message.
    /// </summary>
    [NSXTProperty(Description: @"This field specifies the type of the Neighbor discover message being sent. NEIGHBOR_SOLICITATION - Neighbor Solicitation message to discover the link-layer address of an on-link IPv6 node or to confirm a previously determined link-layer address. NEIGHBOR_ADVERTISEMENT - Neighbor Advertisement message in response to a Neighbor Solicitation message.")]
    public enum NSXTNdpHeaderMsgTypeEnumType
    {
        [EnumMember(Value = "NEIGHBOR_SOLICITATION")]
        NEIGHBORSOLICITATION = 1,
        [EnumMember(Value = "NEIGHBOR_ADVERTISEMENT")]
        NEIGHBORADVERTISEMENT = 2,
    }
}
