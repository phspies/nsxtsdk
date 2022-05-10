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
    public class NSXTEntityInstanceCountConstraintExpressionType : NSXTConstraintExpressionType
    {
        /// <summary>
        /// Operations supported '<' and '<='.
        /// </summary>
        [JsonProperty(PropertyName = "operator", Required = Required.AllowNull)]
        public string OperatorProperty { get; set; }
        /// <summary>
        /// Instance count.
        /// </summary>
        [JsonProperty(PropertyName = "count", Required = Required.AllowNull)]
        public long Count { get; set; }
    }
}
