// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLBVariableConditionType : NSXTLBRuleConditionType
    {
        /// <summary>
        /// Value of variable to be matched
        /// </summary>
        [JsonProperty(PropertyName = "variable_value", Required = Required.AllowNull)]
        public string VariableValue { get; set; }
        /// <summary>
        /// If true, case is significant when comparing variable value.
        /// </summary>
        public bool? CaseSensitive { get; set; }
        /// <summary>
        /// Match type of variable value
        /// </summary>
        public NSXTLbvariableConditionMatchTypeEnumType? MatchType { get; set; }
        /// <summary>
        /// Name of the variable to be matched
        /// </summary>
        [JsonProperty(PropertyName = "variable_name", Required = Required.AllowNull)]
        public string VariableName { get; set; }
    }
}
