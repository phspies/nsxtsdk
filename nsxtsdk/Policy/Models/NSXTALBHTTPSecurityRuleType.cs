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
    /// Advanced load balancer HTTPSecurityRule object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPSecurityRule object")]
    public class NSXTALBHTTPSecurityRuleType 
    {
        /// <summary>
        /// Index of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "index", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Index of the rule.")]
        [System.ComponentModel.DataAnnotations.Required]
        public long Index { get; set; }
        /// <summary>
        /// Enable or disable the rule.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "enable", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Enable or disable the rule.Default value when not specified in API or module isinterpreted by ALB Controller as true.")]
        [System.ComponentModel.DataAnnotations.Required]
        [NSXTDefaultProperty(Default: "")]
        public bool Enable { get; set; }
        /// <summary>
        /// Log HTTP request upon rule match.
        /// </summary>
        [JsonProperty(PropertyName = "log")]
        [NSXTProperty(IsRequired: false, Description: @"Log HTTP request upon rule match.")]
        public bool? Log { get; set; }
        /// <summary>
        /// Action to be performed upon successful matching.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [NSXTProperty(IsRequired: false, Description: @"Action to be performed upon successful matching.")]
        public NSXTALBHTTPSecurityActionType Action { get; set; }
        /// <summary>
        /// Add match criteria to the rule.
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        [NSXTProperty(IsRequired: false, Description: @"Add match criteria to the rule.")]
        public NSXTALBMatchTargetType Match { get; set; }
        /// <summary>
        /// Name of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Name of the rule.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
    }
}
