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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTComponentUpgradeStatusType 
    {
        /// <summary>
        /// Upgrade status of component
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTComponentUpgradeStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pre_upgrade_status")]
        public NSXTUpgradeChecksExecutionStatusType PreUpgradeStatus { get; set; }
        /// <summary>
        /// Details about the upgrade status
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string? Details { get; set; }
        /// <summary>
        /// Component type for the upgrade status
        /// </summary>
        [JsonProperty(PropertyName = "component_type")]
        public string? ComponentType { get; set; }
        /// <summary>
        /// Number of nodes of the type and at the component version
        /// </summary>
        [JsonProperty(PropertyName = "node_count_at_target_version")]
        public int? NodeCountAtTargetVersion { get; set; }
        /// <summary>
        /// Target component version
        /// </summary>
        [JsonProperty(PropertyName = "target_component_version")]
        public string? TargetComponentVersion { get; set; }
        /// <summary>
        /// Indicator of upgrade progress in percentage
        /// </summary>
        [JsonProperty(PropertyName = "percent_complete")]
        public double? PercentComplete { get; set; }
        /// <summary>
        /// Can the upgrade of the remaining units in this component be skipped
        /// </summary>
        [JsonProperty(PropertyName = "can_skip")]
        public bool? CanSkip { get; set; }
        /// <summary>
        /// This field indicates whether we can perform upgrade rollback.
        /// </summary>
        [JsonProperty(PropertyName = "can_rollback")]
        public bool? CanRollback { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "current_version_node_summary")]
        public NSXTNodeSummaryListType CurrentVersionNodeSummary { get; set; }
    }
}
