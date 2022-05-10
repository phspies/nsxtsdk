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
    public class NSXTMigrationUnitType : NSXTResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public NSXTResourceReferenceType Group { get; set; }
        /// <summary>
        /// List of warnings indicating issues with the migration unit that may result in migration failure
        /// </summary>
        [JsonProperty(PropertyName = "warnings")]
        public IList<string> Warnings { get; set; }
        /// <summary>
        /// This is component version e.g. if migration unit is of type HOST, then this is host version.
        /// </summary>
        [JsonProperty(PropertyName = "current_version")]
        public string? CurrentVersion { get; set; }
        /// <summary>
        /// Metadata about migration unit
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<NSXTKeyValuePairType> Metadata { get; set; }
        /// <summary>
        /// Migration unit type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string? Type { get; set; }
        /// <summary>
        /// Identifier of the migration unit
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// Name of the migration unit
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
    }
}
