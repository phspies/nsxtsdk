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
    /// Advanced load balancer LdapAuthSettings object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer LdapAuthSettings object")]
    public class NSXTALBLdapAuthSettingsType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "user_bind")]
        public NSXTALBLdapUserBindSettingsType UserBind { get; set; }
        /// <summary>
        /// LDAP connection security mode.
        /// Enum options - AUTH_LDAP_SECURE_NONE,
        /// AUTH_LDAP_SECURE_USE_LDAPS.
        /// </summary>
        [JsonProperty(PropertyName = "security_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbldapAuthSettingsSecurityModeEnumType? SecurityMode { get; set; }
        /// <summary>
        /// LDAP attribute that refers to user's full name.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as name.
        /// </summary>
        [JsonProperty(PropertyName = "full_name_attribute")]
        public string? FullNameAttribute { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "settings")]
        public NSXTALBLdapDirectorySettingsType Settings { get; set; }
        /// <summary>
        /// The LDAP base DN.
        /// For example, avinetworks.com would be
        /// DC=avinetworks,DC=com.
        /// </summary>
        [JsonProperty(PropertyName = "base_dn")]
        public string? BaseDn { get; set; }
        /// <summary>
        /// LDAP attribute that refers to user email.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as email.
        /// </summary>
        [JsonProperty(PropertyName = "email_attribute")]
        public string? EmailAttribute { get; set; }
        /// <summary>
        /// LDAP administrator credentials are used to search for users
        /// and group memberships.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "bind_as_administrator")]
        public bool? BindAsAdministrator { get; set; }
        /// <summary>
        /// Query the LDAP servers on this port.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 389.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public long? Port { get; set; }
        /// <summary>
        /// LDAP server IP address or Hostname.
        /// Use IP address if an auth profile is used to configure
        /// Virtual Service.
        /// Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        public IList<string> Server { get; set; }
    }
}
