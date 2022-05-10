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
    public class NSXTFederationComponentUpgradeStatusType 
    {
        /// <summary>
        /// Upgrade status of component
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFederationComponentUpgradeStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Target component version
        /// </summary>
        [JsonProperty(PropertyName = "target_version")]
        public string? TargetVersion { get; set; }
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
        /// Indicator of upgrade progress in percentage
        /// </summary>
        [JsonProperty(PropertyName = "percent_complete")]
        public double? PercentComplete { get; set; }
        /// <summary>
        /// Mapping of current versions of nodes and counts of nodes at the respective versions.
        /// </summary>
        [JsonProperty(PropertyName = "current_version_node_summary")]
        public IList<NSXTFederationNodeSummaryType> CurrentVersionNodeSummary { get; set; }
    }
}
