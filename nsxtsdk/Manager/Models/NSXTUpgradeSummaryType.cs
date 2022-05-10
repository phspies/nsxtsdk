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
    public class NSXTUpgradeSummaryType 
    {
        /// <summary>
        /// Has upgrade coordinator been updated after upload of upgrade bundle file
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_coordinator_updated")]
        public bool? UpgradeCoordinatorUpdated { get; set; }
        /// <summary>
        /// Target system version
        /// </summary>
        [JsonProperty(PropertyName = "target_version")]
        public string? TargetVersion { get; set; }
        /// <summary>
        /// Current version of upgrade coordinator
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_coordinator_version")]
        public string? UpgradeCoordinatorVersion { get; set; }
        /// <summary>
        /// Status of upgrade
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUpgradeSummaryUpgradeStatusEnumType? UpgradeStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "component_target_versions")]
        public IList<NSXTComponentTargetVersionType> ComponentTargetVersions { get; set; }
        /// <summary>
        /// Current system version
        /// </summary>
        [JsonProperty(PropertyName = "system_version")]
        public string? SystemVersion { get; set; }
        /// <summary>
        /// Name of the last successfully uploaded upgrade bundle file
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_bundle_file_name")]
        public string? UpgradeBundleFileName { get; set; }
    }
}
