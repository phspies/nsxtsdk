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
    public class NSXTIdsPolicyType : NSXTPolicyType
    {
        /// <summary>
        /// IDS Rules that are a part of this SecurityPolicy
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTIdsRuleType> Rules { get; set; }
    }
}
