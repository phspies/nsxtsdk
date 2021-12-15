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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Aggregate statistics of all the rules in a security policy.
    /// </summary>
    [NSXTProperty(Description: @"Aggregate statistics of all the rules in a security policy.")]
    public class NSXTSecurityPolicyStatisticsType 
    {
        /// <summary>
        /// Realized id of the section on NSX MP. Policy Manager can create more than
        /// one section per SecurityPolicy, in which case this identifier helps to
        /// distinguish between the multiple sections created.
        /// </summary>
        [JsonProperty(PropertyName = "internal_section_id")]
        [NSXTProperty(IsRequired: false, Description: @"Realized id of the section on NSX MP. Policy Manager can create more thanone section per SecurityPolicy, in which case this identifier helps todistinguish between the multiple sections created.")]
        public string? InternalSectionId { get; set; }
        /// <summary>
        /// Total count for rule statistics
        /// </summary>
        [JsonProperty(PropertyName = "result_count")]
        [NSXTProperty(IsRequired: false, Description: @"Total count for rule statistics")]
        public long? ResultCount { get; set; }
        /// <summary>
        /// List of rule statistics.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        [NSXTProperty(IsRequired: false, Description: @"List of rule statistics.")]
        public IList<NSXTRuleStatisticsType> Results { get; set; }
        /// <summary>
        /// Path of the LR on which the section is applied in case of Gateway Firewall.
        /// </summary>
        [JsonProperty(PropertyName = "lr_path")]
        [NSXTProperty(IsRequired: false, Description: @"Path of the LR on which the section is applied in case of Gateway Firewall.")]
        public string? LrPath { get; set; }
    }
}