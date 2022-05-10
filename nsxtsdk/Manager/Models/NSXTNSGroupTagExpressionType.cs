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
    public class NSXTNSGroupTagExpressionType : NSXTNSGroupExpressionType
    {
        /// <summary>
        /// Target_type VirtualMachine supports all specified operators for
        /// tag expression while LogicalSwitch and LogicalPort supports only
        /// EQUALS operator.
        /// All operators perform a case insensitive match.
        /// </summary>
        [JsonProperty(PropertyName = "tag_op")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNsgroupTagExpressionTagOpEnumType? TagOp { get; set; }
        /// <summary>
        /// The tag.scope attribute of the object
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public string? Scope { get; set; }
        /// <summary>
        /// Operator of the scope expression eg- tag.scope = "S1".
        /// </summary>
        [JsonProperty(PropertyName = "scope_op")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNsgroupTagExpressionScopeOpEnumType? ScopeOp { get; set; }
        /// <summary>
        /// The tag.tag attribute of the object
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string? Tag { get; set; }
        /// <summary>
        /// Type of the resource on which this expression is evaluated
        /// </summary>
        [JsonProperty(PropertyName = "target_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNsgroupTagExpressionTargetTypeEnumType TargetType { get; set; }
    }
}
