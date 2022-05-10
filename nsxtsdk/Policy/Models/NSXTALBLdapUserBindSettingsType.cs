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
    /// Advanced load balancer LdapUserBindSettings object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer LdapUserBindSettings object")]
    public class NSXTALBLdapUserBindSettingsType 
    {
        /// <summary>
        /// LDAP user DN pattern is used to bind LDAP user after
        /// replacing the user token with real username.
        /// </summary>
        [JsonProperty(PropertyName = "dn_template")]
        public string? DnTemplate { get; set; }
        /// <summary>
        /// LDAP user attributes to fetch on a successful user bind.
        /// </summary>
        [JsonProperty(PropertyName = "user_attributes")]
        public IList<string> UserAttributes { get; set; }
        /// <summary>
        /// LDAP token is replaced with real user name in the user DN
        /// pattern.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as <user>.
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public string? Token { get; set; }
        /// <summary>
        /// LDAP user id attribute is the login attribute that uniquely
        /// identifies a single user record.
        /// </summary>
        [JsonProperty(PropertyName = "user_id_attribute")]
        public string? UserIdAttribute { get; set; }
    }
}
