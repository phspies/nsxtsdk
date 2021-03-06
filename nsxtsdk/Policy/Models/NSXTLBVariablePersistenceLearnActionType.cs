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
    public class NSXTLBVariablePersistenceLearnActionType : NSXTLBRuleActionType
    {
        /// <summary>
        /// The property is used to enable a hash operation for variable value
        /// when composing the persistence key.
        /// </summary>
        [JsonProperty(PropertyName = "variable_hash_enabled")]
        public bool? VariableHashEnabled { get; set; }
        /// <summary>
        /// The property is the name of variable to be learnt. It is used to
        /// identify which variable's value is learnt from HTTP response.
        /// The variable can be a built-in variable such as "_cookie_JSESSIONID",
        /// a customized variable defined in LBVariableAssignmentAction or a
        /// captured variable in regular expression such as "article".
        /// For the full list of built-in variables, please reference the NSX-T
        /// Administrator's Guide.
        /// </summary>
        [JsonProperty(PropertyName = "variable_name", Required = Required.AllowNull)]
        public string VariableName { get; set; }
        /// <summary>
        /// If the persistence profile path is not specified, a default
        /// persistence table is created per virtual server. Currently, only
        /// LBGenericPersistenceProfile is supported.
        /// </summary>
        [JsonProperty(PropertyName = "persistence_profile_path")]
        public string? PersistenceProfilePath { get; set; }
    }
}
