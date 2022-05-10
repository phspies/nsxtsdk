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
    /// Upgrade progress status
    /// </summary>
    [NSXTProperty(Description: @"Upgrade progress status")]
    public class NSXTUpgradeProgressStatusType 
    {
        /// <summary>
        /// True if upgrade bundle is present
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_bundle_present")]
        public bool? UpgradeBundlePresent { get; set; }
        /// <summary>
        /// Status of last upgrade step
        /// </summary>
        [JsonProperty(PropertyName = "last_upgrade_step_status")]
        public object? LastUpgradeStepStatus { get; set; }
        /// <summary>
        /// Meta info of upgrade
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_metadata")]
        public object? UpgradeMetadata { get; set; }
    }
}
