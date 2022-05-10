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
    /// Upgrade status summry
    /// </summary>
    [NSXTProperty(Description: @"Upgrade status summry")]
    public class NSXTUpgradeStatusSummaryType 
    {
        /// <summary>
        /// True if upgrade bundle is present
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_bundle_present")]
        public bool? UpgradeBundlePresent { get; set; }
        /// <summary>
        /// Meta info of upgrade
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_metadata")]
        public object? UpgradeMetadata { get; set; }
        /// <summary>
        /// List of all upgrade steps performed
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_steps")]
        public IList<object> UpgradeSteps { get; set; }
    }
}
