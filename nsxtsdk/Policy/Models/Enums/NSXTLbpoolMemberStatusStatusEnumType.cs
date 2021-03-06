// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// UP means that pool member is enabled and monitors have marked the poolmember as UP. If the pool member has no monitor configured, it wouldbe treated as UP.DOWN means that pool member is enabled and monitors have marked thepool member as DOWN.DISABLED means that admin state of pool member is set to DISABLED.GRACEFUL_DISABLED means that admin state of pool member is set toGRACEFUL_DISABLED.UNUSED means that the pool member is not used when the IP list sizeof member group exceeds the maximum setting. The remaining IP addresseswould not be used as available backend servers, hence mark the statusas UNUSED.UNKNOWN means that the related pool is not associated to any enabledvirtual servers, or no status reported from transport-nodes, theassociated load balancer service may be working(or not working).
    /// </summary>
    [NSXTProperty(Description: @"UP means that pool member is enabled and monitors have marked the poolmember as UP. If the pool member has no monitor configured, it wouldbe treated as UP.DOWN means that pool member is enabled and monitors have marked thepool member as DOWN.DISABLED means that admin state of pool member is set to DISABLED.GRACEFUL_DISABLED means that admin state of pool member is set toGRACEFUL_DISABLED.UNUSED means that the pool member is not used when the IP list sizeof member group exceeds the maximum setting. The remaining IP addresseswould not be used as available backend servers, hence mark the statusas UNUSED.UNKNOWN means that the related pool is not associated to any enabledvirtual servers, or no status reported from transport-nodes, theassociated load balancer service may be working(or not working).")]
    public enum NSXTLbpoolMemberStatusStatusEnumType
    {
        [EnumMember(Value = "UP")]
        UP = 1,
        [EnumMember(Value = "DOWN")]
        DOWN = 2,
        [EnumMember(Value = "DISABLED")]
        DISABLED = 3,
        [EnumMember(Value = "GRACEFUL_DISABLED")]
        GRACEFULDISABLED = 4,
        [EnumMember(Value = "UNUSED")]
        UNUSED = 5,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 6,
    }
}
