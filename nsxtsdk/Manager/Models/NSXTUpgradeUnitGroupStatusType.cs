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
    public class NSXTUpgradeUnitGroupStatusType 
    {
        /// <summary>
        /// Upgrade status of upgrade unit group
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUpgradeUnitGroupStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Number of upgrade units in the group
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_unit_count")]
        public int? UpgradeUnitCount { get; set; }
        /// <summary>
        /// Number of nodes in the upgrade unit group that failed upgrade
        /// </summary>
        [JsonProperty(PropertyName = "failed_count")]
        public int? FailedCount { get; set; }
        /// <summary>
        /// Indicator of upgrade progress in percentage
        /// </summary>
        [JsonProperty(PropertyName = "percent_complete")]
        public double? PercentComplete { get; set; }
        /// <summary>
        /// Identifier for upgrade unit group
        /// </summary>
        [JsonProperty(PropertyName = "group_id")]
        public string? GroupId { get; set; }
        /// <summary>
        /// Name of the upgrade unit group
        /// </summary>
        [JsonProperty(PropertyName = "group_name")]
        public string? GroupName { get; set; }
    }
}
