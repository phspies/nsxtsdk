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
    /// Advanced load balancer LdapAuthSettings object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer LdapAuthSettings object")]
    public class NSXTALBLdapAuthSettingsType 
    {
        /// <summary>
        /// LDAP anonymous bind configuration.
        /// </summary>
        [JsonProperty(PropertyName = "user_bind")]
        [NSXTProperty(IsRequired: false, Description: @"LDAP anonymous bind configuration.")]
        public NSXTALBLdapUserBindSettingsType UserBind { get; set; }
        /// <summary>
        /// LDAP connection security mode.
        /// Enum options - AUTH_LDAP_SECURE_NONE,
        /// AUTH_LDAP_SECURE_USE_LDAPS.
        /// </summary>
        [JsonProperty(PropertyName = "security_mode")]
        [NSXTProperty(IsRequired: false, Description: @"LDAP connection security mode.Enum options - AUTH_LDAP_SECURE_NONE,AUTH_LDAP_SECURE_USE_LDAPS.")]
        public NSXTAlbldapAuthSettingsSecurityModeEnumType? SecurityMode { get; set; }
        /// <summary>
        /// LDAP attribute that refers to user's full name.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as name.
        /// </summary>
        [JsonProperty(PropertyName = "full_name_attribute")]
        [NSXTProperty(IsRequired: false, Description: @"LDAP attribute that refers to user&apos;s full name.Default value when not specified in API or module isinterpreted by ALB Controller as name.")]
        [NSXTDefaultProperty(Default: "name")]
        public string? FullNameAttribute { get; set; }
        /// <summary>
        /// LDAP full directory configuration with administrator
        /// credentials.
        /// </summary>
        [JsonProperty(PropertyName = "settings")]
        [NSXTProperty(IsRequired: false, Description: @"LDAP full directory configuration with administratorcredentials.")]
        public NSXTALBLdapDirectorySettingsType Settings { get; set; }
        /// <summary>
        /// The LDAP base DN.
        /// For example, avinetworks.com would be
        /// DC=avinetworks,DC=com.
        /// </summary>
        [JsonProperty(PropertyName = "base_dn")]
        [NSXTProperty(IsRequired: false, Description: @"The LDAP base DN.For example, avinetworks.com would beDC=avinetworks,DC=com.")]
        public string? BaseDn { get; set; }
        /// <summary>
        /// LDAP attribute that refers to user email.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as email.
        /// </summary>
        [JsonProperty(PropertyName = "email_attribute")]
        [NSXTProperty(IsRequired: false, Description: @"LDAP attribute that refers to user email.Default value when not specified in API or module isinterpreted by ALB Controller as email.")]
        [NSXTDefaultProperty(Default: "email")]
        public string? EmailAttribute { get; set; }
        /// <summary>
        /// LDAP administrator credentials are used to search for users
        /// and group memberships.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "bind_as_administrator")]
        [NSXTProperty(IsRequired: false, Description: @"LDAP administrator credentials are used to search for usersand group memberships.Default value when not specified in API or module isinterpreted by ALB Controller as true.")]
        [NSXTDefaultProperty(Default: "")]
        public bool? BindAsAdministrator { get; set; }
        /// <summary>
        /// Query the LDAP servers on this port.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 389.
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        [NSXTProperty(IsRequired: false, Description: @"Query the LDAP servers on this port.Default value when not specified in API or module isinterpreted by ALB Controller as 389.")]
        [NSXTDefaultProperty(Default: "")]
        public long? Port { get; set; }
        /// <summary>
        /// LDAP server IP address or Hostname.
        /// Use IP address if an auth profile is used to configure
        /// Virtual Service.
        /// Minimum of 1 items required.
        /// </summary>
        [JsonProperty(PropertyName = "server", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"LDAP server IP address or Hostname.Use IP address if an auth profile is used to configureVirtual Service.Minimum of 1 items required.")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<string> Server { get; set; }
    }
}