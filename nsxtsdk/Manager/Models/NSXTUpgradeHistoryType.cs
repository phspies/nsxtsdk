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
    public class NSXTUpgradeHistoryType 
    {
        public NSXTUpgradeHistoryType()
        {
        }
        /// <summary>
        /// Timestamp (in milliseconds since epoch) when the upgrade was performed
        /// </summary>
        [JsonProperty(PropertyName = "timestamp", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Timestamp (in milliseconds since epoch) when the upgrade was performed")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Timestamp { get; set; }
        /// <summary>
        /// Version being upgraded to
        /// </summary>
        [JsonProperty(PropertyName = "target_version", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Version being upgraded to")]
        [System.ComponentModel.DataAnnotations.Required]
        public string TargetVersion { get; set; }
        /// <summary>
        /// Version before the upgrade started
        /// </summary>
        [JsonProperty(PropertyName = "initial_version", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Version before the upgrade started")]
        [System.ComponentModel.DataAnnotations.Required]
        public string InitialVersion { get; set; }
        /// <summary>
        /// Status of the upgrade
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_status", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Status of the upgrade")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTUpgradeHistoryUpgradeStatusEnumType UpgradeStatus { get; set; }
    }
}
