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
    /// Provides information if system is currently going under mp policy promotion.
    /// </summary>
    [NSXTProperty(Description: @"Provides information if system is currently going under mp policy promotion.")]
    public class NSXTMPPolicyPromotionStateType 
    {
        /// <summary>
        /// Used to get the mp policy promotion state. If system is under mp to policy promotion, it will be PROMOTION_IN_PROGRESS
        /// else PROMOTION_NOT_IN_PROGRESS.State is CANCELLING_PROMOTION, if ongoing promotion is cancelled.
        /// </summary>
        [JsonProperty(PropertyName = "mp_policy_promotion", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMppolicyPromotionStateMpPolicyPromotionEnumType MpPolicyPromotion { get; set; }
    }
}
