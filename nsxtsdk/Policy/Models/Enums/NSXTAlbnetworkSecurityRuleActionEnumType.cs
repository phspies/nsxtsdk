// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Enum options - NETWORK_SECURITY_POLICY_ACTION_TYPE_ALLOW,NETWORK_SECURITY_POLICY_ACTION_TYPE_DENY,NETWORK_SECURITY_POLICY_ACTION_TYPE_RATE_LIMIT.
    /// </summary>
    [NSXTProperty(Description: @"Enum options - NETWORK_SECURITY_POLICY_ACTION_TYPE_ALLOW,NETWORK_SECURITY_POLICY_ACTION_TYPE_DENY,NETWORK_SECURITY_POLICY_ACTION_TYPE_RATE_LIMIT.")]
    public enum NSXTAlbnetworkSecurityRuleActionEnumType
    {
        [EnumMember(Value = "NETWORK_SECURITY_POLICY_ACTION_TYPE_ALLOW")]
        NETWORKSECURITYPOLICYACTIONTYPEALLOW = 1,
        [EnumMember(Value = "NETWORK_SECURITY_POLICY_ACTION_TYPE_DENY")]
        NETWORKSECURITYPOLICYACTIONTYPEDENY = 2,
        [EnumMember(Value = "NETWORK_SECURITY_POLICY_ACTION_TYPE_RATE_LIMIT")]
        NETWORKSECURITYPOLICYACTIONTYPERATELIMIT = 3,
    }
}
