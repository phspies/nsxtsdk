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
    public class NSXTValueConstraintExpressionType : NSXTConstraintExpressionType
    {
        /// <summary>
        /// Operation to check for value list for resource attribute of constraint.
        /// </summary>
        [JsonProperty(PropertyName = "operator", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTValueConstraintExpressionOperatorEnumType OperatorProperty { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "values_with_type")]
        public NSXTConstraintValueType ValuesWithType { get; set; }
        /// <summary>
        /// List of values.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }
    }
}
