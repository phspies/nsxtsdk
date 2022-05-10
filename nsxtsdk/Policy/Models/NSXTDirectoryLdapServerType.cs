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
    public class NSXTDirectoryLdapServerType : NSXTManagedResourceType
    {
        /// <summary>
        /// Directory LDAP server connection user name.
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string? Username { get; set; }
        /// <summary>
        /// Directory LDAP server DNS host name or ip address which is reachable by NSX manager to be connected and do object
        /// synchronization.
        /// </summary>
        [JsonProperty(PropertyName = "host", Required = Required.AllowNull)]
        public string Host { get; set; }
        /// <summary>
        /// Directory LDAP server connection protocol which is either LDAP or LDAPS.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDirectoryLdapServerProtocolEnumType? Protocol { get; set; }
        /// <summary>
        /// Directory LDAP server certificate thumbprint used in secure LDAPS connection.
        /// </summary>
        [JsonProperty(PropertyName = "thumbprint")]
        public string? Thumbprint { get; set; }
        /// <summary>
        /// Directory LDAP server connection password.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Directory domain name which best describes the domain. It could be unique fqdn name or it could also be descriptive.
        /// There is no unique contraint for domain name among different domains.
        /// </summary>
        [JsonProperty(PropertyName = "domain_name")]
        public string? DomainName { get; set; }
        /// <summary>
        /// Directory LDAP server connection TCP/UDP port.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
    }
}
