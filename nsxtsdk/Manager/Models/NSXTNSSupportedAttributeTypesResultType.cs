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
    /// NSSupportedAttributes Types
    /// </summary>
    [NSXTProperty(Description: @"NSSupportedAttributes Types")]
    public class NSXTNSSupportedAttributeTypesResultType 
    {
        /// <summary>
        /// List of NSSupportedAttributes types
        /// </summary>
        [JsonProperty(PropertyName = "attribute_types")]
        [NSXTProperty(IsRequired: false, Description: @"List of NSSupportedAttributes types")]
        public IList<string> AttributeTypes { get; set; }
    }
}
