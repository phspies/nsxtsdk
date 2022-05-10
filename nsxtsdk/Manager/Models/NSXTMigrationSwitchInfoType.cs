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
    /// Details about switch to be migrated
    /// </summary>
    [NSXTProperty(Description: @"Details about switch to be migrated")]
    public class NSXTMigrationSwitchInfoType 
    {
        /// <summary>
        /// Kind of switch, can be DVS, VSS.
        /// </summary>
        [JsonProperty(PropertyName = "kind")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTMigrationSwitchInfoKindEnumType? Kind { get; set; }
        /// <summary>
        /// Version of the switch to be migrated.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
        /// <summary>
        /// Number of PNICs associated with this switch.
        /// </summary>
        [JsonProperty(PropertyName = "pnic_count")]
        public int? PnicCount { get; set; }
        /// <summary>
        /// Switch Identifier.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Name of the switch.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
    }
}
