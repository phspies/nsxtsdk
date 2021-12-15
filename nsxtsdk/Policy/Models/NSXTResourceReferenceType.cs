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
    /// A weak reference to an NSX resource.
    /// </summary>
    [NSXTProperty(Description: @"A weak reference to an NSX resource.")]
    public class NSXTResourceReferenceType 
    {
        /// <summary>
        /// Display name of the NSX resource.
        /// </summary>
        [JsonProperty(PropertyName = "target_display_name")]
        [NSXTProperty(IsRequired: false, Description: @"Display name of the NSX resource.")]
        public string? TargetDisplayName { get; set; }
        /// <summary>
        /// Will be set to false if the referenced NSX resource has been deleted.
        /// </summary>
        [JsonProperty(PropertyName = "is_valid")]
        [NSXTProperty(IsRequired: false, Description: @"Will be set to false if the referenced NSX resource has been deleted.")]
        public bool? IsValid { get; set; }
        /// <summary>
        /// Identifier of the NSX resource.
        /// </summary>
        [JsonProperty(PropertyName = "target_id")]
        [NSXTProperty(IsRequired: false, Description: @"Identifier of the NSX resource.")]
        public string? TargetId { get; set; }
        /// <summary>
        /// Type of the NSX resource.
        /// </summary>
        [JsonProperty(PropertyName = "target_type")]
        [NSXTProperty(IsRequired: false, Description: @"Type of the NSX resource.")]
        public string? TargetType { get; set; }
    }
}