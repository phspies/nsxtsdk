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
    /// Contains type specific properties of generic realized entity
    /// </summary>
    [NSXTProperty(Description: @"Contains type specific properties of generic realized entity")]
    public class NSXTAttributeValType 
    {
        /// <summary>
        /// List of attribute values
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }
        /// <summary>
        /// If attribute has a single value or collection of values
        /// </summary>
        [JsonProperty(PropertyName = "multivalue")]
        public bool? Multivalue { get; set; }
        /// <summary>
        /// Attribute key
        /// </summary>
        [JsonProperty(PropertyName = "key")]
        public string? Key { get; set; }
        /// <summary>
        /// Datatype of the property
        /// </summary>
        [JsonProperty(PropertyName = "data_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAttributeValDataTypeEnumType? DataType { get; set; }
    }
}
