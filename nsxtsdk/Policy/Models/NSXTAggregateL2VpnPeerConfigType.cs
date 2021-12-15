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
    /// Aggregate of L2Vpn peer config across Enforcement Points.
    /// </summary>
    [NSXTProperty(Description: @"Aggregate of L2Vpn peer config across Enforcement Points.")]
    public class NSXTAggregateL2VpnPeerConfigType 
    {
        /// <summary>
        /// List of L2Vpn peer config per Enforcement Point.
        /// </summary>
        [JsonProperty(PropertyName = "l2vpn_peer_config_per_enforcement_point")]
        [NSXTProperty(IsRequired: false, Description: @"List of L2Vpn peer config per Enforcement Point.")]
        public IList<NSXTL2VpnPeerConfigPerEnforcementPointType> L2vpnPeerConfigPerEnforcementPoint { get; set; }
        /// <summary>
        /// Policy path referencing the L2Vpn.
        /// </summary>
        [JsonProperty(PropertyName = "l2vpn_path", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Policy path referencing the L2Vpn.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string L2vpnPath { get; set; }
    }
}