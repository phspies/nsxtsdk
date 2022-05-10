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
    public class NSXTRouteBasedL3VpnSessionType : NSXTL3VpnSessionType
    {
        /// <summary>
        /// This is a deprecated field. Any specified value is not saved and will be ignored.
        /// </summary>
        [JsonProperty(PropertyName = "routing_config_path")]
        public string? RoutingConfigPath { get; set; }
        /// <summary>
        /// Virtual tunnel interface (VTI) port IP subnets to be used to configure
        /// route-based L3Vpn session. A max of one tunnel subnet is allowed.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_subnets", Required = Required.AllowNull)]
        public IList<NSXTTunnelSubnetType> TunnelSubnets { get; set; }
        /// <summary>
        /// Indicates if logging should be enabled for the default whitelisting
        /// rule for the VTI interface.
        /// </summary>
        [JsonProperty(PropertyName = "default_rule_logging")]
        public bool? DefaultRuleLogging { get; set; }
        /// <summary>
        /// The default firewall rule Action is set to DROP if true otherwise set to ALLOW.
        /// </summary>
        [JsonProperty(PropertyName = "force_whitelisting")]
        public bool? ForceWhitelisting { get; set; }
    }
}
