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
    public class NSXTFirewallSectionsSummaryType : NSXTResourceType
    {
        /// <summary>
        /// Total number of sections for the section type.
        /// </summary>
        [JsonProperty(PropertyName = "section_count")]
        public long? SectionCount { get; set; }
        /// <summary>
        /// Total number of rules in the section.
        /// </summary>
        [JsonProperty(PropertyName = "rule_count")]
        public long? RuleCount { get; set; }
        /// <summary>
        /// Type of rules which a section can contain.
        /// </summary>
        [JsonProperty(PropertyName = "section_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFirewallSectionsSummarySectionTypeEnumType? SectionType { get; set; }
    }
}
