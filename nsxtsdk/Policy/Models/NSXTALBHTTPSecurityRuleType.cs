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
    /// Advanced load balancer HTTPSecurityRule object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPSecurityRule object")]
    public class NSXTALBHTTPSecurityRuleType 
    {
        /// <summary>
        /// Index of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        public long Index { get; set; }
        /// <summary>
        /// Enable or disable the rule.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "enable", Required = Required.AllowNull)]
        public bool Enable { get; set; }
        /// <summary>
        /// Log HTTP request upon rule match.
        /// </summary>
        [JsonProperty(PropertyName = "log")]
        public bool? Log { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        public NSXTALBHTTPSecurityActionType Action { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        public NSXTALBMatchTargetType Match { get; set; }
        /// <summary>
        /// Name of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
    }
}
