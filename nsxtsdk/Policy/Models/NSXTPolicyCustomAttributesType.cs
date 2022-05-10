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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTPolicyCustomAttributesType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Source of attribute value i.e whether system defined or custom value
        /// </summary>
        [JsonProperty(PropertyName = "attribute_source")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyCustomAttributesAttributeSourceEnumType? AttributeSource { get; set; }
        /// <summary>
        /// Reference to sub attributes for the attribute
        /// </summary>
        [JsonProperty(PropertyName = "sub_attributes")]
        public IList<NSXTPolicySubAttributesType> SubAttributes { get; set; }
        /// <summary>
        /// Description for attribute value
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string? Description { get; set; }
        /// <summary>
        /// Policy Custom Attribute Key
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyCustomAttributesKeyEnumType Key { get; set; }
        /// <summary>
        /// Datatype for attribute
        /// </summary>
        [JsonProperty(PropertyName = "datatype", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyCustomAttributesDatatypeEnumType Datatype { get; set; }
        /// <summary>
        /// Multiple attribute values can be specified as elements of array.
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public IList<string> Value { get; set; }
        /// <summary>
        /// This is optional part that can hold additional data about the attribute key/values.
        /// Example - For Custom URL key , it specified url type for url value.
        /// This is generic array and can hold multiple meta information about key/values in future
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public IList<NSXTContextProfileAttributesMetadataType> Metadata { get; set; }
    }
}
