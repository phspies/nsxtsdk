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
    /// List of MPPolicyPromotionHistory.
    /// </summary>
    [NSXTProperty(Description: @"List of MPPolicyPromotionHistory.")]
    public class NSXTMPPolicyPromotionHistoryListType 
    {
        public NSXTMPPolicyPromotionHistoryListType()
        {
        }
        /// <summary>
        /// Array of MPPolicyPromotionHistory.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"Array of MPPolicyPromotionHistory.")]
        public IList<NSXTMPPolicyPromotionHistoryType> Results { get; set; }
    }
}
