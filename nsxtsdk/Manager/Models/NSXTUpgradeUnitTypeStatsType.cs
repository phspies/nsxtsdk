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
    public class NSXTUpgradeUnitTypeStatsType 
    {
        public NSXTUpgradeUnitTypeStatsType()
        {
        }
        /// <summary>
        /// Number of nodes with issues that may cause upgrade failure
        /// </summary>
        [JsonProperty(PropertyName = "node_with_issues_count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of nodes with issues that may cause upgrade failure")]
        public int? NodeWithIssuesCount { get; set; }
        /// <summary>
        /// Number of nodes
        /// </summary>
        [JsonProperty(PropertyName = "node_count")]
        [NSXTProperty(IsRequired: false, Description: @"Number of nodes")]
        public int? NodeCount { get; set; }
        /// <summary>
        /// Version of the upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        [NSXTProperty(IsRequired: false, Description: @"Version of the upgrade unit")]
        public string? Version { get; set; }
        /// <summary>
        /// Type of upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        [NSXTProperty(IsRequired: false, Description: @"Type of upgrade unit")]
        public string? Type { get; set; }
        /// <summary>
        /// UpgradeUnit sub type
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_unit_subtype")]
        [NSXTProperty(IsRequired: false, Description: @"UpgradeUnit sub type")]
        public NSXTUpgradeUnitTypeStatsUpgradeUnitSubtypeEnumType? UpgradeUnitSubtype { get; set; }
    }
}
