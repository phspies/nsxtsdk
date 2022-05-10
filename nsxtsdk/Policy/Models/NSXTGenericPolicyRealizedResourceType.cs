using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTGenericPolicyRealizedResourceType : NSXTPolicyRealizedResourceType
    {
        /// <summary>
        /// The site where this entity resides.
        /// </summary>
        [JsonProperty(PropertyName = "site_path")]
        public string? SitePath { get; set; }
        /// <summary>
        /// Collection of intent paths
        /// </summary>
        [JsonProperty(PropertyName = "intent_paths")]
        public IList<string> IntentPaths { get; set; }
        /// <summary>
        /// The path of the enforcement point.
        /// </summary>
        [JsonProperty(PropertyName = "enforcement_point_path")]
        public string? EnforcementPointPath { get; set; }
        /// <summary>
        /// Collection of type specific properties
        /// </summary>
        [JsonProperty(PropertyName = "extended_attributes")]
        public IList<NSXTAttributeValType> ExtendedAttributes { get; set; }
        /// <summary>
        /// Type of realized entity
        /// </summary>
        [JsonProperty(PropertyName = "entity_type")]
        public string? EntityType { get; set; }
    }
}
