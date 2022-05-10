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
    public class NSXTMigrationUnitGroupStatusType 
    {
        /// <summary>
        /// Migration status of migration unit group
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMigrationUnitGroupStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Number of nodes in the migration unit group that failed migration
        /// </summary>
        [JsonProperty(PropertyName = "failed_count")]
        public int? FailedCount { get; set; }
        /// <summary>
        /// Number of migration units in the group
        /// </summary>
        [JsonProperty(PropertyName = "migration_unit_count")]
        public int? MigrationUnitCount { get; set; }
        /// <summary>
        /// Identifier for migration unit group
        /// </summary>
        [JsonProperty(PropertyName = "group_id")]
        public string? GroupId { get; set; }
        /// <summary>
        /// Indicator of migration progress in percentage
        /// </summary>
        [JsonProperty(PropertyName = "percent_complete")]
        public double? PercentComplete { get; set; }
        /// <summary>
        /// Name of the migration unit group
        /// </summary>
        [JsonProperty(PropertyName = "group_name")]
        public string? GroupName { get; set; }
    }
}
