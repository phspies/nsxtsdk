// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// The severity calculation is based on current credit usage percentageof load balancer for all nodes.
    /// </summary>
    [NSXTProperty(Description: @"The severity calculation is based on current credit usage percentageof load balancer for all nodes.")]
    public enum NSXTLbNodeUsageSummarySeverityEnumType
    {
        [EnumMember(Value = "GREEN")]
        GREEN = 1,
        [EnumMember(Value = "ORANGE")]
        ORANGE = 2,
        [EnumMember(Value = "RED")]
        RED = 3,
    }
}