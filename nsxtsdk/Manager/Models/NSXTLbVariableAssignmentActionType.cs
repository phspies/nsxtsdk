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
    public class NSXTLbVariableAssignmentActionType : NSXTLbRuleActionType
    {
        /// <summary>
        /// Value of variable
        /// </summary>
        [JsonProperty(PropertyName = "variable_value", Required = Required.AllowNull)]
        public string VariableValue { get; set; }
        /// <summary>
        /// Name of the variable to be assigned
        /// </summary>
        [JsonProperty(PropertyName = "variable_name", Required = Required.AllowNull)]
        public string VariableName { get; set; }
    }
}
