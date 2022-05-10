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
    public class NSXTSelectiveSyncSettingsType : NSXTListResultType
    {
        /// <summary>
        /// Enable or disable SelectiveSync
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
        /// <summary>
        /// If SelectiveSync is enabled, this contains 1 or more
        /// OrgUnits, which NSX will synchronize with in LDAP server.
        /// The full distiguished name (DN) should be used for OrgUnit.
        /// If SelectiveSync is disabled, do not define this or specify an
        /// empty list.
        /// </summary>
        [JsonProperty(PropertyName = "selected_org_units")]
        public IList<string> SelectedOrgUnits { get; set; }
    }
}
