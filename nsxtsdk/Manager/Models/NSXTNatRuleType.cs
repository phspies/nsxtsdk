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
    public class NSXTNatRuleType : NSXTManagedResourceType
    {
        /// <summary>
        /// IP Address | CIDR | (null implies Any)
        /// </summary>
        [JsonProperty(PropertyName = "match_destination_network")]
        public string? MatchDestinationNetwork { get; set; }
        /// <summary>
        /// The translated address for the matched IP packet. For a SNAT, it can be
        /// a single ip address, an ip range, or a CIDR block. For a DNAT and
        /// a REFLEXIVE, it can be a single ip address or a CIDR block. Translated
        /// network is not supported for NO_SNAT or NO_DNAT.
        /// </summary>
        [JsonProperty(PropertyName = "translated_network")]
        public string? TranslatedNetwork { get; set; }
        /// <summary>
        /// Ascending, valid range [0-2147483647]. If multiple rules have the same
        /// priority, evaluation sequence is undefined.
        /// </summary>
        [JsonProperty(PropertyName = "rule_priority")]
        public long? RulePriority { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "match_service")]
        public NSXTNSServiceElementType MatchService { get; set; }
        /// <summary>
        /// Holds the list of LogicalRouterPort Ids that a NAT rule can be applied to. The LogicalRouterPort used must belong to the
        /// same LogicalRouter for which the NAT Rule is created. As of now a NAT rule can only have a single LogicalRouterPort as
        /// applied_tos. When applied_tos is not set, the NAT rule is applied to all LogicalRouterPorts beloging to the
        /// LogicalRouter.
        /// </summary>
        [JsonProperty(PropertyName = "applied_tos")]
        public IList<NSXTResourceReferenceType> AppliedTos { get; set; }
        /// <summary>
        /// Indicator to enable/disable the rule.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Internal NAT rule uuid for debug used in Controller and backend.
        /// </summary>
        [JsonProperty(PropertyName = "internal_rule_id")]
        public string? InternalRuleId { get; set; }
        /// <summary>
        /// Enable/disable the logging of rule.
        /// </summary>
        [JsonProperty(PropertyName = "logging")]
        public bool? Logging { get; set; }
        /// <summary>
        /// The translated port(s) for the mtached IP packet. It can be a single
        /// port or a port range. Please note, port translating is supported only
        /// for DNAT.
        /// </summary>
        [JsonProperty(PropertyName = "translated_ports")]
        public string? TranslatedPorts { get; set; }
        /// <summary>
        /// Valid actions: SNAT, DNAT, NO_SNAT, NO_DNAT, REFLEXIVE, NAT64. All
        /// rules in a logical router are either stateless or stateful. Mix is
        /// not supported. SNAT and DNAT are stateful, can NOT be supported when
        /// the logical router is running at active-active HA mode; REFLEXIVE
        /// is stateless. NO_SNAT and NO_DNAT have no translated_fields, only
        /// match fields are supported.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNatRuleActionEnumType Action { get; set; }
        /// <summary>
        /// Indicate how firewall is applied to a traffic packet. Firewall can be
        /// bypassed, or be applied to external/internal address of NAT rule.
        /// 
        /// The firewall_match will take priority over nat_pass. If the firewall_match
        /// is not provided, the nat_pass will be picked up.
        /// </summary>
        [JsonProperty(PropertyName = "firewall_match")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTNatRuleFirewallMatchEnumType? FirewallMatch { get; set; }
        /// <summary>
        /// Default is true. If the nat_pass is set to true, the following firewall
        /// stage will be skipped. Please note, if action is NO_SNAT or NO_DNAT,
        /// then nat_pass must be set to true or omitted.
        /// 
        /// Nat_pass was deprecated with an alternative firewall_match. Please stop
        /// using nat_pass to specify whether firewall stage is skipped. if you want
        /// to skip, please set firewall_match to BYPASS. If you do not want to skip,
        /// please set the firewall_match to MATCH_EXTERNAL_ADDRESS or
        /// MATCH_INTERNAL_ADDRESS.
        /// 
        /// Please note, the firewall_match will take priority over the nat_pass.
        /// If both are provided, the nat_pass is ignored. If firewall_match is not
        /// provided while the nat_pass is specified, the nat_pass will still be
        /// picked up. In this case, if nat_pass is set to false, firewall rule will
        /// be applied on internall address of a packet, i.e. MATCH_INTERNAL_ADDRESS.
        /// </summary>
        [JsonProperty(PropertyName = "nat_pass")]
        public bool? NatPass { get; set; }
        /// <summary>
        /// The logical router id which the nat rule runs on.
        /// </summary>
        [JsonProperty(PropertyName = "logical_router_id")]
        public string? LogicalRouterId { get; set; }
        /// <summary>
        /// IP Address | CIDR | (null implies Any)
        /// </summary>
        [JsonProperty(PropertyName = "match_source_network")]
        public string? MatchSourceNetwork { get; set; }
    }
}
