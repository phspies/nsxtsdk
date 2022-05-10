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
    /// Scope of discovered resource
    /// </summary>
    [NSXTProperty(Description: @"Scope of discovered resource")]
    public class NSXTDiscoveredResourceScopeType 
    {
        /// <summary>
        /// Type of the scope for the discovered resource.
        /// </summary>
        [JsonProperty(PropertyName = "scope_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDiscoveredResourceScopeScopeTypeEnumType? ScopeType { get; set; }
        /// <summary>
        /// Specifies the scope id of discovered resource.
        /// </summary>
        [JsonProperty(PropertyName = "scope_id")]
        public string? ScopeId { get; set; }
    }
}
