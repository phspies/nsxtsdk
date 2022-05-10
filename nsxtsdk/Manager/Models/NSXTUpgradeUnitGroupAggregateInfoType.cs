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
    public class NSXTUpgradeUnitGroupAggregateInfoType : NSXTManagedResourceType
    {
        /// <summary>
        /// Upgrade status of upgrade unit group
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUpgradeUnitGroupAggregateInfoStatusEnumType? Status { get; set; }
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
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "post_upgrade_status")]
        public NSXTUpgradeChecksExecutionStatusType PostUpgradeStatus { get; set; }
        /// <summary>
        /// Flag to indicate whether upgrade of this group is enabled or not
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// List of upgrade units in the group
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_units")]
        public IList<NSXTUpgradeUnitType> UpgradeUnits { get; set; }
        /// <summary>
        /// Extended configuration for the group
        /// </summary>
        [JsonProperty(PropertyName = "extended_configuration")]
        public IList<NSXTKeyValuePairType> ExtendedConfiguration { get; set; }
        /// <summary>
        /// Indicator of upgrade progress in percentage
        /// </summary>
        [JsonProperty(PropertyName = "percent_complete")]
        public double? PercentComplete { get; set; }
        /// <summary>
        /// Component type
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public string Type { get; set; }
        /// <summary>
        /// Upgrade method to specify whether the upgrade is to be performed in parallel or serially
        /// </summary>
        [JsonProperty(PropertyName = "parallel")]
        public bool? Parallel { get; set; }
        /// <summary>
        /// Reports failures that occured at the group or cluster level.
        /// </summary>
        [JsonProperty(PropertyName = "group_level_failure")]
        public IList<string> GroupLevelFailure { get; set; }
    }
}
