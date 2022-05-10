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
    public class NSXTDSSectionType : NSXTManagedResourceType
    {
        /// <summary>
        /// Stateful or Stateless nature of distributed service section is enforced on all rules inside the section. Layer3 sections
        /// can be stateful or stateless. Layer2 sections can only be stateless.
        /// </summary>
        [JsonProperty(PropertyName = "stateful", Required = Required.AllowNull)]
        public bool Stateful { get; set; }
        /// <summary>
        /// It is a boolean flag which reflects whether a distributed service section is default section or not. Each Layer 3 and
        /// Layer 2 section will have at least and at most one default section.
        /// </summary>
        [JsonProperty(PropertyName = "is_default")]
        public bool? IsDefault { get; set; }
        /// <summary>
        /// List of objects where the rules in this section will be enforced. This will take precedence over rule level appliedTo.
        /// </summary>
        [JsonProperty(PropertyName = "applied_tos")]
        public IList<NSXTResourceReferenceType> AppliedTos { get; set; }
        /// <summary>
        /// Number of rules in this section.
        /// </summary>
        [JsonProperty(PropertyName = "rule_count")]
        public long? RuleCount { get; set; }
        /// <summary>
        /// Type of the rules which a section can contain. Only homogeneous sections are supported.
        /// </summary>
        [JsonProperty(PropertyName = "section_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDssectionSectionTypeEnumType SectionType { get; set; }
    }
}
