// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// This field indicates the default connectivity policy for the securitypolicy. Based on the connectivity strategy, a default rule for thissecurity policy will be created. An appropriate action will be set onthe rule based on the value of the connectivity strategy. If NONE isselected or no connectivity strategy is specified, then no defaultrule for the security policy gets created. The default rule that getscreated will be a any-any rule and applied to entities specified in thescope of the security policy. Specifying the connectivity_strategywithout specifying the scope is not allowed. The scope has to be aGroup and one cannot specify IPAddress directly in the group that isused as scope. This default rule is only applicable for the Layer3security policies.This property is deprecated. Use the type connectivity_preference instead.WHITELIST - Adds a default drop rule. Administrator can then use &quot;allow&quot;rules (aka whitelist) to allow traffic between groupsBLACKLIST - Adds a default allow rule. Admin can then use &quot;drop&quot; rules(aka blacklist) to block traffic between groupsWHITELIST_ENABLE_LOGGING - Whitelising with logging enabledBLACKLIST_ENABLE_LOGGING - Blacklisting with logging enabledNONE - No default rule is created.
    /// </summary>
    [NSXTProperty(Description: @"This field indicates the default connectivity policy for the securitypolicy. Based on the connectivity strategy, a default rule for thissecurity policy will be created. An appropriate action will be set onthe rule based on the value of the connectivity strategy. If NONE isselected or no connectivity strategy is specified, then no defaultrule for the security policy gets created. The default rule that getscreated will be a any-any rule and applied to entities specified in thescope of the security policy. Specifying the connectivity_strategywithout specifying the scope is not allowed. The scope has to be aGroup and one cannot specify IPAddress directly in the group that isused as scope. This default rule is only applicable for the Layer3security policies.This property is deprecated. Use the type connectivity_preference instead.WHITELIST - Adds a default drop rule. Administrator can then use &quot;allow&quot;rules (aka whitelist) to allow traffic between groupsBLACKLIST - Adds a default allow rule. Admin can then use &quot;drop&quot; rules(aka blacklist) to block traffic between groupsWHITELIST_ENABLE_LOGGING - Whitelising with logging enabledBLACKLIST_ENABLE_LOGGING - Blacklisting with logging enabledNONE - No default rule is created.")]
    public enum NSXTSecurityPolicyConnectivityStrategyEnumType
    {
        [EnumMember(Value = "WHITELIST")]
        WHITELIST = 1,
        [EnumMember(Value = "BLACKLIST")]
        BLACKLIST = 2,
        [EnumMember(Value = "WHITELIST_ENABLE_LOGGING")]
        WHITELISTENABLELOGGING = 3,
        [EnumMember(Value = "BLACKLIST_ENABLE_LOGGING")]
        BLACKLISTENABLELOGGING = 4,
        [EnumMember(Value = "NONE")]
        NONE = 5,
    }
}
