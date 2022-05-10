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
    /// Aggregate of L2Vpn peer config across Enforcement Points.
    /// </summary>
    [NSXTProperty(Description: @"Aggregate of L2Vpn peer config across Enforcement Points.")]
    public class NSXTAggregateL2VpnPeerConfigType 
    {
        /// <summary>
        /// List of L2Vpn peer config per Enforcement Point.
        /// </summary>
        [JsonProperty(PropertyName = "l2vpn_peer_config_per_enforcement_point")]
        public IList<NSXTL2VpnPeerConfigPerEnforcementPointType> L2vpnPeerConfigPerEnforcementPoint { get; set; }
        /// <summary>
        /// Policy path referencing the L2Vpn.
        /// </summary>
        [JsonProperty(PropertyName = "l2vpn_path", Required = Required.AllowNull)]
        public string L2vpnPath { get; set; }
    }
}
