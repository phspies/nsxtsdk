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
    public class NSXTDirectoryAdDomainType : NSXTDirectoryDomainType
    {
        /// <summary>
        /// Each active directory domain has a domain naming context (NC), which contains domain-specific data. The root of this
        /// naming context is represented by a domain's distinguished name (DN) and is typically referred to as the NC head.
        /// </summary>
        [JsonProperty(PropertyName = "base_distinguished_name", Required = Required.AllowNull)]
        public string BaseDistinguishedName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "sync_settings")]
        public NSXTDirectoryDomainSyncSettingsType SyncSettings { get; set; }
        /// <summary>
        /// NetBIOS names can contain all alphanumeric characters except for the certain disallowed characters. Names can contain a
        /// period, but names cannot start with a period. NetBIOS is similar to DNS in that it can serve as a directory service, but
        /// more limited as it has no provisions for a name hierarchy and names are limited to 15 characters. The netbios name is
        /// case insensitive and is stored in upper case regardless of input case.
        /// </summary>
        [JsonProperty(PropertyName = "netbios_name", Required = Required.AllowNull)]
        public string NetbiosName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "selective_sync_settings")]
        public NSXTSelectiveSyncSettingsType SelectiveSyncSettings { get; set; }
    }
}
