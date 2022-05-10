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
    [JsonInheritanceAttribute("EntityInstanceCountConstraintExpression", typeof(NSXTEntityInstanceCountConstraintExpressionType))]
    [JsonInheritanceAttribute("RelatedAttributeConditionalExpression", typeof(NSXTRelatedAttributeConditionalExpressionType))]
    [JsonInheritanceAttribute("ValueConstraintExpression", typeof(NSXTValueConstraintExpressionType))]
    [JsonInheritanceAttribute("FieldSanityConstraintExpression", typeof(NSXTFieldSanityConstraintExpressionType))]
    [NSXTProperty(Description: @"")]
    public class NSXTConstraintExpressionType : NSXTManagedResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTConstraintExpressionResourceTypeEnumType ResourceType { get; set; }
    }
}
