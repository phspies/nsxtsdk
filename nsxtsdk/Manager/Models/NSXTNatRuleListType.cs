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
    public class NSXTNatRuleListType 
    {
        /// <summary>
        /// Add new NatRules to the list in Bulk creation.
        /// </summary>
        [JsonProperty(PropertyName = "rules", Required = Required.AllowNull)]
        public IList<NSXTNatRuleType> Rules { get; set; }
    }
}
