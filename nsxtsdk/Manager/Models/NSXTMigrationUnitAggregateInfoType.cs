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
    public class NSXTMigrationUnitAggregateInfoType : NSXTResourceType
    {
        /// <summary>
        /// Status of migration unit
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMigrationUnitAggregateInfoStatusEnumType? Status { get; set; }
        /// <summary>
        /// Indicator of migration progress in percentage
        /// </summary>
        [JsonProperty(PropertyName = "percent_complete")]
        public double? PercentComplete { get; set; }
        /// <summary>
        /// List of errors occurred during migration of this migration unit
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<string> Errors { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public NSXTMigrationUnitType Unit { get; set; }
    }
}
