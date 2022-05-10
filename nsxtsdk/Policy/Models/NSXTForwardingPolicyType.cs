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
    public class NSXTForwardingPolicyType : NSXTPolicyType
    {
        /// <summary>
        /// Rules that are a part of this ForwardingPolicy
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTForwardingRuleType> Rules { get; set; }
    }
}
