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
    /// It represents tag operation status for a resource and details of the failure if any.
    /// </summary>
    [NSXTProperty(Description: @"It represents tag operation status for a resource and details of the failure if any.")]
    public class NSXTResourceTagStatusType 
    {
        /// <summary>
        /// Status of tag apply or remove operation
        /// </summary>
        [JsonProperty(PropertyName = "tag_status", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTResourceTagStatusTagStatusEnumType TagStatus { get; set; }
        /// <summary>
        /// Details about the error if any
        /// </summary>
        [JsonProperty(PropertyName = "details")]
        public string? Details { get; set; }
        /// <summary>
        /// Resource display name
        /// </summary>
        [JsonProperty(PropertyName = "resource_display_name")]
        public string? ResourceDisplayName { get; set; }
        /// <summary>
        /// Resource id
        /// </summary>
        [JsonProperty(PropertyName = "resource_id", Required = Required.AllowNull)]
        public string ResourceId { get; set; }
    }
}
