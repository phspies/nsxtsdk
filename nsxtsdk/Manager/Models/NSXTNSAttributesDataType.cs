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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTNSAttributesDataType : NSXTManagedResourceType
    {
        /// <summary>
        /// Data type of attribute/sub attribute key
        /// </summary>
        [JsonProperty(PropertyName = "datatype", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNsattributesDataDatatypeEnumType Datatype { get; set; }
        /// <summary>
        /// Attribute is predefined or custom
        /// </summary>
        [JsonProperty(PropertyName = "attribute_source")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNsattributesDataAttributeSourceEnumType? AttributeSource { get; set; }
        /// <summary>
        /// Multiple attribute/sub attribute values can be specified
        /// as elements of array.
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public IList<string> Value { get; set; }
        /// <summary>
        /// NSProfile attribute/sub attribute keys.
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        public string Key { get; set; }
        /// <summary>
        /// Description for NSProfile attributes
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
    }
}
