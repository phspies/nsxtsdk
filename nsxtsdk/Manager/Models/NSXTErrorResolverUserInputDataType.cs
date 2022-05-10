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
    /// Corresponds to one property entered by the user
    /// </summary>
    [NSXTProperty(Description: @"Corresponds to one property entered by the user")]
    public class NSXTErrorResolverUserInputDataType 
    {
        /// <summary>
        /// The datatype of the given property. Useful for data validation
        /// </summary>
        [JsonProperty(PropertyName = "data_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTErrorResolverUserInputDataDataTypeEnumType DataType { get; set; }
        /// <summary>
        /// Name of the property supplied by the user
        /// </summary>
        [JsonProperty(PropertyName = "property_name", Required = Required.AllowNull)]
        public string PropertyName { get; set; }
        /// <summary>
        /// The value associated with the above property
        /// </summary>
        [JsonProperty(PropertyName = "property_value")]
        public string? PropertyValue { get; set; }
    }
}
