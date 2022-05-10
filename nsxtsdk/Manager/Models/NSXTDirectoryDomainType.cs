using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDirectoryDomainType : NSXTManagedResourceType
    {
        /// <summary>
        /// Directory domain LDAP servers' information including host, name, port, protocol and so on.
        /// </summary>
        [JsonProperty(PropertyName = "ldap_servers", Required = Required.AllowNull)]
        public IList<NSXTDirectoryLdapServerType> LdapServers { get; set; }
        /// <summary>
        /// Directory domain name which best describes the domain. It could be unique fqdn name or it could also be descriptive.
        /// There is no unique contraint for domain name among different domains.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Domain resource type comes from multiple sub-classes extending this base class. For example, DirectoryAdDomain is one
        /// accepted resource_type. If there are more sub-classes defined, they will also be accepted resource_type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDirectoryDomainResourceTypeEnumType ResourceType { get; set; }
        /// <summary>
        /// Directory domain Event Log server's information including host, name, protocol and so on.
        /// </summary>
        [JsonProperty(PropertyName = "event_log_servers")]
        public IList<NSXTDirectoryEventLogServerType> EventLogServers { get; set; }
    }
}
