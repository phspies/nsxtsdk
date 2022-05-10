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
    public class NSXTMigrationUnitGroupType : NSXTManagedResourceType
    {
        /// <summary>
        /// Number of migration units in the group
        /// </summary>
        [JsonProperty(PropertyName = "migration_unit_count")]
        public int? MigrationUnitCount { get; set; }
        /// <summary>
        /// List of migration units in the group
        /// </summary>
        [JsonProperty(PropertyName = "migration_units")]
        public IList<NSXTMigrationUnitType> MigrationUnits { get; set; }
        /// <summary>
        /// Flag to indicate whether migration of this group is enabled or not
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Component type
        /// </summary>
        [JsonProperty(PropertyName = "type", Required = Required.AllowNull)]
        public string Type { get; set; }
        /// <summary>
        /// Migration method to specify whether the migration is to be performed in parallel or serially
        /// </summary>
        [JsonProperty(PropertyName = "parallel")]
        public bool? Parallel { get; set; }
        /// <summary>
        /// Extended configuration for the group
        /// </summary>
        [JsonProperty(PropertyName = "extended_configuration")]
        public IList<NSXTKeyValuePairType> ExtendedConfiguration { get; set; }
    }
}
