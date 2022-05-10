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
    public class NSXTRealizedFirewallSectionType : NSXTRealizedFirewallType
    {
        /// <summary>
        /// List of firewall rules in the section.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTRealizedFirewallRuleType> Rules { get; set; }
        /// <summary>
        /// Number of rules in this section.
        /// </summary>
        [JsonProperty(PropertyName = "rule_count")]
        public long? RuleCount { get; set; }
        /// <summary>
        /// Type of the rules which a section can contain.
        /// </summary>
        [JsonProperty(PropertyName = "section_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRealizedFirewallSectionSectionTypeEnumType? SectionType { get; set; }
    }
}
