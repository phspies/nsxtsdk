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
    /// Segment specific L2 VPN configuration
    /// </summary>
    [NSXTProperty(Description: @"Segment specific L2 VPN configuration")]
    public class NSXTL2ExtensionType 
    {
        /// <summary>
        /// Policy paths corresponding to the associated L2 VPN sessions
        /// </summary>
        [JsonProperty(PropertyName = "l2vpn_paths")]
        [NSXTProperty(IsRequired: false, Description: @"Policy paths corresponding to the associated L2 VPN sessions")]
        public IList<string> L2vpnPaths { get; set; }
        /// <summary>
        /// Local Egress.
        /// </summary>
        [JsonProperty(PropertyName = "local_egress")]
        [NSXTProperty(IsRequired: false, Description: @"Local Egress.")]
        public NSXTLocalEgressType LocalEgress { get; set; }
        /// <summary>
        /// This property has been deprecated. Please use the property l2vpn_paths
        /// for setting the paths of associated L2 VPN session. This property will
        /// continue to work as expected to provide backwards compatibility.
        /// However, when both l2vpn_path and l2vpn_paths properties
        /// are specified, only l2vpn_paths is used.
        /// </summary>
        [JsonProperty(PropertyName = "l2vpn_path")]
        [NSXTProperty(IsRequired: false, Description: @"This property has been deprecated. Please use the property l2vpn_pathsfor setting the paths of associated L2 VPN session. This property willcontinue to work as expected to provide backwards compatibility.However, when both l2vpn_path and l2vpn_paths propertiesare specified, only l2vpn_paths is used.")]
        public string? L2vpnPath { get; set; }
        /// <summary>
        /// Tunnel ID
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_id")]
        [NSXTProperty(IsRequired: false, Description: @"Tunnel ID")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(4093)]
        public long? TunnelId { get; set; }
    }
}
