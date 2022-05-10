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
    /// Community match expression
    /// </summary>
    [NSXTProperty(Description: @"Community match expression")]
    public class NSXTCommunityMatchExpressionType 
    {
        /// <summary>
        /// Operator for evaluating community match expressions.
        /// AND logical AND operator
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTCommunityMatchExpressionOperatorEnumType? OperatorProperty { get; set; }
        /// <summary>
        /// Array of community match operations
        /// </summary>
        [JsonProperty(PropertyName = "expression", Required = Required.AllowNull)]
        public IList<NSXTCommunityMatchOperationType> Expression { get; set; }
    }
}
