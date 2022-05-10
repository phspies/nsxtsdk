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
    /// List of MPPolicyPromotionHistory.
    /// </summary>
    [NSXTProperty(Description: @"List of MPPolicyPromotionHistory.")]
    public class NSXTMPPolicyPromotionHistoryListType 
    {
        /// <summary>
        /// Array of MPPolicyPromotionHistory.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<NSXTMPPolicyPromotionHistoryType> Results { get; set; }
    }
}
