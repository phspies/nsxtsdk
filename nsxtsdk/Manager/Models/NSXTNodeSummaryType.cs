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
    public class NSXTNodeSummaryType : NSXTResourceType
    {
        /// <summary>
        /// Number of nodes of the type and at the component version
        /// </summary>
        [JsonProperty(PropertyName = "node_count")]
        public int? NodeCount { get; set; }
        /// <summary>
        /// Node type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// Component version
        /// </summary>
        [JsonProperty(PropertyName = "component_version")]
        public string? ComponentVersion { get; set; }
        /// <summary>
        /// UpgradeUnit sub type
        /// </summary>
        [JsonProperty(PropertyName = "upgrade_unit_subtype")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNodeSummaryUpgradeUnitSubtypeEnumType? UpgradeUnitSubtype { get; set; }
    }
}
