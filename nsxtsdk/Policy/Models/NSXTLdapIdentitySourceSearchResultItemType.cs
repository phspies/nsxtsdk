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
    public class NSXTLdapIdentitySourceSearchResultItemType 
    {
        /// <summary>
        /// Distinguished name (DN) of the entry.
        /// </summary>
        [JsonProperty(PropertyName = "dn")]
        public string? Dn { get; set; }
        /// <summary>
        /// The Common Name (CN) of the entry, if available.
        /// </summary>
        [JsonProperty(PropertyName = "common_name")]
        public string? CommonName { get; set; }
        /// <summary>
        /// For Active Directory (AD) users, this will be the user principal name (UPN), in the format user@domain. For non-AD
        /// users, this will be the user's uid property, followed by "@" and the domain of the directory. For groups, this will be
        /// the group's common name, followed by "@" and the domain of the directory.
        /// </summary>
        [JsonProperty(PropertyName = "principal_name")]
        public string? PrincipalName { get; set; }
        /// <summary>
        /// Describes the type of the entry
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLdapIdentitySourceSearchResultItemTypeEnumType? Type { get; set; }
    }
}
