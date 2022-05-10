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
    public class NSXTALBWafPolicyType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "learning_params")]
        public NSXTALBAppLearningParamsType LearningParams { get; set; }
        /// <summary>
        /// Minimum confidence label required for auto rule updates.
        /// Enum options - CONFIDENCE_VERY_HIGH, CONFIDENCE_HIGH,
        /// CONFIDENCE_PROBABLE, CONFIDENCE_LOW, CONFIDENCE_NONE.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as CONFIDENCE_VERY_HIGH.
        /// </summary>
        [JsonProperty(PropertyName = "min_confidence")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbwafPolicyMinConfidenceEnumType? MinConfidence { get; set; }
        /// <summary>
        /// WAF Policy failure mode.
        /// This can be 'Open' or 'Closed'.
        /// Enum options - WAF_FAILURE_MODE_OPEN,
        /// WAF_FAILURE_MODE_CLOSED.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as WAF_FAILURE_MODE_OPEN.
        /// </summary>
        [JsonProperty(PropertyName = "failure_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbwafPolicyFailureModeEnumType? FailureMode { get; set; }
        /// <summary>
        /// Enable Application Learning based rule updates on the WAF
        /// Profile.
        /// Rules will be programmed in dedicated WAF learning group.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "enable_auto_rule_updates")]
        public bool? EnableAutoRuleUpdates { get; set; }
        /// <summary>
        /// WAF Rules are categorized in to groups based on their
        /// characterization.
        /// These groups are created by the user and will be  enforced
        /// before the CRS groups.
        /// </summary>
        [JsonProperty(PropertyName = "pre_crs_groups")]
        public IList<NSXTALBWafRuleGroupType> PreCrsGroups { get; set; }
        /// <summary>
        /// WAF Rules are categorized in to groups based on their
        /// characterization.
        /// These groups are created by the user and will be enforced
        /// after the CRS groups.
        /// </summary>
        [JsonProperty(PropertyName = "post_crs_groups")]
        public IList<NSXTALBWafRuleGroupType> PostCrsGroups { get; set; }
        /// <summary>
        /// Override attributes for CRS rules.
        /// </summary>
        [JsonProperty(PropertyName = "crs_overrides")]
        public IList<NSXTALBWafRuleGroupOverridesType> CrsOverrides { get; set; }
        /// <summary>
        /// Allow Rules to overwrite the policy mode.
        /// This must be set if the policy mode is set to enforcement.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "allow_mode_delegation")]
        public bool? AllowModeDelegation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "application_signatures")]
        public NSXTALBWafApplicationSignaturesType ApplicationSignatures { get; set; }
        /// <summary>
        /// WAF core ruleset used for the CRS part of this Policy.
        /// It is a reference to an object of type WafCRS.
        /// </summary>
        [JsonProperty(PropertyName = "waf_crs_path")]
        public string? WafCrsPath { get; set; }
        /// <summary>
        /// WAF Ruleset paranoia  mode.
        /// This is used to select Rules based on the paranoia-level
        /// tag.
        /// Enum options - WAF_PARANOIA_LEVEL_LOW,
        /// WAF_PARANOIA_LEVEL_MEDIUM, WAF_PARANOIA_LEVEL_HIGH,
        /// WAF_PARANOIA_LEVEL_EXTREME.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as WAF_PARANOIA_LEVEL_LOW.
        /// </summary>
        [JsonProperty(PropertyName = "paranoia_level")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbwafPolicyParanoiaLevelEnumType? ParanoiaLevel { get; set; }
        /// <summary>
        /// WAF Policy mode.
        /// This can be detection or enforcement.
        /// It can be overwritten by rules if allow_mode_delegation is
        /// set.
        /// Enum options - WAF_MODE_DETECTION_ONLY,
        /// WAF_MODE_ENFORCEMENT.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as WAF_MODE_DETECTION_ONLY.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbwafPolicyModeEnumType? Mode { get; set; }
        /// <summary>
        /// WAF Profile for WAF policy.
        /// It is a reference to an object of type WafProfile.
        /// </summary>
        [JsonProperty(PropertyName = "waf_profile_path", Required = Required.AllowNull)]
        public string WafProfilePath { get; set; }
        /// <summary>
        /// Enable Application Learning for this WAF policy.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enable_app_learning")]
        public bool? EnableAppLearning { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "positive_security_model")]
        public NSXTALBWafPositiveSecurityModelType PositiveSecurityModel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "confidence_override")]
        public NSXTALBAppLearningConfidenceOverrideType ConfidenceOverride { get; set; }
        /// <summary>
        /// Creator name.
        /// </summary>
        [JsonProperty(PropertyName = "created_by")]
        public string? CreatedBy { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
    }
}
