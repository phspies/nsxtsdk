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
    public class NSXTVMTagReplicationPolicyType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Paths of groups (VM tag-based, VM name-based, etc.) that translates into VMs
        /// to be replicated from protected site to recovery sites.
        /// If no group is specified, none of the VM tag will be replicated from protected
        /// site to recovery sites.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<string> Groups { get; set; }
        /// <summary>
        /// Matching criteria used for associating VMs from protected site to VMs
        /// on recovery sites.
        /// - MATCH_NSX_ATTACHMENT_ID : Associate VMs from the protected site and
        /// recovery sites based on NSX attachment ID.
        /// - MATCH_BIOS_UUID_NAME : Associate VMs from the protected site and
        /// recovery sites based on (VM BIOS UUID + VM Name).
        /// </summary>
        [JsonProperty(PropertyName = "vm_match_criteria")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTVmtagReplicationPolicyVmMatchCriteriaEnumType? VmMatchCriteria { get; set; }
        /// <summary>
        /// A path of protected site, from where tags of selected VMs will be
        /// replicated to recovery sites.
        /// </summary>
        [JsonProperty(PropertyName = "protected_site", Required = Required.AllowNull)]
        public string ProtectedSite { get; set; }
        /// <summary>
        /// Paths of recovery sites, where tags of selected VMs will be replicated
        /// to, from protected site.
        /// </summary>
        [JsonProperty(PropertyName = "recovery_sites", Required = Required.AllowNull)]
        public IList<string> RecoverySites { get; set; }
    }
}
