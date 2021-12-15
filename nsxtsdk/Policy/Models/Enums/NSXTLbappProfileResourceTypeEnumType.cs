// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// An application profile can be bound to a virtual serverto specify the application protocol characteristics. It is used toinfluence how load balancing is performed. Currently, three types ofapplication profiles are supported: LBFastTCPProfile,LBFastUDPProfile and LBHttpProfile.LBFastTCPProfile or LBFastUDPProfile is typicallyused when the application is using a custom protocol or a standard protocolnot supported by the load balancer. It is also used in cases where the useronly wants L4 load balancing mainly because L4 load balancing has muchhigher performance and scalability, and/or supports connection mirroring.LBHttpProfile is used for both HTTP and HTTPS applications.Though application rules, if bound to the virtual server, can be usedto accomplish the same goal, LBHttpProfile is intended tosimplify enabling certain common use cases.
    /// </summary>
    [NSXTProperty(Description: @"An application profile can be bound to a virtual serverto specify the application protocol characteristics. It is used toinfluence how load balancing is performed. Currently, three types ofapplication profiles are supported: LBFastTCPProfile,LBFastUDPProfile and LBHttpProfile.LBFastTCPProfile or LBFastUDPProfile is typicallyused when the application is using a custom protocol or a standard protocolnot supported by the load balancer. It is also used in cases where the useronly wants L4 load balancing mainly because L4 load balancing has muchhigher performance and scalability, and/or supports connection mirroring.LBHttpProfile is used for both HTTP and HTTPS applications.Though application rules, if bound to the virtual server, can be usedto accomplish the same goal, LBHttpProfile is intended tosimplify enabling certain common use cases.")]
    public enum NSXTLbappProfileResourceTypeEnumType
    {
        [EnumMember(Value = "LBHTTPPROFILE")]
        LbhttpProfile = 1,
        [EnumMember(Value = "LBFASTTCPPROFILE")]
        LbfastTcpProfile = 2,
        [EnumMember(Value = "LBFASTUDPPROFILE")]
        LbfastUdpProfile = 3,
    }
}