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
    public class NSXTIPSecVpnRuleType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// List of local subnets. Specifying no value is interpreted
        /// as 0.0.0.0/0.
        /// </summary>
        [JsonProperty(PropertyName = "sources")]
        public IList<NSXTIPSecVpnSubnetType> Sources { get; set; }
        /// <summary>
        /// PROTECT - Protect rules are defined per policy based
        /// IPSec VPN session.
        /// BYPASS - Bypass rules are defined per IPSec VPN
        /// service and affects all policy based IPSec VPN sessions.
        /// Bypass rules are prioritized over protect rules.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpnRuleActionEnumType? Action { get; set; }
        /// <summary>
        /// A flag to enable/disable the rule.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// A flag to enable/disable the logging for the rule.
        /// </summary>
        [JsonProperty(PropertyName = "logged")]
        public bool? Logged { get; set; }
        /// <summary>
        /// A sequence number is used to give a priority to an IPSecVpnRule.
        /// </summary>
        [JsonProperty(PropertyName = "sequence_number")]
        public int? SequenceNumber { get; set; }
        /// <summary>
        /// List of peer subnets. Specifying no value is interpreted
        /// as 0.0.0.0/0.
        /// </summary>
        [JsonProperty(PropertyName = "destinations")]
        public IList<NSXTIPSecVpnSubnetType> Destinations { get; set; }
    }
}
