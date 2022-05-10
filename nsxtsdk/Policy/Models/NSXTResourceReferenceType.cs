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
    /// A weak reference to an NSX resource.
    /// </summary>
    [NSXTProperty(Description: @"A weak reference to an NSX resource.")]
    public class NSXTResourceReferenceType 
    {
        /// <summary>
        /// Display name of the NSX resource.
        /// </summary>
        [JsonProperty(PropertyName = "target_display_name")]
        public string? TargetDisplayName { get; set; }
        /// <summary>
        /// Will be set to false if the referenced NSX resource has been deleted.
        /// </summary>
        [JsonProperty(PropertyName = "is_valid")]
        public bool? IsValid { get; set; }
        /// <summary>
        /// Identifier of the NSX resource.
        /// </summary>
        [JsonProperty(PropertyName = "target_id")]
        public string? TargetId { get; set; }
        /// <summary>
        /// Type of the NSX resource.
        /// </summary>
        [JsonProperty(PropertyName = "target_type")]
        public string? TargetType { get; set; }
    }
}
