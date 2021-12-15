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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTFederationComponentUpgradeStatusType 
    {
        /// <summary>
        /// Upgrade status of component
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"Upgrade status of component")]
        public NSXTFederationComponentUpgradeStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Target component version
        /// </summary>
        [JsonProperty(PropertyName = "target_version")]
        [NSXTProperty(IsRequired: false, Description: @"Target component version")]
        public string? TargetVersion { get; set; }
        /// <summary>
        /// Details about the upgrade status
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        [NSXTProperty(IsRequired: false, Description: @"Details about the upgrade status")]
        public string? Details { get; set; }
        /// <summary>
        /// Component type for the upgrade status
        /// </summary>
        [JsonProperty(PropertyName = "component_type")]
        [NSXTProperty(IsRequired: false, Description: @"Component type for the upgrade status")]
        public string? ComponentType { get; set; }
        /// <summary>
        /// Indicator of upgrade progress in percentage
        /// </summary>
        [JsonProperty(PropertyName = "percent_complete")]
        [NSXTProperty(IsRequired: false, Description: @"Indicator of upgrade progress in percentage")]
        public double? PercentComplete { get; set; }
        /// <summary>
        /// Mapping of current versions of nodes and counts of nodes at the respective versions.
        /// </summary>
        [JsonProperty(PropertyName = "current_version_node_summary")]
        [NSXTProperty(IsRequired: false, Description: @"Mapping of current versions of nodes and counts of nodes at the respective versions.")]
        public IList<NSXTFederationNodeSummaryType> CurrentVersionNodeSummary { get; set; }
    }
}