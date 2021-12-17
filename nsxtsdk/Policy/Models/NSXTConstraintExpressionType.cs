// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

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
        public NSXTConstraintExpressionType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTConstraintExpressionResourceTypeEnumType ResourceType { get; set; }
    }
}
