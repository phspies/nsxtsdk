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
    /// Advanced load balancer SensitiveLogProfile object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SensitiveLogProfile object")]
    public class NSXTALBSensitiveLogProfileType 
    {
        /// <summary>
        /// Match sensitive header fields in HTTP application log.
        /// </summary>
        [JsonProperty(PropertyName = "header_field_rules")]
        public IList<NSXTALBSensitiveFieldRuleType> HeaderFieldRules { get; set; }
        /// <summary>
        /// Match sensitive WAF log fields in HTTP application log.
        /// </summary>
        [JsonProperty(PropertyName = "waf_field_rules")]
        public IList<NSXTALBSensitiveFieldRuleType> WafFieldRules { get; set; }
        /// <summary>
        /// Match sensitive URI query params in HTTP application log.
        /// Query params from the URI are extracted and checked for
        /// matching sensitive parameter names.
        /// A successful match will mask the parameter values in
        /// accordance with this rule action.
        /// </summary>
        [JsonProperty(PropertyName = "uri_query_field_rules")]
        public IList<NSXTALBSensitiveFieldRuleType> UriQueryFieldRules { get; set; }
    }
}
