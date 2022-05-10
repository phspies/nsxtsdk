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
    /// List of ServiceInsertion Rules.
    /// </summary>
    [NSXTProperty(Description: @"List of ServiceInsertion Rules.")]
    public class NSXTServiceInsertionRuleListType 
    {
        /// <summary>
        /// List of ServiceInsertion rules in the section. Only homogeneous rules are supported.
        /// </summary>
        [JsonProperty(PropertyName = "rules", Required = Required.AllowNull)]
        public IList<NSXTServiceInsertionRuleType> Rules { get; set; }
    }
}
