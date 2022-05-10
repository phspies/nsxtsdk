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
    /// Advanced load balancer L4RuleAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer L4RuleAction object")]
    public class NSXTALBL4RuleActionType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "select_pool")]
        public NSXTALBL4RuleActionSelectPoolType SelectPool { get; set; }
    }
}
