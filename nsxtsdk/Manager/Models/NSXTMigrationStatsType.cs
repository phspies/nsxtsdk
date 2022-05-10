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
    /// Provide stats about ongoing MP2Policy promotion.
    /// </summary>
    [NSXTProperty(Description: @"Provide stats about ongoing MP2Policy promotion.")]
    public class NSXTMigrationStatsType 
    {
        /// <summary>
        /// Total mp resource count
        /// </summary>
        [JsonProperty(PropertyName = "total_count")]
        public string? TotalCount { get; set; }
        /// <summary>
        /// Promotion status
        /// </summary>
        [JsonProperty(PropertyName = "promotion_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMigrationStatsPromotionStatusEnumType? PromotionStatus { get; set; }
        /// <summary>
        /// failed mp resource count
        /// </summary>
        [JsonProperty(PropertyName = "failed_objects_count")]
        public string? FailedObjectsCount { get; set; }
        /// <summary>
        /// Resource type
        /// </summary>
        [JsonProperty(PropertyName = "resource_type")]
        public string? ResourceType { get; set; }
        /// <summary>
        /// promoted mp resource count
        /// </summary>
        [JsonProperty(PropertyName = "promoted_objects_count")]
        public string? PromotedObjectsCount { get; set; }
    }
}
