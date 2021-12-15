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
    /// Related attribute on the target resource for conditional constraints based
        /// on related attribute value.
        /// Example - destinationGroups/service/action is related attribute of
        /// sourceGroups in communcation entry.
    /// </summary>
    [NSXTProperty(Description: @"Related attribute on the target resource for conditional constraints basedon related attribute value.Example - destinationGroups/service/action is related attribute of  sourceGroups in communcation entry.")]
    public class NSXTRelatedAttributeType 
    {
        /// <summary>
        /// Related attribute name on the target entity.
        /// </summary>
        [JsonProperty(PropertyName = "attribute", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Related attribute name on the target entity.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Attribute { get; set; }
    }
}