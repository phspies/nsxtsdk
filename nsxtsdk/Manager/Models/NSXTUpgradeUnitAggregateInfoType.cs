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
    public class NSXTUpgradeUnitAggregateInfoType : NSXTResourceType
    {
        /// <summary>
        /// Status of upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUpgradeUnitAggregateInfoStatusEnumType? Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pre_upgrade_checks")]
        public NSXTUpgradeCheckListResultsType PreUpgradeChecks { get; set; }
        /// <summary>
        /// List of errors occurred during upgrade of this upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<string> Errors { get; set; }
        /// <summary>
        /// Name of the upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "post_upgrade_checks")]
        public NSXTUpgradeCheckListResultsType PostUpgradeChecks { get; set; }
        /// <summary>
        /// List of warnings indicating issues with the upgrade unit that may result in upgrade failure
        /// </summary>
        [JsonProperty(PropertyName = "warnings")]
        public IList<string> Warnings { get; set; }
        /// <summary>
        /// This is component version e.g. if upgrade unit is of type edge, then this is edge version.
        /// </summary>
        [JsonProperty(PropertyName = "current_version")]
        public string? CurrentVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public NSXTUpgradeUnitGroupInfoType Group { get; set; }
        /// <summary>
        /// Indicator of upgrade progress in percentage
        /// </summary>
        [JsonProperty(PropertyName = "percent_complete")]
        public double? PercentComplete { get; set; }
        /// <summary>
        /// Upgrade unit type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// Identifier of the upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Metadata about upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<NSXTKeyValuePairType> Metadata { get; set; }
    }
}
