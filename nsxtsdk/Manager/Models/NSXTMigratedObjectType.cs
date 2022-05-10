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
    /// Migrated resource.
    /// </summary>
    [NSXTProperty(Description: @"Migrated resource.")]
    public class NSXTMigratedObjectType 
    {
        /// <summary>
        /// Policy path.
        /// </summary>
        [JsonProperty(PropertyName = "policy_path")]
        public string? PolicyPath { get; set; }
        /// <summary>
        /// Parent resource type.
        /// </summary>
        [JsonProperty(PropertyName = "parent_resource_type")]
        public string? ParentResourceType { get; set; }
        /// <summary>
        /// Resource id.
        /// </summary>
        [JsonProperty(PropertyName = "resource_id")]
        public string? ResourceId { get; set; }
        /// <summary>
        /// Parent resource id.
        /// </summary>
        [JsonProperty(PropertyName = "parent_resource_id")]
        public string? ParentResourceId { get; set; }
        /// <summary>
        /// Resource type.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type")]
        public string? ResourceType { get; set; }
        /// <summary>
        /// Policy id.
        /// </summary>
        [JsonProperty(PropertyName = "policy_id")]
        public string? PolicyId { get; set; }
    }
}
