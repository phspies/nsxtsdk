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
    public class NSXTFieldSanityConstraintExpressionType : NSXTConstraintExpressionType
    {
        /// <summary>
        /// A conditional operator
        /// </summary>
        [JsonProperty(PropertyName = "operator", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTFieldSanityConstraintExpressionOperatorEnumType OperatorProperty { get; set; }
        /// <summary>
        /// List of sanity checks.
        /// </summary>
        [JsonProperty(PropertyName = "checks", Required = Required.AllowNull)]
        public IList<string> Checks { get; set; }
    }
}
