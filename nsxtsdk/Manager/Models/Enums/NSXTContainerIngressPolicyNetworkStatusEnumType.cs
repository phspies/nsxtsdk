// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Network status of container ingress.
    /// </summary>
    [NSXTProperty(Description: @"Network status of container ingress.")]
    public enum NSXTContainerIngressPolicyNetworkStatusEnumType
    {
        [EnumMember(Value = "HEALTHY")]
        HEALTHY = 1,
        [EnumMember(Value = "UNHEALTHY")]
        UNHEALTHY = 2,
    }
}
