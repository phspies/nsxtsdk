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
    /// Advanced load balancer WafRule object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer WafRule object")]
    public class NSXTALBWafRuleType 
    {
        /// <summary>
        /// Exclude list for the WAF rule.
        /// The fields in the exclude list entry are logically and'ed
        /// to deduce the exclusion criteria.
        /// If there are multiple excludelist entries, it will be
        /// 'logical or' of them.
        /// Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "exclude_list")]
        public IList<NSXTALBWafExcludeListEntryType> ExcludeList { get; set; }
        /// <summary>
        /// Enable or disable WAF Rule Group.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// User-friendly optional name for a rule.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Tags for WAF rule as per Modsec language.
        /// They are extracted from the tag actions in a Modsec rule.
        /// This field is generated from the rule itself and cannot be
        /// set by the user.
        /// Maximum of 64 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "avi_tags")]
        public IList<string> AviTags { get; set; }
        /// <summary>
        /// Number of index.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        public long Index { get; set; }
        /// <summary>
        /// The execution phase where this rule will be executed.
        /// Enum options - WAF_PHASE_CONNECTION,
        /// WAF_PHASE_REQUEST_HEADER, WAF_PHASE_REQUEST_BODY,
        /// WAF_PHASE_RESPONSE_HEADER, WAF_PHASE_RESPONSE_BODY,
        /// WAF_PHASE_LOGGING.
        /// </summary>
        [JsonProperty(PropertyName = "phase")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbwafRulePhaseEnumType? Phase { get; set; }
        /// <summary>
        /// The rule field is sensitive and will not be displayed.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "is_sensitive")]
        public bool? IsSensitive { get; set; }
        /// <summary>
        /// Identifier (id) for a rule per Modsec language.
        /// All SecRule and SecAction directives require an id.
        /// It is extracted from the id action in a Modsec rule.
        /// Rules within a single WAF Policy are required to have
        /// unique rule_ids.
        /// </summary>
        [JsonProperty(PropertyName = "rule_id")]
        public string? RuleId { get; set; }
        /// <summary>
        /// Rule as per Modsec language.
        /// </summary>
        [JsonProperty(PropertyName = "rule", Required = Required.AllowNull)]
        public string Rule { get; set; }
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
        public NSXTAlbwafRuleModeEnumType? Mode { get; set; }
    }
}
