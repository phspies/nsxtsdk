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
    /// Advanced load balancer SensitiveFieldRule object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer SensitiveFieldRule object")]
    public class NSXTALBSensitiveFieldRuleType 
    {
        /// <summary>
        /// Action for the matched log field, for instance the matched
        /// field can be removed or masked off.
        /// Enum options - LOG_FIELD_REMOVE, LOG_FIELD_MASKOFF.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as LOG_FIELD_REMOVE.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbsensitiveFieldRuleActionEnumType? Action { get; set; }
        /// <summary>
        /// Index of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        public long? Index { get; set; }
        /// <summary>
        /// Enable rule to match the sensitive fields.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Name of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        public NSXTALBStringMatchType Match { get; set; }
    }
}
