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
    /// Contains migration related information about logical constructs
    /// </summary>
    [NSXTProperty(Description: @"Contains migration related information about logical constructs")]
    public class NSXTLogicalConstructMigrationStatsType 
    {
        /// <summary>
        /// Type of the vSphere object (e.g. dvportgroup).
        /// </summary>
        [JsonProperty(PropertyName = "source_type")]
        public string? SourceType { get; set; }
        /// <summary>
        /// Number of objects of source type.
        /// </summary>
        [JsonProperty(PropertyName = "source_count")]
        public string? SourceCount { get; set; }
        /// <summary>
        /// Functional area that this vSphere object falls into
        /// </summary>
        [JsonProperty(PropertyName = "vertical")]
        public string? Vertical { get; set; }
        /// <summary>
        /// Federation site id.
        /// </summary>
        [JsonProperty(PropertyName = "site_id")]
        public string? SiteId { get; set; }
        /// <summary>
        /// Type of the Policy object corresponding to the source type (e.g. Segment).
        /// </summary>
        [JsonProperty(PropertyName = "target_type")]
        public string? TargetType { get; set; }
        /// <summary>
        /// Number of objects of target type.
        /// </summary>
        [JsonProperty(PropertyName = "target_count")]
        public string? TargetCount { get; set; }
    }
}
