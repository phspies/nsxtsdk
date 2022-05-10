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
    public class NSXTMigrationUnitStatusType 
    {
        /// <summary>
        /// Status of migration unit
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMigrationUnitStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// List of errors occurred during migration of this migration unit
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<string> Errors { get; set; }
        /// <summary>
        /// Name of migration unit
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Identifier of migration unit
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Indicator of migration progress in percentage
        /// </summary>
        [JsonProperty(PropertyName = "percent_complete")]
        public double? PercentComplete { get; set; }
    }
}
