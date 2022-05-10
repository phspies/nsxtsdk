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
        public string Attribute { get; set; }
    }
}
