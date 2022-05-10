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
    /// Unary Operation.
    /// </summary>
    [NSXTProperty(Description: @"Unary Operation.")]
    public class NSXTUnaryOperationType 
    {
        /// <summary>
        /// Logical Operator describing the operation to apply to the operand.
        /// </summary>
        [JsonProperty(PropertyName = "operator", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTUnaryOperationOperatorEnumType OperatorProperty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "operand", Required = Required.AllowNull)]
        public NSXTResourceFieldPointerType Operand { get; set; }
    }
}
