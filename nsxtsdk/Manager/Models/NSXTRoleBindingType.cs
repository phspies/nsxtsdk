// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTRoleBindingType : NSXTManagedResourceType
    {
        /// <summary>
        /// Identity source type
        /// </summary>
        public NSXTRoleBindingIdentitySourceTypeEnumType? IdentitySourceType { get; set; }
        /// <summary>
        /// Local user's numeric id on the system.
        /// </summary>
        public string? UserId { get; set; }
        /// <summary>
        /// User/Group's name
        /// </summary>
        public string? Name { get; set; }
        /// <summary>
        /// The roles of the user.
        /// </summary>
        public IList<NSXTRoleType> Roles { get; set; }
        /// <summary>
        /// Type
        /// </summary>
        public NSXTRoleBindingTypeEnumType? Type { get; set; }
        /// <summary>
        /// Property 'stale' can be considered to have these values - absent  - This type of rolebinding does not support stale
        /// property TRUE    - Rolebinding is stale in vIDM meaning the user is no longer present in vIDM FALSE   - Rolebinding is
        /// available in vIDM UNKNOWN - Rolebinding's state of staleness in unknown Once rolebindings become stale, they can be
        /// deleted using the API POST /aaa/role-bindings?action=delete_stale_bindings
        /// </summary>
        public NSXTRoleBindingStaleEnumType? Stale { get; set; }
        /// <summary>
        /// The ID of the external identity source that holds the referenced external entity. Currently, only external LDAP and OIDC
        /// servers are allowed.
        /// </summary>
        public string? IdentitySourceId { get; set; }
    }
}
