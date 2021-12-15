// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using System.Runtime.Serialization;
using nsxtsdk.Models;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// LDAP user search scope defines how deep to search for theuser starting from user search DN.Enum options - AUTH_LDAP_SCOPE_BASE, AUTH_LDAP_SCOPE_ONE,AUTH_LDAP_SCOPE_SUBTREE.Default value when not specified in API or module isinterpreted by ALB Controller as AUTH_LDAP_SCOPE_ONE.
    /// </summary>
    [NSXTProperty(Description: @"LDAP user search scope defines how deep to search for theuser starting from user search DN.Enum options - AUTH_LDAP_SCOPE_BASE, AUTH_LDAP_SCOPE_ONE,AUTH_LDAP_SCOPE_SUBTREE.Default value when not specified in API or module isinterpreted by ALB Controller as AUTH_LDAP_SCOPE_ONE.")]
    public enum NSXTAlbldapDirectorySettingsUserSearchScopeEnumType
    {
        [EnumMember(Value = "AUTH_LDAP_SCOPE_BASE")]
        AUTHLDAPSCOPEBASE = 1,
        [EnumMember(Value = "AUTH_LDAP_SCOPE_ONE")]
        AUTHLDAPSCOPEONE = 0,
        [EnumMember(Value = "AUTH_LDAP_SCOPE_SUBTREE")]
        AUTHLDAPSCOPESUBTREE = 1,
    }
}