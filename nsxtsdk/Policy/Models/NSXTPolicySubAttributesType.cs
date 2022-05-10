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
    /// Policy Sub Attributes data holder
    /// </summary>
    [NSXTProperty(Description: @"Policy Sub Attributes data holder")]
    public class NSXTPolicySubAttributesType 
    {
        /// <summary>
        /// Datatype for sub attribute
        /// </summary>
        [JsonProperty(PropertyName = "datatype", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicySubAttributesDatatypeEnumType Datatype { get; set; }
        /// <summary>
        /// Multiple sub attribute values can be specified as elements of array.
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public IList<string> Value { get; set; }
        /// <summary>
        /// Key for sub attribute
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicySubAttributesKeyEnumType Key { get; set; }
    }
}
