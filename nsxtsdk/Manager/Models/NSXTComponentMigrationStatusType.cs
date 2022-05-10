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
    public class NSXTComponentMigrationStatusType 
    {
        /// <summary>
        /// Migration status of component
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTComponentMigrationStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Indicator of migration progress in percentage
        /// </summary>
        [JsonProperty(PropertyName = "percent_complete")]
        public double? PercentComplete { get; set; }
        /// <summary>
        /// Can the migration of the remaining units in this component be skipped
        /// </summary>
        [JsonProperty(PropertyName = "can_skip")]
        public bool? CanSkip { get; set; }
        /// <summary>
        /// Details about the migration status
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string? Details { get; set; }
        /// <summary>
        /// Component type for the migration status
        /// </summary>
        [JsonProperty(PropertyName = "component_type")]
        public string? ComponentType { get; set; }
    }
}
