// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Overall status of all edge nodes IBGP status in the edge cluster.
    /// </summary>
    [NSXTProperty(Description: @"Overall status of all edge nodes IBGP status in the edge cluster.")]
    public enum NSXTEdgeClusterInterSiteStatusOverallStatusEnumType
    {
        [EnumMember(Value = "UP")]
        UP = 1,
        [EnumMember(Value = "DOWN")]
        DOWN = 2,
        [EnumMember(Value = "DEGRADED")]
        DEGRADED = 3,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 4,
        [EnumMember(Value = "CONFIGURED")]
        CONFIGURED = 5,
    }
}
