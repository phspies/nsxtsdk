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
    /// Upgrade status of upgrade-coordinator
    /// </summary>
    [NSXTProperty(Description: @"Upgrade status of upgrade-coordinator")]
    public class NSXTUcUpgradeStatusType 
    {
        /// <summary>
        /// Status of UC upgrade.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string? Status { get; set; }
        /// <summary>
        /// List of progress messages.
        /// </summary>
        [JsonProperty(PropertyName = "progress_messages")]
        public IList<string> ProgressMessages { get; set; }
        /// <summary>
        /// Current state of UC upgrade
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUcUpgradeStatusStateEnumType? State { get; set; }
        /// <summary>
        /// List of failure messages.
        /// </summary>
        [JsonProperty(PropertyName = "errors")]
        public IList<string> Errors { get; set; }
        /// <summary>
        /// Upgrade Coordinator Upgrade Progress Percentage
        /// </summary>
        [JsonProperty(PropertyName = "progress_percentage")]
        public int? ProgressPercentage { get; set; }
    }
}
