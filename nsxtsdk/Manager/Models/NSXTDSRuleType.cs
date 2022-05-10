using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDSRuleType : NSXTEmbeddedResourceType
    {
        /// <summary>
        /// Flag to indicate whether rule is default.
        /// </summary>
        [JsonProperty(PropertyName = "is_default")]
        public bool? IsDefault { get; set; }
        /// <summary>
        /// Rule direction in case of stateless distributed service rules. This will only considered if section level parameter is
        /// set to stateless. Default to IN_OUT if not specified.
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDsruleDirectionEnumType? Direction { get; set; }
        /// <summary>
        /// User level field which will be printed in CLI and packet logs.
        /// </summary>
        [JsonProperty(PropertyName = "rule_tag")]
        public string? RuleTag { get; set; }
        /// <summary>
        /// Type of IP packet that should be matched while enforcing the rule.
        /// </summary>
        [JsonProperty(PropertyName = "ip_protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDsruleIpProtocolEnumType? IpProtocol { get; set; }
        /// <summary>
        /// User notes specific to the rule.
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public string? Notes { get; set; }
        /// <summary>
        /// List of object where rule will be enforced. The section level field overrides this one. Null will be treated as any.
        /// </summary>
        [JsonProperty(PropertyName = "applied_tos")]
        public IList<NSXTResourceReferenceType> AppliedTos { get; set; }
        /// <summary>
        /// Flag to enable packet logging. Default is disabled.
        /// </summary>
        [JsonProperty(PropertyName = "logged")]
        public bool? Logged { get; set; }
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
        /// Action enforced on the packets which matches the distributed service rule. Currently DS Layer supports below actions.
        /// ALLOW           - Forward any packet when a rule with this action gets a match (Used by Firewall). DROP            -
        /// Drop any packet when a rule with this action gets a match. Packets won't go further(Used by Firewall). REJECT          -
        /// Terminate TCP connection by sending TCP reset for a packet when a rule with this action gets a match (Used by Firewall).
        /// REDIRECT        - Redirect any packet to a partner appliance when a rule with this action gets a match (Used by Service
        /// Insertion). DO_NOT_REDIRECT - Do not redirect any packet to a partner appliance when a rule with this action gets a
        /// match (Used by Service Insertion). DETECT          - Detect IDS Signatures. ALLOW_CONTINUE  - Allows rules to jump from
        /// this rule. Action on matching rules in the destination category will decide next step. Application is default
        /// destination until new categories are supported to jump to. DETECT_PREVENT  - Detect and Prevent IDS Signatures.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTDsruleActionEnumType Action { get; set; }
        /// <summary>
        /// Priority of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public long? Priority { get; set; }
        /// <summary>
        /// Negation of the source.
        /// </summary>
        [JsonProperty(PropertyName = "sources_excluded")]
        public bool? SourcesExcluded { get; set; }
        /// <summary>
        /// Negation of the destination.
        /// </summary>
        [JsonProperty(PropertyName = "destinations_excluded")]
        public bool? DestinationsExcluded { get; set; }
        /// <summary>
        /// List of the destinations. Null will be treated as any.
        /// </summary>
        [JsonProperty(PropertyName = "destinations")]
        public IList<NSXTResourceReferenceType> Destinations { get; set; }
    }
}
