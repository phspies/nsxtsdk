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
    [JsonConverter(typeof(JsonInheritanceConverter), "resource_type")]
    [JsonInheritanceAttribute("NestedExpression", typeof(NSXTNestedExpressionType))]
    [JsonInheritanceAttribute("MACAddressExpression", typeof(NSXTMACAddressExpressionType))]
    [JsonInheritanceAttribute("IPAddressExpression", typeof(NSXTIPAddressExpressionType))]
    [JsonInheritanceAttribute("ExternalIDExpression", typeof(NSXTExternalIDExpressionType))]
    [JsonInheritanceAttribute("PathExpression", typeof(NSXTPathExpressionType))]
    [JsonInheritanceAttribute("IdentityGroupExpression", typeof(NSXTIdentityGroupExpressionType))]
    [JsonInheritanceAttribute("ConjunctionOperator", typeof(NSXTConjunctionOperatorType))]
    [JsonInheritanceAttribute("Condition", typeof(NSXTConditionType))]
    [NSXTProperty(Description: @"")]
    public class NSXTExpressionType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTExpressionResourceTypeEnumType ResourceType { get; set; }
    }
}
