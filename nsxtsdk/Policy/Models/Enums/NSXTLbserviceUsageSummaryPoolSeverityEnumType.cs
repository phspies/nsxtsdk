// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The severity calculation is based on the overall usage percentage ofpools for all load balancer services.
    /// </summary>
    [NSXTProperty(Description: @"The severity calculation is based on the overall usage percentage ofpools for all load balancer services.")]
    public enum NSXTLbserviceUsageSummaryPoolSeverityEnumType
    {
        [EnumMember(Value = "GREEN")]
        GREEN = 1,
        [EnumMember(Value = "ORANGE")]
        ORANGE = 2,
        [EnumMember(Value = "RED")]
        RED = 3,
    }
}
