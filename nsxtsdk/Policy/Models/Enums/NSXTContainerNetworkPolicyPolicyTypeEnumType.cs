// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Type e.g. Network Policy, ASG.
    /// </summary>
    [NSXTProperty(Description: @"Type e.g. Network Policy, ASG.")]
    public enum NSXTContainerNetworkPolicyPolicyTypeEnumType
    {
        [EnumMember(Value = "NETWORK_POLICY")]
        NETWORKPOLICY = 1,
        [EnumMember(Value = "ASG")]
        ASG = 2,
        [EnumMember(Value = "ACNP")]
        ACNP = 3,
        [EnumMember(Value = "ANP")]
        ANP = 4,
    }
}
