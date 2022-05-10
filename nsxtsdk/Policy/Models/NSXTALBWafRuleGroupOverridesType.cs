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
    /// Advanced load balancer WafRuleGroupOverrides object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer WafRuleGroupOverrides object")]
    public class NSXTALBWafRuleGroupOverridesType 
    {
        /// <summary>
        /// Replace the exclude list for this group.
        /// Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_list")]
        public IList<NSXTALBWafExcludeListEntryType> ExcludeList { get; set; }
        /// <summary>
        /// Override the enable flag for this group.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Override the waf mode for this group.
        /// Enum options - WAF_MODE_DETECTION_ONLY,
        /// WAF_MODE_ENFORCEMENT.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbwafRuleGroupOverridesModeEnumType? Mode { get; set; }
        /// <summary>
        /// Rule specific overrides.
        /// Maximum of 1024 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "rule_overrides")]
        public IList<NSXTALBWafRuleOverridesType> RuleOverrides { get; set; }
        /// <summary>
        /// The name of the group where attributes or rules are
        /// overridden.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
    }
}
