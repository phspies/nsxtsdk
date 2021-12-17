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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Status LDAP server of directory domain
    /// </summary>
    [NSXTProperty(Description: @"Status LDAP server of directory domain")]
    public class NSXTDirectoryLdapServerStatusType 
    {
        public NSXTDirectoryLdapServerStatusType()
        {
        }
        /// <summary>
        /// Error ID of the directory LDAP server status maintained by the NSX directory service.
        /// </summary>
        [JsonProperty(PropertyName = "error_id")]
        [NSXTProperty(IsRequired: false, Description: @"Error ID of the directory LDAP server status maintained by the NSX directory service.")]
        public long? ErrorId { get; set; }
        /// <summary>
        /// Error message of the directory LDAP server status maintained by the NSX directory service.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        [NSXTProperty(IsRequired: false, Description: @"Error message of the directory LDAP server status maintained by the NSX directory service.")]
        public string? ErrorMessage { get; set; }
    }
}
