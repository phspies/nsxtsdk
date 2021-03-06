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
    /// Advanced load balancer WafPSMRule object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer WafPSMRule object")]
    public class NSXTALBWafPSMRuleType 
    {
        /// <summary>
        /// Rule index, this is used to determine the order of the
        /// rules.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        public long Index { get; set; }
        /// <summary>
        /// Enable or disable this rule.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Free-text comment about this rule.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// A regular expression which describes the expected value.
        /// </summary>
        [JsonProperty(PropertyName = "match_value_pattern")]
        public string? MatchValuePattern { get; set; }
        /// <summary>
        /// The match elements, for example ARGS id or ARGS|!ARGS
        /// password.
        /// Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "match_elements")]
        public IList<NSXTALBWafPSMMatchElementType> MatchElements { get; set; }
        /// <summary>
        /// WAF Rule mode.
        /// This can be detection or enforcement.
        /// If this is not set, the Policy mode is used.
        /// This only takes effect if the policy allows delegation.
        /// Enum options - WAF_MODE_DETECTION_ONLY,
        /// WAF_MODE_ENFORCEMENT.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbwafPsmruleModeEnumType? Mode { get; set; }
        /// <summary>
        /// The field match_value_pattern regular expression is case
        /// sensitive.
        /// Enum options - SENSITIVE, INSENSITIVE.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as INSENSITIVE.
        /// </summary>
        [JsonProperty(PropertyName = "match_case")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbwafPsmruleMatchCaseEnumType? MatchCase { get; set; }
        /// <summary>
        /// The maximum allowed length of the match_value.
        /// If this is not set, the length will not be checked.
        /// </summary>
        [JsonProperty(PropertyName = "match_value_max_length")]
        public long? MatchValueMaxLength { get; set; }
        /// <summary>
        /// WAF Ruleset paranoia mode.
        /// This is used to select Rules based on the paranoia-level.
        /// Enum options - WAF_PARANOIA_LEVEL_LOW,
        /// WAF_PARANOIA_LEVEL_MEDIUM, WAF_PARANOIA_LEVEL_HIGH,
        /// WAF_PARANOIA_LEVEL_EXTREME.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as WAF_PARANOIA_LEVEL_LOW.
        /// </summary>
        [JsonProperty(PropertyName = "paranoia_level")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbwafPsmruleParanoiaLevelEnumType? ParanoiaLevel { get; set; }
        /// <summary>
        /// Id field which is used for log and metric generation.
        /// This id must be unique for all rules in this group.
        /// </summary>
        [JsonProperty(PropertyName = "rule_id", Required = Required.AllowNull)]
        public string RuleId { get; set; }
        /// <summary>
        /// Name of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
    }
}
