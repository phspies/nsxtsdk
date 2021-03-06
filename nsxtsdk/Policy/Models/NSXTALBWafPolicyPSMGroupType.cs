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
    public class NSXTALBWafPolicyPSMGroupType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Enable or disable this WAF rule group.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// This field indicates that this group is used for learning.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "is_learning_group")]
        public bool? IsLearningGroup { get; set; }
        /// <summary>
        /// If a rule in this group does not match the match_value
        /// pattern, this action will be executed.
        /// Allowed actions are WAF_ACTION_NO_OP and WAF_ACTION_BLOCK.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as WAF_ACTION_NO_OP.
        /// </summary>
        [JsonProperty(PropertyName = "miss_action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbwafPolicyPsmgroupMissActionEnumType? MissAction { get; set; }
        /// <summary>
        /// If a rule in this group matches the match_value pattern,
        /// this action will be executed.
        /// Allowed actions are WAF_ACTION_NO_OP and
        /// WAF_ACTION_ALLOW_PARAMETER.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as WAF_ACTION_ALLOW_PARAMETER.
        /// </summary>
        [JsonProperty(PropertyName = "hit_action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbwafPolicyPsmgroupHitActionEnumType? HitAction { get; set; }
        /// <summary>
        /// Positive Security Model locations.
        /// These are used to partition the application name space.
        /// Maximum of 16384 items allowed.
        /// </summary>
        [JsonProperty(PropertyName = "locations")]
        public IList<NSXTALBWafPSMLocationType> Locations { get; set; }
        /// <summary>
        /// List of labels to be used for granular RBAC.
        /// Allowed in Basic edition, Essentials edition, Enterprise
        /// edition.
        /// </summary>
        [JsonProperty(PropertyName = "markers")]
        public IList<NSXTALBRoleFilterMatchLabelType> Markers { get; set; }
    }
}
