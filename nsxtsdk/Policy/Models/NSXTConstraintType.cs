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
    public class NSXTConstraintType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// User friendly message to be shown to users upon violation.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string? Message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "constraint_expression", Required = Required.AllowNull)]
        public NSXTConstraintExpressionType ConstraintExpression { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "target", Required = Required.AllowNull)]
        public NSXTConstraintTargetType Target { get; set; }
    }
}
