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
    /// Meta-data of pre/post-upgrade checks for a component
    /// </summary>
    [NSXTProperty(Description: @"Meta-data of pre/post-upgrade checks for a component")]
    public class NSXTComponentUpgradeChecksInfoType 
    {
        /// <summary>
        /// Collection of pre-upgrade checks
        /// </summary>
        [JsonProperty(PropertyName = "pre_upgrade_checks_info")]
        public IList<NSXTUpgradeCheckInfoType> PreUpgradeChecksInfo { get; set; }
        /// <summary>
        /// Collection of post-upgrade checks
        /// </summary>
        [JsonProperty(PropertyName = "post_upgrade_checks_info")]
        public IList<NSXTUpgradeCheckInfoType> PostUpgradeChecksInfo { get; set; }
        /// <summary>
        /// Component type of the pre/post-upgrade checks
        /// </summary>
        [JsonProperty(PropertyName = "component_type", Required = Required.AllowNull)]
        public string ComponentType { get; set; }
    }
}
