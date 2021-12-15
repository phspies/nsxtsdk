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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTComponentUpgradeStatusType 
    {
        /// <summary>
        /// Upgrade status of component
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"Upgrade status of component")]
        public NSXTComponentUpgradeStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Pre-upgrade status of the component-type
        /// </summary>
        [JsonProperty(PropertyName = "pre_upgrade_status")]
        [NSXTProperty(IsRequired: false, Description: @"Pre-upgrade status of the component-type")]
        public NSXTUpgradeChecksExecutionStatusType PreUpgradeStatus { get; set; }
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
        /// Number of nodes of the type and at the component version
        /// </summary>
        [JsonProperty(PropertyName = "node_count_at_target_version")]
        [NSXTProperty(IsRequired: false, Description: @"Number of nodes of the type and at the component version")]
        public int? NodeCountAtTargetVersion { get; set; }
        /// <summary>
        /// Target component version
        /// </summary>
        [JsonProperty(PropertyName = "target_component_version")]
        [NSXTProperty(IsRequired: false, Description: @"Target component version")]
        public string? TargetComponentVersion { get; set; }
        /// <summary>
        /// Indicator of upgrade progress in percentage
        /// </summary>
        [JsonProperty(PropertyName = "percent_complete")]
        [NSXTProperty(IsRequired: false, Description: @"Indicator of upgrade progress in percentage")]
        public double? PercentComplete { get; set; }
        /// <summary>
        /// Can the upgrade of the remaining units in this component be skipped
        /// </summary>
        [JsonProperty(PropertyName = "can_skip")]
        [NSXTProperty(IsRequired: false, Description: @"Can the upgrade of the remaining units in this component be skipped")]
        public bool? CanSkip { get; set; }
        /// <summary>
        /// Mapping of current versions of nodes and counts of nodes at the respective versions.
        /// </summary>
        [JsonProperty(PropertyName = "current_version_node_summary")]
        [NSXTProperty(IsRequired: false, Description: @"Mapping of current versions of nodes and counts of nodes at the respective versions.")]
        public NSXTNodeSummaryListType CurrentVersionNodeSummary { get; set; }
    }
}