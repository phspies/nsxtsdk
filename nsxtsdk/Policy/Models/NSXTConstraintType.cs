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
    [NSXTProperty(Description: @"")]
    public class NSXTConstraintType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// User friendly message to be shown to users upon violation.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        [NSXTProperty(IsRequired: false, Description: @"User friendly message to be shown to users upon violation.")]
        public string? Message { get; set; }
        /// <summary>
        /// Expression to constrain the target attribute value.
        /// </summary>
        [JsonProperty(PropertyName = "constraint_expression", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Expression to constrain the target attribute value.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTConstraintExpressionType ConstraintExpression { get; set; }
        /// <summary>
        /// Target resource attribute details.
        /// </summary>
        [JsonProperty(PropertyName = "target", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Target resource attribute details.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTConstraintTargetType Target { get; set; }
    }
}