// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Network status of container application instance.
    /// </summary>
    [NSXTProperty(Description: @"Network status of container application instance.")]
    public enum NSXTContainerApplicationInstanceNetworkStatusEnumType
    {
        [EnumMember(Value = "HEALTHY")]
        HEALTHY = 1,
        [EnumMember(Value = "UNHEALTHY")]
        UNHEALTHY = 2,
    }
}