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
    /// Advanced load balancer HTTPRequestRule object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPRequestRule object")]
    public class NSXTALBHTTPRequestRuleType 
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
        /// Log all HTTP headers upon rule match.
        /// </summary>
        [JsonProperty(PropertyName = "all_headers")]
        [NSXTProperty(IsRequired: false, Description: @"Log all HTTP headers upon rule match.")]
        public bool? AllHeaders { get; set; }
        /// <summary>
        /// HTTP request URL rewrite action.
        /// </summary>
        [JsonProperty(PropertyName = "rewrite_url_action")]
        [NSXTProperty(IsRequired: false, Description: @"HTTP request URL rewrite action.")]
        public NSXTALBHTTPRewriteURLActionType RewriteUrlAction { get; set; }
        /// <summary>
        /// Content switching action.
        /// </summary>
        [JsonProperty(PropertyName = "switching_action")]
        [NSXTProperty(IsRequired: false, Description: @"Content switching action.")]
        public NSXTALBHTTPSwitchingActionType SwitchingAction { get; set; }
        /// <summary>
        /// HTTP redirect action.
        /// </summary>
        [JsonProperty(PropertyName = "redirect_action")]
        [NSXTProperty(IsRequired: false, Description: @"HTTP redirect action.")]
        public NSXTALBHTTPRedirectActionType RedirectAction { get; set; }
        /// <summary>
        /// Name of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Name of the rule.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Name { get; set; }
        /// <summary>
        /// Add match criteria to the rule.
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        [NSXTProperty(IsRequired: false, Description: @"Add match criteria to the rule.")]
        public NSXTALBMatchTargetType Match { get; set; }
        /// <summary>
        /// HTTP header rewrite action.
        /// </summary>
        [JsonProperty(PropertyName = "hdr_action")]
        [NSXTProperty(IsRequired: false, Description: @"HTTP header rewrite action.")]
        public IList<NSXTALBHTTPHdrActionType> HdrAction { get; set; }
    }
}