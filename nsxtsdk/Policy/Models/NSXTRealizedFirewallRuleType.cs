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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTRealizedFirewallRuleType : NSXTPolicyRealizedResourceType
    {
        public NSXTRealizedFirewallRuleType()
        {
            Direction = test
        }
        /// <summary>
        /// Flag to disable rule. Disabled will only be persisted but never provisioned/realized.
        /// </summary>
        [JsonProperty(PropertyName = "disabled")]
        [NSXTProperty(IsRequired: false, Description: @"Flag to disable rule. Disabled will only be persisted but never provisioned/realized.")]
        public bool? Disabled { get; set; }
        /// <summary>
        /// List of sources. Null will be treated as any.
        /// </summary>
        [JsonProperty(PropertyName = "sources")]
        [NSXTProperty(IsRequired: false, Description: @"List of sources. Null will be treated as any.")]
        public IList<NSXTResourceReferenceType> Sources { get; set; }
        /// <summary>
        /// Rule direction in case of stateless firewall rules. This will only considered if section level parameter is set to
        /// stateless. Default to IN_OUT if not specified.
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        [NSXTProperty(IsRequired: false, Description: @"Rule direction in case of stateless firewall rules. This will only considered if section level parameter is set to stateless. Default to IN_OUT if not specified.")]
        public NSXTRealizedFirewallRuleDirectionEnumType? Direction { get; set; }
        /// <summary>
        /// List of the services. Null will be treated as any.
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        [NSXTProperty(IsRequired: false, Description: @"List of the services. Null will be treated as any.")]
        public IList<NSXTResourceReferenceType> Services { get; set; }
        /// <summary>
        /// Action enforced on the packets which matches the firewall rule.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [NSXTProperty(IsRequired: false, Description: @"Action enforced on the packets which matches the firewall rule.")]
        public NSXTRealizedFirewallRuleActionEnumType? Action { get; set; }
        /// <summary>
        /// List of the destinations. Null will be treated as any.
        /// </summary>
        [JsonProperty(PropertyName = "destinations")]
        [NSXTProperty(IsRequired: false, Description: @"List of the destinations. Null will be treated as any.")]
        public IList<NSXTResourceReferenceType> Destinations { get; set; }
    }
}
