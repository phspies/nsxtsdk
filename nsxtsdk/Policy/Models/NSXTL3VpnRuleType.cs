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
    public class NSXTL3VpnRuleType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Action to exchange data with or without protection.
        /// PROTECT - Allows to exchange data with ipsec protection. Protect rules are defined per
        /// L3Vpn.
        /// BYPASS - Allows to exchange data without ipsec protection. Bypass rules are defined per
        /// L3VpnContext and affects all policy based L3Vpns. Bypass rules are prioritized over
        /// protect rules.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL3VpnRuleActionEnumType? Action { get; set; }
        /// <summary>
        /// List of local subnets used in policy-based L3Vpn.
        /// </summary>
        [JsonProperty(PropertyName = "sources", Required = Required.AllowNull)]
        public IList<NSXTL3VpnSubnetType> Sources { get; set; }
        /// <summary>
        /// This field is used to resolve conflicts between multiple L3VpnRules associated with a
        /// single L3Vpn or L3VpnContext.
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        public int? SequenceNumber { get; set; }
        /// <summary>
        /// List of remote subnets used in policy-based L3Vpn.
        /// </summary>
        [JsonProperty(PropertyName = "destinations", Required = Required.AllowNull)]
        public IList<NSXTL3VpnSubnetType> Destinations { get; set; }
    }
}
