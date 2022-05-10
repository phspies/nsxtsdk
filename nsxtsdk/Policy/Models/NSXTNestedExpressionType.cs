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
    public class NSXTNestedExpressionType : NSXTExpressionType
    {
        /// <summary>
        /// Expression.
        /// </summary>
        [JsonProperty(PropertyName = "expressions", Required = Required.AllowNull)]
        public IList<NSXTExpressionType> Expressions { get; set; }
    }
}
