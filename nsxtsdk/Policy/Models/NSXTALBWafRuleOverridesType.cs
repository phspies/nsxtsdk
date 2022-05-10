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
    /// Advanced load balancer WafRuleOverrides object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer WafRuleOverrides object")]
    public class NSXTALBWafRuleOverridesType 
    {
        /// <summary>
        /// Replace the exclude list for this rule.
        /// Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_list")]
        public IList<NSXTALBWafExcludeListEntryType> ExcludeList { get; set; }
        /// <summary>
        /// Override the enable flag for this rule.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Override the waf mode for this rule.
        /// Enum options - WAF_MODE_DETECTION_ONLY,
        /// WAF_MODE_ENFORCEMENT.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbwafRuleOverridesModeEnumType? Mode { get; set; }
        /// <summary>
        /// The rule_id of the rule where attributes are overridden.
        /// </summary>
        [JsonProperty(PropertyName = "rule_id", Required = Required.AllowNull)]
        public string RuleId { get; set; }
    }
}
