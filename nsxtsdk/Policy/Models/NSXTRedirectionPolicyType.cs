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
    public class NSXTRedirectionPolicyType : NSXTPolicyType
    {
        /// <summary>
        /// Redirection rules that are a part of this RedirectionPolicy. At
        /// max, there can be 1000 rules in a given RedirectPolicy.
        /// </summary>
        [JsonProperty(PropertyName = "rules")]
        public IList<NSXTRedirectionRuleType> Rules { get; set; }
        /// <summary>
        /// This is the read only flag which will state the direction of this |
        /// redirection policy. True denotes that it is NORTH-SOUTH and false |
        /// value means it is an EAST-WEST redirection policy.
        /// </summary>
        [JsonProperty(PropertyName = "north_south")]
        public bool? NorthSouth { get; set; }
        /// <summary>
        /// Paths to which traffic will be redirected to. As of now, only 1 is |
        /// supported. Paths allowed are |
        /// 1. Policy Service Instance |
        /// 2. Service Instance Endpoint |
        /// 3. Virtual Endpoint |
        /// 4. Policy Service Chain
        /// </summary>
        [JsonProperty(PropertyName = "redirect_to")]
        public IList<string> RedirectTo { get; set; }
    }
}
