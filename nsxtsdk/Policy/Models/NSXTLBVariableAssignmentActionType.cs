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
    public class NSXTLBVariableAssignmentActionType : NSXTLBRuleActionType
    {
        /// <summary>
        /// Value of variable.
        /// </summary>
        [JsonProperty(PropertyName = "variable_value", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Value of variable.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VariableValue { get; set; }
        /// <summary>
        /// Name of the variable to be assigned.
        /// </summary>
        [JsonProperty(PropertyName = "variable_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Name of the variable to be assigned.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VariableName { get; set; }
    }
}
