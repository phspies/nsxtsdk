// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        [NSXTProperty(IsRequired: false, Description: @"Status of migration unit")]
        public NSXTMigrationUnitAggregateInfoStatusEnumType? Status { get; set; }
        /// <summary>
        /// Indicator of migration progress in percentage
        /// </summary>
        [JsonProperty(PropertyName = "percent_complete")]
        [NSXTProperty(IsRequired: false, Description: @"Indicator of migration progress in percentage")]
        public double? PercentComplete { get; set; }
        /// <summary>
        /// List of errors occurred during migration of this migration unit
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        [NSXTProperty(IsRequired: false, Description: @"List of errors occurred during migration of this migration unit")]
        public IList<string> Errors { get; set; }
        /// <summary>
        /// Details of the migration unit
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        [NSXTProperty(IsRequired: false, Description: @"Details of the migration unit")]
        public NSXTMigrationUnitType Unit { get; set; }
    }
}
