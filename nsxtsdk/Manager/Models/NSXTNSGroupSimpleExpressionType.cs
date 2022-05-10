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
    public class NSXTNSGroupSimpleExpressionType : NSXTNSGroupExpressionType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "target_resource")]
        public NSXTResourceReferenceType TargetResource { get; set; }
        /// <summary>
        /// Field of the resource on which this expression is evaluated
        /// </summary>
        [JsonProperty(PropertyName = "target_property", Required = Required.AllowNull)]
        public string TargetProperty { get; set; }
        /// <summary>
        /// Type of the resource on which this expression is evaluated
        /// </summary>
        [JsonProperty(PropertyName = "target_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNsgroupSimpleExpressionTargetTypeEnumType TargetType { get; set; }
        /// <summary>
        /// Value that satisfies this expression
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public string Value { get; set; }
        /// <summary>
        /// All operators perform a case insensitive match.
        /// </summary>
        [JsonProperty(PropertyName = "op", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNsgroupSimpleExpressionOpEnumType Op { get; set; }
    }
}
