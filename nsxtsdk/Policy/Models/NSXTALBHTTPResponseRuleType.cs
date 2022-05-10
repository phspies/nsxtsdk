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
    /// Advanced load balancer HTTPResponseRule object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer HTTPResponseRule object")]
    public class NSXTALBHTTPResponseRuleType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "loc_hdr_action")]
        public NSXTALBHTTPRewriteLocHdrActionType LocHdrAction { get; set; }
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
        /// Name of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "name", Required = Required.AllowNull)]
        public string Name { get; set; }
        /// <summary>
        /// Log all HTTP headers upon rule match.
        /// </summary>
        [JsonProperty(PropertyName = "all_headers")]
        public bool? AllHeaders { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        public NSXTALBResponseMatchTargetType Match { get; set; }
        /// <summary>
        /// HTTP header rewrite action.
        /// </summary>
        [JsonProperty(PropertyName = "hdr_action")]
        public IList<NSXTALBHTTPHdrActionType> HdrAction { get; set; }
    }
}
