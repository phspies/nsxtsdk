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
    public class NSXTRelatedAttributeConditionalExpressionType : NSXTConstraintExpressionType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "related_attribute", Required = Required.AllowNull)]
        public NSXTRelatedAttributeType RelatedAttribute { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "condition", Required = Required.AllowNull)]
        public NSXTConditionalValueConstraintExpressionType Condition { get; set; }
    }
}
