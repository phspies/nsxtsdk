// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// The severity calculation is based on credit usage percentage ofload balancer for one node.
    /// </summary>
    [NSXTProperty(Description: @"The severity calculation is based on credit usage percentage ofload balancer for one node.")]
    public enum NSXTLbNodeCountPerSeveritySeverityEnumType
    {
        [EnumMember(Value = "GREEN")]
        GREEN = 1,
        [EnumMember(Value = "ORANGE")]
        ORANGE = 2,
        [EnumMember(Value = "RED")]
        RED = 3,
    }
}