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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTEmbeddedResourceType : NSXTRevisionedResourceType
    {
        /// <summary>
        /// Owner of this resource
        /// </summary>
        [JsonProperty(PropertyName = "_owner")]
        [NSXTProperty(IsRequired: false, Description: @"Owner of this resource")]
        public NSXTOwnerResourceLinkType Owner { get; set; }
        /// <summary>
        /// Defaults to ID if not set
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        [NSXTProperty(IsRequired: false, Description: @"Defaults to ID if not set")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Identifier of the resource
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        [NSXTProperty(IsRequired: false, Description: @"Identifier of the resource")]
        public string? Id { get; set; }
        /// <summary>
        /// The type of this resource.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type")]
        [NSXTProperty(IsRequired: false, Description: @"The type of this resource.")]
        public string? ResourceType { get; set; }
        /// <summary>
        /// Description of this resource
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        [NSXTProperty(IsRequired: false, Description: @"Description of this resource")]
        public string? Description { get; set; }
    }
}
