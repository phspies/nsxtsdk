// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// The policy after MAC Limit is exceeded
    /// </summary>
    [NSXTProperty(Description: @"The policy after MAC Limit is exceeded")]
    public enum NSXTMacDiscoveryProfileMacLimitPolicyEnumType
    {
        [EnumMember(Value = "ALLOW")]
        ALLOW = 1,
        [EnumMember(Value = "DROP")]
        DROP = 2,
    }
}
