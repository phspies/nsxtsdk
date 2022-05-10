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
    public class NSXTSourceFieldEvaluationType : NSXTEvaluationType
    {
        /// <summary>
        /// Logical operator.
        /// </summary>
        [JsonProperty(PropertyName = "operator", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSourceFieldEvaluationOperatorEnumType OperatorProperty { get; set; }
        /// <summary>
        /// Expected values necessary to apply the specified operation on the source field value.
        /// </summary>
        [JsonProperty(PropertyName = "expected", Required = Required.AllowNull)]
        public IList<string> Expected { get; set; }
        /// <summary>
        /// Field in the form of a pointer, describing the location of the attribute within the source
        /// of the event.
        /// </summary>
        [JsonProperty(PropertyName = "field_pointer", Required = Required.AllowNull)]
        public string FieldPointer { get; set; }
    }
}
