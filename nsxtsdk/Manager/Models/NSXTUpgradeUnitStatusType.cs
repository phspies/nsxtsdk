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
    public class NSXTUpgradeUnitStatusType 
    {
        /// <summary>
        /// Status of upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUpgradeUnitStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// List of errors occurred during upgrade of this upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<string> Errors { get; set; }
        /// <summary>
        /// Name of upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Indicator of upgrade progress in percentage
        /// </summary>
        [JsonProperty(PropertyName = "percent_complete")]
        public double? PercentComplete { get; set; }
        /// <summary>
        /// Identifier of upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Metadata about upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<NSXTKeyValuePairType> Metadata { get; set; }
    }
}
