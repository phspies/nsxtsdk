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
    /// Status LDAP server of directory domain
    /// </summary>
    [NSXTProperty(Description: @"Status LDAP server of directory domain")]
    public class NSXTDirectoryLdapServerStatusType 
    {
        /// <summary>
        /// Error ID of the directory LDAP server status maintained by the NSX directory service.
        /// </summary>
        [JsonProperty(PropertyName = "error_id")]
        public long? ErrorId { get; set; }
        /// <summary>
        /// Error message of the directory LDAP server status maintained by the NSX directory service.
        /// </summary>
        [JsonProperty(PropertyName = "error_message")]
        public string? ErrorMessage { get; set; }
    }
}
