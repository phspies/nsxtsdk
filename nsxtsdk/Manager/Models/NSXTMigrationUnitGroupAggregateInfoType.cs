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
    public class NSXTMigrationUnitGroupAggregateInfoType : NSXTManagedResourceType
    {
        /// <summary>
        /// Migration status of migration unit group
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMigrationUnitGroupAggregateInfoStatusEnumType? Status { get; set; }
        /// <summary>
        /// Number of nodes in the migration unit group that failed migration
        /// </summary>
        [JsonProperty(PropertyName = "failed_count")]
        public int? FailedCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "group", Required = Required.AllowNull)]
        public NSXTMigrationUnitGroupType Group { get; set; }
        /// <summary>
        /// Indicator of migration progress in percentage
        /// </summary>
        [JsonProperty(PropertyName = "percent_complete")]
        public double? PercentComplete { get; set; }
    }
}
