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
    public class NSXTNSGroupComplexExpressionType : NSXTNSGroupExpressionType
    {
        /// <summary>
        /// Represents expressions which are to be logically 'AND'ed.The array cannot contain
        /// NSGroupComplexExpression.Only NSGroupTagExpression and NSGroupSimpleExpressions
        /// are accepted.
        /// </summary>
        [JsonProperty(PropertyName = "expressions", Required = Required.AllowNull)]
        public IList<NSXTNSGroupExpressionType> Expressions { get; set; }
    }
}
