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
    /// It represents tag operation status for a resource and details of the failure if any.
    /// </summary>
    [NSXTProperty(Description: @"It represents tag operation status for a resource and details of the failure if any.")]
    public class NSXTResourceTagStatusType 
    {
        /// <summary>
        /// Status of tag apply or remove operation
        /// </summary>
        [JsonProperty(PropertyName = "tag_status", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Status of tag apply or remove operation")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTResourceTagStatusTagStatusEnumType TagStatus { get; set; }
        /// <summary>
        /// Details about the error if any
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        [NSXTProperty(IsRequired: false, Description: @"Details about the error if any")]
        public string? Details { get; set; }
        /// <summary>
        /// Resource display name
        /// </summary>
        [JsonProperty(PropertyName = "resource_display_name")]
        [NSXTProperty(IsRequired: false, Description: @"Resource display name")]
        public string? ResourceDisplayName { get; set; }
        /// <summary>
        /// Resource id
        /// </summary>
        [JsonProperty(PropertyName = "resource_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Resource id")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ResourceId { get; set; }
    }
}
