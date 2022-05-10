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
    public class NSXTUpgradeHistoryType 
    {
        /// <summary>
        /// Timestamp (in milliseconds since epoch) when the upgrade was performed
        /// </summary>
        [JsonProperty(PropertyName = "timestamp", Required = Required.AllowNull)]
        public long Timestamp { get; set; }
        /// <summary>
        /// Version being upgraded to
        /// </summary>
        [JsonProperty(PropertyName = "target_version", Required = Required.AllowNull)]
        public string TargetVersion { get; set; }
        /// <summary>
        /// Version before the upgrade started
        /// </summary>
        [JsonProperty(PropertyName = "initial_version", Required = Required.AllowNull)]
        public string InitialVersion { get; set; }
        /// <summary>
        /// Status of the upgrade
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUpgradeHistoryUpgradeStatusEnumType UpgradeStatus { get; set; }
    }
}
