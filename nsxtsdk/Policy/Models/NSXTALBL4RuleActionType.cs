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
    /// Advanced load balancer L4RuleAction object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer L4RuleAction object")]
    public class NSXTALBL4RuleActionType 
    {
        public NSXTALBL4RuleActionType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "select_pool")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTALBL4RuleActionSelectPoolType SelectPool { get; set; }
    }
}
