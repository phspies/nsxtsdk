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
    public class NSXTUpgradeUnitType : NSXTResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public NSXTUpgradeUnitGroupInfoType Group { get; set; }
        /// <summary>
        /// List of warnings indicating issues with the upgrade unit that may result in upgrade failure
        /// </summary>
        [JsonProperty(PropertyName = "warnings")]
        public IList<string> Warnings { get; set; }
        /// <summary>
        /// This is component version e.g. if upgrade unit is of type edge, then this is edge version.
        /// </summary>
        [JsonProperty(PropertyName = "current_version")]
        public string? CurrentVersion { get; set; }
        /// <summary>
        /// Metadata about upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<NSXTKeyValuePairType> Metadata { get; set; }
        /// <summary>
        /// Upgrade unit type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// Identifier of the upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Name of the upgrade unit
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
    }
}
