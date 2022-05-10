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
    public class NSXTIPSecVPNPolicyRuleType : NSXTEmbeddedResourceType
    {
        /// <summary>
        /// List of local subnets.
        /// </summary>
        [JsonProperty(PropertyName = "sources")]
        public IList<NSXTIPSecVPNPolicySubnetType> Sources { get; set; }
        /// <summary>
        /// PROTECT - Protect rules are defined per policy based
        /// IPSec VPN session.
        /// BYPASS - Bypass rules are defined per IPSec VPN
        /// service and affects all policy based IPSec VPN sessions.
        /// Bypass rules are prioritized over protect rules.
        /// </summary>
        [JsonProperty(PropertyName = "action")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpnpolicyRuleActionEnumType? Action { get; set; }
        /// <summary>
        /// A flag to enable/disable the policy rule.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }
        /// <summary>
        /// A flag to enable/disable the logging for the policy rule.
        /// </summary>
        [JsonProperty(PropertyName = "logged")]
        public bool? Logged { get; set; }
        /// <summary>
        /// Unique policy id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
        /// <summary>
        /// List of peer subnets.
        /// </summary>
        [JsonProperty(PropertyName = "destinations")]
        public IList<NSXTIPSecVPNPolicySubnetType> Destinations { get; set; }
    }
}
