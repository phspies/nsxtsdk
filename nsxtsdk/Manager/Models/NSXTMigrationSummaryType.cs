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
    public class NSXTMigrationSummaryType 
    {
        /// <summary>
        /// Target system version
        /// </summary>
        [JsonProperty(PropertyName = "target_version")]
        public string? TargetVersion { get; set; }
        /// <summary>
        /// Status of migration
        /// </summary>
        [JsonProperty(PropertyName = "migration_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMigrationSummaryMigrationStatusEnumType? MigrationStatus { get; set; }
        /// <summary>
        /// Current version of migration coordinator
        /// </summary>
        [JsonProperty(PropertyName = "migration_coordinator_version")]
        public string? MigrationCoordinatorVersion { get; set; }
        /// <summary>
        /// Current system version
        /// </summary>
        [JsonProperty(PropertyName = "system_version")]
        public string? SystemVersion { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "component_target_versions")]
        public IList<NSXTComponentTargetVersionType> ComponentTargetVersions { get; set; }
    }
}
