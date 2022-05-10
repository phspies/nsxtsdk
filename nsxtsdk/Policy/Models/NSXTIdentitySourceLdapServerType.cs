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
    /// Information about a single LDAP server.
    /// </summary>
    [NSXTProperty(Description: @"Information about a single LDAP server.")]
    public class NSXTIdentitySourceLdapServerType 
    {
        /// <summary>
        /// If using LDAPS or STARTTLS, provide the X.509 certificate of the LDAP server in PEM format. This property is not
        /// required when connecting without TLS encryption and is ignored in that case.
        /// </summary>
        [JsonProperty(PropertyName = "certificates")]
        public IList<string> Certificates { get; set; }
        /// <summary>
        /// A username used to authenticate to the directory when admnistering roles in NSX. This user should have privileges to
        /// search the LDAP directory for groups and users. This user is also used in some cases (OpenLDAP) to look up an NSX user's
        /// distinguished name based on their NSX login name. If omitted, NSX will authenticate to the LDAP server using an LDAP
        /// anonymous bind operation. For Active Directory, provide a userPrincipalName (e.g. administrator@airius.com) or the full
        /// distinguished nane. For OpenLDAP, provide the distinguished name of the user (e.g. uid=admin, cn=airius, dc=com).
        /// </summary>
        [JsonProperty(PropertyName = "bind_identity")]
        public string? BindIdentity { get; set; }
        /// <summary>
        /// If set to true, Use the StartTLS extended operation to upgrade
        /// the connection to TLS before sending any sensitive information.
        /// The LDAP server must support the StartTLS extended operation
        /// in order for this protocol to operate correctly. This option
        /// is ignored if the URL scheme is LDAPS.
        /// </summary>
        [JsonProperty(PropertyName = "use_starttls")]
        public bool? UseStarttls { get; set; }
        /// <summary>
        /// The URL for the LDAP server. Supported URL schemes are LDAP and LDAPS. Either a hostname or an IP address may be given,
        /// and the port number is optional and defaults to 389 for the LDAP scheme and 636 for the LDAPS scheme.
        /// </summary>
        [JsonProperty(PropertyName = "url", Required = Required.AllowNull)]
        public string Url { get; set; }
        /// <summary>
        /// A password used when authenticating to the directory.
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string? Password { get; set; }
        /// <summary>
        /// Allows the LDAP server to be enabled or disabled. When disabled, this LDAP server will not be used to authenticate
        /// users.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
    }
}
