using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Advanced load balancer LdapDirectorySettings object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer LdapDirectorySettings object")]
    public class NSXTALBLdapDirectorySettingsType 
    {
        /// <summary>
        /// LDAP Admin User Password.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// LDAP user search DN is the root of search for a given user
        /// in the LDAP directory.
        /// Only user records present in this LDAP directory sub-tree
        /// will be validated.
        /// </summary>
        [JsonProperty(PropertyName = "user_search_dn")]
        public string? UserSearchDn { get; set; }
        /// <summary>
        /// Group member entries contain full DNs instead of just user
        /// id attribute values.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "group_member_is_full_dn")]
        public bool? GroupMemberIsFullDn { get; set; }
        /// <summary>
        /// LDAP user search scope defines how deep to search for the
        /// user starting from user search DN.
        /// Enum options - AUTH_LDAP_SCOPE_BASE, AUTH_LDAP_SCOPE_ONE,
        /// AUTH_LDAP_SCOPE_SUBTREE.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as AUTH_LDAP_SCOPE_ONE.
        /// </summary>
        [JsonProperty(PropertyName = "user_search_scope")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbldapDirectorySettingsUserSearchScopeEnumType? UserSearchScope { get; set; }
        /// <summary>
        /// LDAP user id attribute is the login attribute that uniquely
        /// identifies a single user record.
        /// </summary>
        [JsonProperty(PropertyName = "user_id_attribute")]
        public string? UserIdAttribute { get; set; }
        /// <summary>
        /// LDAP group attribute that identifies each of the group
        /// members.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as member.
        /// </summary>
        [JsonProperty(PropertyName = "group_member_attribute")]
        public string? GroupMemberAttribute { get; set; }
        /// <summary>
        /// Group filter is used to identify groups during search.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as (objectClass=(STAR)).
        /// </summary>
        [JsonProperty(PropertyName = "group_filter")]
        public string? GroupFilter { get; set; }
        /// <summary>
        /// LDAP group search DN is the root of search for a given
        /// group in the LDAP directory.
        /// Only matching groups present in this LDAP directory
        /// sub-tree will be checked for user membership.
        /// </summary>
        [JsonProperty(PropertyName = "group_search_dn")]
        public string? GroupSearchDn { get; set; }
        /// <summary>
        /// LDAP user attributes to fetch on a successful user bind.
        /// </summary>
        [JsonProperty(PropertyName = "user_attributes")]
        public IList<string> UserAttributes { get; set; }
        /// <summary>
        /// During user or group search, ignore searching referrals.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "ignore_referrals")]
        public bool? IgnoreReferrals { get; set; }
        /// <summary>
        /// LDAP group search scope defines how deep to search for the
        /// group starting from the group search DN.
        /// Enum options - AUTH_LDAP_SCOPE_BASE, AUTH_LDAP_SCOPE_ONE,
        /// AUTH_LDAP_SCOPE_SUBTREE.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as AUTH_LDAP_SCOPE_SUBTREE.
        /// </summary>
        [JsonProperty(PropertyName = "group_search_scope")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbldapDirectorySettingsGroupSearchScopeEnumType? GroupSearchScope { get; set; }
        /// <summary>
        /// LDAP Admin User DN.
        /// Administrator credentials are required to search for users
        /// under user search DN or groups under group search DN.
        /// </summary>
        [JsonProperty(PropertyName = "admin_bind_dn")]
        public string? AdminBindDn { get; set; }
    }
}
