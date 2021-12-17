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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Community match expression
    /// </summary>
    [NSXTProperty(Description: @"Community match expression")]
    public class NSXTCommunityMatchExpressionType 
    {
        public NSXTCommunityMatchExpressionType()
        {
        }
        /// <summary>
        /// Operator for evaluating community match expressions.
        /// AND logical AND operator
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        [NSXTProperty(IsRequired: false, Description: @"Operator for evaluating community match expressions.AND logical AND operator")]
        public NSXTCommunityMatchExpressionOperatorEnumType? OperatorProperty { get; set; }
        /// <summary>
        /// Array of community match operations
        /// </summary>
        [JsonProperty(PropertyName = "expression", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Array of community match operations")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTCommunityMatchOperationType> Expression { get; set; }
    }
}
