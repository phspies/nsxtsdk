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
    /// Advanced load balancer AuthorizationRule object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AuthorizationRule object")]
    public class NSXTALBAuthorizationRuleType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        public NSXTALBAuthorizationActionType Action { get; set; }
        /// <summary>
        /// Index of the Authorization Policy rule.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        public long Index { get; set; }
        /// <summary>
        /// Enable or disable the rule.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "enable")]
        public bool? Enable { get; set; }
        /// <summary>
        /// Name of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "match", Required = Required.AllowNull)]
        public NSXTALBAuthorizationMatchType Match { get; set; }
    }
}
