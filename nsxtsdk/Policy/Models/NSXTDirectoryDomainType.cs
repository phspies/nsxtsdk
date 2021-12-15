// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritanceAttribute("DirectoryAdDomain", typeof(NSXTDirectoryAdDomainType))]
    [NSXTProperty(Description: @"")]
    public class NSXTDirectoryDomainType : NSXTManagedResourceType
    {
        /// <summary>
        /// Directory domain LDAP servers' information including host, name, port, protocol and so on.
        /// </summary>
        [JsonProperty(PropertyName = "ldap_servers", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Directory domain LDAP servers&apos; information including host, name, port, protocol and so on.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTDirectoryLdapServerType> LdapServers { get; set; }
        /// <summary>
        /// Directory domain name which best describes the domain. It could be unique fqdn name or it could also be descriptive.
        /// There is no unique contraint for domain name among different domains.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Directory domain name which best describes the domain. It could be unique fqdn name or it could also be descriptive. There is no unique contraint for domain name among different domains.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Domain resource type comes from multiple sub-classes extending this base class. For example, DirectoryAdDomain is one
        /// accepted resource_type. If there are more sub-classes defined, they will also be accepted resource_type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Domain resource type comes from multiple sub-classes extending this base class. For example, DirectoryAdDomain is one accepted resource_type. If there are more sub-classes defined, they will also be accepted resource_type.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTDirectoryDomainResourceTypeEnumType ResourceType { get; set; }
    }
}
