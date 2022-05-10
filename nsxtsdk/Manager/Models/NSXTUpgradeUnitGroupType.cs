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
    public class NSXTUpgradeUnitGroupType : NSXTManagedResourceType
    {
        /// <summary>
        /// Flag to indicate whether upgrade of this group is enabled or not
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Number of upgrade units in the group
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_unit_count")]
        public int? UpgradeUnitCount { get; set; }
        /// <summary>
        /// Component type
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public string Type { get; set; }
        /// <summary>
        /// List of upgrade units in the group
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_units")]
        public IList<NSXTUpgradeUnitType> UpgradeUnits { get; set; }
        /// <summary>
        /// Extended configuration for the group. Following extended_configuration is supported:
        /// 
        /// Key: upgrade_mode
        /// Supported values: maintenance_mode, in_place, stage_in_vlcm
        /// 
        /// Key: maintenance_mode_config_vsan_mode
        /// Supported values: evacuate_all_data, ensure_object_accessibility, no_action
        /// 
        /// Key: maintenance_mode_config_evacuate_powered_off_vms
        /// Supported values: true, false
        /// 
        /// Key: rebootless_upgrade
        /// Supported values: true, false
        /// </summary>
        [JsonProperty(PropertyName = "extended_configuration")]
        public IList<NSXTKeyValuePairType> ExtendedConfiguration { get; set; }
        /// <summary>
        /// Upgrade method to specify whether the upgrade is to be performed in parallel or serially
        /// </summary>
        [JsonProperty(PropertyName = "parallel")]
        public bool? Parallel { get; set; }
    }
}
