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
    [JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritanceAttribute("OpenLdapIdentitySource", typeof(NSXTOpenLdapIdentitySourceType))]
    [JsonInheritanceAttribute("ActiveDirectoryIdentitySource", typeof(NSXTActiveDirectoryIdentitySourceType))]
    [NSXTProperty(Description: @"")]
    public class NSXTLdapIdentitySourceType : NSXTManagedResourceType
    {
        /// <summary>
        /// The list of LDAP servers that provide LDAP service for this identity source. Currently, only one LDAP server is
        /// supported.
        /// </summary>
        [JsonProperty(PropertyName = "ldap_servers")]
        public IList<NSXTIdentitySourceLdapServerType> LdapServers { get; set; }
        /// <summary>
        /// The subtree of the LDAP identity source to search when locating users and groups.
        /// </summary>
        [JsonProperty(PropertyName = "base_dn", Required = Required.AllowNull)]
        public string BaseDn { get; set; }
        /// <summary>
        /// The name of the authentication domain. When users log into NSX using an identity of the form "user@domain", NSX uses the
        /// domain portion to determine which LDAP identity source to use.
        /// </summary>
        [JsonProperty(PropertyName = "domain_name", Required = Required.AllowNull)]
        public string DomainName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLdapIdentitySourceResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// After parsing the "user@domain", the domain portion is used to select the LDAP identity source to use. Additional
        /// domains listed here will also be directed to this LDAP identity source. In Active Directory these are sometimes referred
        /// to as Alternative UPN Suffixes.
        /// </summary>
        [JsonProperty(PropertyName = "alternative_domain_names")]
        public IList<string> AlternativeDomainNames { get; set; }
    }
}
