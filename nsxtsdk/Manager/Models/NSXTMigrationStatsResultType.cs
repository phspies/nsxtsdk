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
    public class NSXTMigrationStatsResultType 
    {
        /// <summary>
        /// Count of all objects being promoted. It is equal to sum of total_count for each
        /// resource type.
        /// </summary>
        [JsonProperty(PropertyName = "total_count")]
        public long? TotalCount { get; set; }
        /// <summary>
        /// This field used by UI which highlights the current resource type in promotion.
        /// </summary>
        [JsonProperty(PropertyName = "current_resource_type_in_promotion")]
        public string? CurrentResourceTypeInPromotion { get; set; }
        /// <summary>
        /// Promotion stats list results.
        /// </summary>
        [JsonProperty(PropertyName = "migration_stats")]
        public IList<NSXTMigrationStatsType> MigrationStats { get; set; }
    }
}
