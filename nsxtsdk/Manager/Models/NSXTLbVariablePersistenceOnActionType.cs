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
    public class NSXTLbVariablePersistenceOnActionType : NSXTLbRuleActionType
    {
        /// <summary>
        /// The property is used to enable a hash operation for variable value
        /// when composing the persistence key.
        /// </summary>
        [JsonProperty(PropertyName = "variable_hash_enabled")]
        public bool? VariableHashEnabled { get; set; }
        /// <summary>
        /// The property is the name of variable to be used. It specifies which
        /// variable's value of a HTTP Request will be used in the key of
        /// persistence entry. The variable can be a system embedded variable such
        /// as "_cookie_JSESSIONID", a customized variable defined in
        /// LbVariableAssignmentAction or a captured variable in regular expression
        /// such as "article".
        /// </summary>
        [JsonProperty(PropertyName = "variable_name", Required = Required.AllowNull)]
        public string VariableName { get; set; }
        /// <summary>
        /// If the persistence profile UUID is not specified, a default
        /// persistence table is created per virtual server. Currently, only
        /// LbGenericPersistenceProfile is supported.
        /// </summary>
        [JsonProperty(PropertyName = "persistence_profile_id")]
        public string? PersistenceProfileId { get; set; }
    }
}
