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
    public class NSXTRealizedFirewallRuleType : NSXTPolicyRealizedResourceType
    {
        /// <summary>
        /// Flag to disable rule. Disabled will only be persisted but never provisioned/realized.
        /// </summary>
        [JsonProperty(PropertyName = "disabled")]
        public bool? Disabled { get; set; }
        /// <summary>
        /// List of sources. Null will be treated as any.
        /// </summary>
        [JsonProperty(PropertyName = "sources")]
        public IList<NSXTResourceReferenceType> Sources { get; set; }
        /// <summary>
        /// Rule direction in case of stateless firewall rules. This will only considered if section level parameter is set to
        /// stateless. Default to IN_OUT if not specified.
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRealizedFirewallRuleDirectionEnumType? Direction { get; set; }
        /// <summary>
        /// List of the services. Null will be treated as any.
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public IList<NSXTResourceReferenceType> Services { get; set; }
        /// <summary>
        /// Action enforced on the packets which matches the firewall rule.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTRealizedFirewallRuleActionEnumType? Action { get; set; }
        /// <summary>
        /// List of the destinations. Null will be treated as any.
        /// </summary>
        [JsonProperty(PropertyName = "destinations")]
        public IList<NSXTResourceReferenceType> Destinations { get; set; }
    }
}
