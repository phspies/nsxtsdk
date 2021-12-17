// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Scope of discovered resource
    /// </summary>
    [NSXTProperty(Description: @"Scope of discovered resource")]
    public class NSXTDiscoveredResourceScopeType 
    {
        public NSXTDiscoveredResourceScopeType()
        {
        }
        /// <summary>
        /// Type of the scope for the discovered resource.
        /// </summary>
        [JsonProperty(PropertyName = "scope_type")]
        [NSXTProperty(IsRequired: false, Description: @"Type of the scope for the discovered resource.")]
        public NSXTDiscoveredResourceScopeScopeTypeEnumType? ScopeType { get; set; }
        /// <summary>
        /// Specifies the scope id of discovered resource.
        /// </summary>
        [JsonProperty(PropertyName = "scope_id")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies the scope id of discovered resource.")]
        public string? ScopeId { get; set; }
    }
}
