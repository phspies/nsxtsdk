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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTFirewallSectionsSummaryType : NSXTResourceType
    {
        /// <summary>
        /// Total number of sections for the section type.
        /// </summary>
        [JsonProperty(PropertyName = "section_count")]
        [NSXTProperty(IsRequired: false, Description: @"Total number of sections for the section type.")]
        public long? SectionCount { get; set; }
        /// <summary>
        /// Total number of rules in the section.
        /// </summary>
        [JsonProperty(PropertyName = "rule_count")]
        [NSXTProperty(IsRequired: false, Description: @"Total number of rules in the section.")]
        public long? RuleCount { get; set; }
        /// <summary>
        /// Type of rules which a section can contain.
        /// </summary>
        [JsonProperty(PropertyName = "section_type")]
        [NSXTProperty(IsRequired: false, Description: @"Type of rules which a section can contain.")]
        public NSXTFirewallSectionsSummarySectionTypeEnumType? SectionType { get; set; }
    }
}