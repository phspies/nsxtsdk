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
    /// NSSupportedAttributes Types
    /// </summary>
    [NSXTProperty(Description: @"NSSupportedAttributes Types")]
    public class NSXTNSSupportedAttributeTypesResultType 
    {
        /// <summary>
        /// List of NSSupportedAttributes types
        /// </summary>
        [JsonProperty(PropertyName = "attribute_types")]
        public IList<string> AttributeTypes { get; set; }
    }
}
