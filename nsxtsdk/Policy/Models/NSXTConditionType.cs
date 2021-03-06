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
    public class NSXTConditionType : NSXTExpressionType
    {
        /// <summary>
        /// Operator is made non-mandatory to support Segment and SegmentPort tag based expression. To evaluate expression
        /// for other types, operator value should be provided.
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTConditionOperatorEnumType? OperatorProperty { get; set; }
        /// <summary>
        /// Value
        /// </summary>
        [JsonProperty(PropertyName = "value", Required = Required.AllowNull)]
        public string Value { get; set; }
        /// <summary>
        /// Default operator when not specified explicitly would be considered as EQUALS.
        /// If value for Condition is empty, then condition will not be evaluated.
        /// For example, Condition with key as Tag and value as "|tag" would be evaluated for tag value not for empty
        /// scope value.
        /// </summary>
        [JsonProperty(PropertyName = "scope_operator")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTConditionScopeOperatorEnumType? ScopeOperator { get; set; }
        /// <summary>
        /// Key
        /// </summary>
        [JsonProperty(PropertyName = "key", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTConditionKeyEnumType Key { get; set; }
        /// <summary>
        /// Group member type
        /// </summary>
        [JsonProperty(PropertyName = "member_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTConditionMemberTypeEnumType MemberType { get; set; }
    }
}
