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
    public class NSXTMigrationStatusType 
    {
        /// <summary>
        /// Status of migration
        /// </summary>
        [JsonProperty(PropertyName = "overall_migration_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMigrationStatusOverallMigrationStatusEnumType? OverallMigrationStatus { get; set; }
        /// <summary>
        /// List of component statuses
        /// </summary>
        [JsonProperty(PropertyName = "component_status")]
        public IList<NSXTComponentMigrationStatusType> ComponentStatus { get; set; }
    }
}
