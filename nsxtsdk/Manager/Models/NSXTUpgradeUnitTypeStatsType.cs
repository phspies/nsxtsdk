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
    public class NSXTUpgradeUnitTypeStatsType 
    {
        /// <summary>
        /// Number of nodes with issues that may cause upgrade failure
        /// </summary>
        [JsonProperty(PropertyName = "node_with_issues_count")]
        public int? NodeWithIssuesCount { get; set; }
        /// <summary>
        /// Number of nodes
        /// </summary>
        [JsonProperty(PropertyName = "node_count")]
        public int? NodeCount { get; set; }
        /// <summary>
        /// Version of the upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
        /// <summary>
        /// Type of upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// UpgradeUnit sub type
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_unit_subtype")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUpgradeUnitTypeStatsUpgradeUnitSubtypeEnumType? UpgradeUnitSubtype { get; set; }
    }
}
