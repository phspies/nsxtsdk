// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Edge node IBGP status
    /// </summary>
    [NSXTProperty(Description: @"Edge node IBGP status")]
    public enum NSXTPolicyEdgeClusterMemberInterSiteStatusStatusEnumType
    {
        [EnumMember(Value = "UP")]
        UP = 1,
        [EnumMember(Value = "DOWN")]
        DOWN = 2,
        [EnumMember(Value = "DEGRADED")]
        DEGRADED = 3,
        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN = 4,
    }
}
