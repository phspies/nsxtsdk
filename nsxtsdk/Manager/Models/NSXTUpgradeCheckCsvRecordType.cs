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
    public class NSXTUpgradeCheckCsvRecordType : NSXTCsvRecordType
    {
        /// <summary>
        /// Status of the pre/post-upgrade check
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUpgradeCheckCsvRecordStatusEnumType? Status { get; set; }
        /// <summary>
        /// Description of the pre/post-upgrade check
        /// </summary>
        [JsonProperty(PropertyName = "check_description")]
        public string? CheckDescription { get; set; }
        /// <summary>
        /// Space-separated list of failure messages
        /// </summary>
        [JsonProperty(PropertyName = "failure_messages")]
        public string? FailureMessages { get; set; }
        /// <summary>
        /// Display name of the pre/post-upgrade check
        /// </summary>
        [JsonProperty(PropertyName = "check_name", Required = Required.AllowNull)]
        public string CheckName { get; set; }
        /// <summary>
        /// Identifier of the upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_unit_id")]
        public string? UpgradeUnitId { get; set; }
        /// <summary>
        /// Meta-data of the upgrade-unit
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_unit_metadata")]
        public string? UpgradeUnitMetadata { get; set; }
        /// <summary>
        /// Component type of the upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_unit_type", Required = Required.AllowNull)]
        public string UpgradeUnitType { get; set; }
    }
}
