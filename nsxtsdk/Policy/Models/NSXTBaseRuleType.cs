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
    public class NSXTBaseRuleType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Flag to disable the rule. Default is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "disabled")]
        public bool? Disabled { get; set; }
        /// <summary>
        /// Define direction of traffic.
        /// </summary>
        [JsonProperty(PropertyName = "direction")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBaseRuleDirectionEnumType? Direction { get; set; }
        /// <summary>
        /// Type of IP packet that should be matched while enforcing the rule.
        /// The value is set to IPV4_IPV6 for Layer3 rule if not specified.
        /// For Layer2/Ether rule the value must be null.
        /// </summary>
        [JsonProperty(PropertyName = "ip_protocol")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTBaseRuleIpProtocolEnumType? IpProtocol { get; set; }
        /// <summary>
        /// Text for additional notes on changes.
        /// </summary>
        [JsonProperty(PropertyName = "notes")]
        public string? Notes { get; set; }
        /// <summary>
        /// Flag to enable packet logging. Default is disabled.
        /// </summary>
        [JsonProperty(PropertyName = "logged")]
        public bool? Logged { get; set; }
        /// <summary>
        /// Holds the list of layer 7 service profile paths. These profiles accept
        /// attributes and sub-attributes of various network services
        /// (e.g. L4 AppId, encryption algorithm, domain name, etc) as key value
        /// pairs. Instead of Layer 7 service profiles you can use a L7 access profile.
        /// One of either Layer 7 service profiles or L7 Access Profile can be used in firewall rule.
        /// In case of L7 access profile only one is allowed.
        /// </summary>
        [JsonProperty(PropertyName = "profiles")]
        public IList<string> Profiles { get; set; }
        /// <summary>
        /// This is a unique 4 byte positive number that is assigned by the system.
        /// This rule id is passed all the way down to the data path. The first 1GB
        /// (1000 to 2^30) will be shared by GM and LM with zebra style striped
        /// number space. For E.g 1000 to (1Million -1) by LM, (1M - 2M-1) by GM
        /// and so on.
        /// </summary>
        [JsonProperty(PropertyName = "rule_id")]
        public long? RuleId { get; set; }
        /// <summary>
        /// A flag to indicate whether rule is a default rule.
        /// </summary>
        [JsonProperty(PropertyName = "is_default")]
        public bool? IsDefault { get; set; }
        /// <summary>
        /// User level field which will be printed in CLI and packet logs.
        /// Even though there is no limitation on length of a tag, internally
        /// tag will get truncated after 32 characters.
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string? Tag { get; set; }
        /// <summary>
        /// We need paths as duplicate names may exist for groups under different
        /// domains. Along with paths we support IP Address of type IPv4 and IPv6.
        /// IP Address can be in one of the format(CIDR, IP Address, Range of IP Address).
        /// In order to specify all groups, use the constant "ANY". This
        /// is case insensitive. If "ANY" is used, it should be the ONLY element
        /// in the group array. Error will be thrown if ANY is used in conjunction
        /// with other values.
        /// </summary>
        [JsonProperty(PropertyName = "source_groups")]
        public IList<string> SourceGroups { get; set; }
        /// <summary>
        /// We need paths as duplicate names may exist for groups under different
        /// domains. Along with paths we support IP Address of type IPv4 and IPv6.
        /// IP Address can be in one of the format(CIDR, IP Address, Range of IP Address).
        /// In order to specify all groups, use the constant "ANY". This
        /// is case insensitive. If "ANY" is used, it should be the ONLY element
        /// in the group array. Error will be thrown if ANY is used in conjunction
        /// with other values.
        /// </summary>
        [JsonProperty(PropertyName = "destination_groups")]
        public IList<string> DestinationGroups { get; set; }
        /// <summary>
        /// In order to specify all services, use the constant "ANY".
        /// This is case insensitive. If "ANY" is used, it should
        /// be the ONLY element in the services array. Error will be thrown
        /// if ANY is used in conjunction with other values.
        /// </summary>
        [JsonProperty(PropertyName = "services")]
        public IList<string> Services { get; set; }
        /// <summary>
        /// The list of policy paths where the rule is applied
        /// LR/Edge/T0/T1/LRP etc. Note that a given rule can be applied
        /// on multiple LRs/LRPs.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public IList<string> Scope { get; set; }
        /// <summary>
        /// In order to specify raw services this can be used,
        /// along with services which contains path to services.
        /// This can be empty or null.
        /// </summary>
        [JsonProperty(PropertyName = "service_entries")]
        public IList<NSXTServiceEntryType> ServiceEntries { get; set; }
        /// <summary>
        /// If set to true, the rule gets applied on all the groups that are
        /// NOT part of the destination groups. If false, the rule applies to the
        /// destination groups
        /// </summary>
        [JsonProperty(PropertyName = "destinations_excluded")]
        public bool? DestinationsExcluded { get; set; }
        /// <summary>
        /// This field is used to resolve conflicts between multiple
        /// Rules under Security or Gateway Policy for a Domain
        /// If no sequence number is specified in the payload, a value of 0 is
        /// assigned by default. If there are multiple rules with the same
        /// sequence number then their order is not deterministic. If a specific
        /// order of rules is desired, then one has to specify unique sequence
        /// numbers or use the POST request on the rule entity with
        /// a query parameter action=revise to let the framework assign a
        /// sequence number
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        public int? SequenceNumber { get; set; }
        /// <summary>
        /// If set to true, the rule gets applied on all the groups that are
        /// NOT part of the source groups. If false, the rule applies to the
        /// source groups
        /// </summary>
        [JsonProperty(PropertyName = "sources_excluded")]
        public bool? SourcesExcluded { get; set; }
    }
}
