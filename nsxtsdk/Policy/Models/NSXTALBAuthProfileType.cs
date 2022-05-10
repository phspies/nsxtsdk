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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTALBAuthProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "http")]
        public NSXTALBAuthProfileHTTPClientParamsType Http { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tacacs_plus")]
        public NSXTALBTacacsPlusAuthSettingsType TacacsPlus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ldap")]
        public NSXTALBLdapAuthSettingsType Ldap { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "saml")]
        public NSXTALBSamlSettingsType Saml { get; set; }
        /// <summary>
        /// Type of the Auth Profile.
        /// Enum options - AUTH_PROFILE_LDAP, AUTH_PROFILE_TACACS_PLUS,
        /// AUTH_PROFILE_SAML, AUTH_PROFILE_PINGACCESS,
        /// AUTH_PROFILE_JWT.
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbauthProfileTypeEnumType Type { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
    }
}
