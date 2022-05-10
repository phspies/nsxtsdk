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
    public class NSXTFirewallRuleType : NSXTDSRuleType
    {
        /// <summary>
        /// List of the services. Null will be treated as any.
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public IList<NSXTFirewallServiceType> Services { get; set; }
        /// <summary>
        /// NS Profile object which accepts attributes and sub-attributes of various network services (ex. L7 AppId, domain name,
        /// encryption algorithm) as key value pairs.
        /// </summary>
        [JsonProperty(PropertyName = "context_profiles")]
        public IList<NSXTResourceReferenceType> ContextProfiles { get; set; }
        /// <summary>
        /// List of NSGroups that have end point attributes like AD Groups(SID), process name, process hash etc. For Flash release,
        /// only NSGroups containing AD Groups are supported.
        /// </summary>
        [JsonProperty(PropertyName = "extended_sources")]
        public IList<NSXTResourceReferenceType> ExtendedSources { get; set; }
        /// <summary>
        /// Section Id of the section to which this rule belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "section_id")]
        public string? SectionId { get; set; }
    }
}
