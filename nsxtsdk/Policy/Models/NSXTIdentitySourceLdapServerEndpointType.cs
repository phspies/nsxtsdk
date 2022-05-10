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
    /// Information about a single LDAP server endpoint.
    /// </summary>
    [NSXTProperty(Description: @"Information about a single LDAP server endpoint.")]
    public class NSXTIdentitySourceLdapServerEndpointType 
    {
        /// <summary>
        /// The URL for the LDAP server. Supported URL schemes are LDAP and LDAPS. Either a hostname or an IP address may be given,
        /// and the port number is optional and defaults to 389 for the LDAP scheme and 636 for the LDAPS scheme.
        /// </summary>
        [JsonProperty(PropertyName = "url", Required = Required.AllowNull)]
        public string Url { get; set; }
        /// <summary>
        /// If set to true, Use the StartTLS extended operation to upgrade
        /// the connection to TLS before sending any sensitive information.
        /// The LDAP server must support the StartTLS extended operation
        /// in order for this protocol to operate correctly. This option
        /// is ignored if the URL scheme is LDAPS.
        /// </summary>
        [JsonProperty(PropertyName = "use_starttls")]
        public bool? UseStarttls { get; set; }
    }
}
