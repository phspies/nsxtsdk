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
    public class NSXTPolicyNatRuleType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// This supports single IP address or comma separated list of single IP
        /// addresses or CIDR. This does not support IP range or IP sets.
        /// For SNAT, DNAT, NAT64 and REFLEXIVE rules, this ia a mandatory field, which
        /// represents the translated network address.
        /// For NO_SNAT and NO_DNAT this should be empty.
        /// </summary>
        [JsonProperty(PropertyName = "translated_network")]
        public string? TranslatedNetwork { get; set; }
        /// <summary>
        /// The flag, which suggests whether the logging of NAT rule is enabled or
        /// disabled. The default is False.
        /// </summary>
        [JsonProperty(PropertyName = "logging")]
        public bool? Logging { get; set; }
        /// <summary>
        /// It represents the path of Service on which the NAT rule will be applied.
        /// If not provided or if it is blank then Policy manager will consider it
        /// as ANY.
        /// Please note, if this is a DNAT, the destination_port of the service will
        /// be realized on NSX Manager as the translated_port. And if this is a SNAT,
        /// the destination_port will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "service")]
        public string? Service { get; set; }
        /// <summary>
        /// This supports single IP address or comma separated list of single IP
        /// addresses or CIDR. This does not support IP range or IP sets.
        /// For SNAT, NO_SNAT, NAT64 and REFLEXIVE rules, this is a mandatory field and
        /// represents the source network of the packets leaving the network.
        /// For DNAT and NO_DNAT rules, optionally it can contain source network
        /// of incoming packets.
        /// NULL value for this field represents ANY network.
        /// </summary>
        [JsonProperty(PropertyName = "source_network")]
        public string? SourceNetwork { get; set; }
        /// <summary>
        /// The flag, which suggests whether the NAT rule is enabled or
        /// disabled. The default is True.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// Please note, if there is service configured in this NAT rule, the translated_port
        /// will be realized on NSX Manager as the destination_port. If there is no sevice configured,
        /// the port will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "translated_ports")]
        public string? TranslatedPorts { get; set; }
        /// <summary>
        /// Source NAT(SNAT) - translates a source IP address in an outbound packet so that
        /// the packet appears to originate from a different network. SNAT is only supported
        /// when the logical router is running in active-standby mode.
        /// Destination NAT(DNAT) - translates the destination IP address of inbound packets
        /// so that packets are delivered to a target address into another network. DNAT is
        /// only supported when the logical router is running in active-standby mode.
        /// Reflexive NAT(REFLEXIVE) - IP-Range and CIDR are supported to define the "n".
        /// The number of original networks should be exactly the same as that of
        /// translated networks. The address translation is deterministic. Reflexive is
        /// supported on both Active/Standby and Active/Active LR.
        /// NO_SNAT and NO_DNAT - These do not have support for translated_fields, only
        /// source_network and destination_network fields are supported.
        /// NAT64 - translates an external IPv6 address to a internal IPv4 address.
        /// </summary>
        [JsonProperty(PropertyName = "action", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyNatRuleActionEnumType Action { get; set; }
        /// <summary>
        /// Represents the array of policy paths of ProviderInterface or NetworkInterface or
        /// labels of type ProviderInterface or NetworkInterface or IPSecVpnSession on which the NAT rule should
        /// get enforced.
        /// The interfaces must belong to the same router for which the NAT Rule is created.
        /// </summary>
        [JsonProperty(PropertyName = "scope")]
        public IList<string> Scope { get; set; }
        /// <summary>
        /// It indicates how the firewall matches the address after NATing if firewall
        /// stage is not skipped.
        /// 
        /// MATCH_EXTERNAL_ADDRESS indicates the firewall will be applied to external address
        /// of a NAT rule. For SNAT, the external address is the translated source address
        /// after NAT is done. For DNAT, the external address is the original destination
        /// address before NAT is done. For REFLEXIVE, to egress traffic, the firewall
        /// will be applied to the translated source address after NAT is done; To ingress
        /// traffic, the firewall will be applied to the original destination address
        /// before NAT is done.
        /// 
        /// MATCH_INTERNAL_ADDRESS indicates the firewall will be applied to internal
        /// address of a NAT rule. For SNAT, the internal address is the original source
        /// address before NAT is done. For DNAT, the internal address is the translated
        /// destination address after NAT is done. For REFLEXIVE, to egress traffic, the
        /// firewall will be applied to the original source address before NAT is done;
        /// To ingress traffic, the firewall will be applied to the translated destination
        /// address after NAT is done.
        /// 
        /// BYPASS indicates the firewall stage will be skipped.
        /// 
        /// For NO_SNAT or NO_DNAT, it must be BYPASS or leave it unassigned
        /// </summary>
        [JsonProperty(PropertyName = "firewall_match")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTPolicyNatRuleFirewallMatchEnumType? FirewallMatch { get; set; }
        /// <summary>
        /// This supports single IP address or comma separated list of single IP
        /// addresses or CIDR. This does not support IP range or IP sets.
        /// For DNAT and NO_DNAT rules, this is a mandatory field, and represents
        /// the destination network for the incoming packets.
        /// For other type of rules, optionally it can contain destination network
        /// of outgoing packets.
        /// NULL value for this field represents ANY network.
        /// </summary>
        [JsonProperty(PropertyName = "destination_network")]
        public string? DestinationNetwork { get; set; }
        /// <summary>
        /// The sequence_number decides the rule_priority of a NAT rule.
        /// Sequence_number and rule_priority have 1:1 mapping.For each NAT section,
        /// there will be reserved rule_priority numbers.The valid range of
        /// rule_priority number is from 0 to 2147483647(MAX_INT).
        /// 1. INTERNAL section
        /// rule_priority reserved from 0 - 1023 (1024 rules)
        /// valid sequence_number range  0 - 1023
        /// 2. USER section
        /// rule_priority reserved from 1024 - 2147482623 (2147481600 rules)
        /// valid sequence_number range  0 - 2147481599
        /// 3. DEFAULT section
        /// rule_priority reserved from 2147482624 - 2147483647 (1024 rules)
        /// valid sequence_number range  0 - 1023
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        public int? SequenceNumber { get; set; }
    }
}
