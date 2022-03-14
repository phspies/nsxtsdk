// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTUplinkHostSwitchProfileType : NSXTBaseHostSwitchProfileType
    {
        /// <summary>
        /// list of LACP group
        /// </summary>
        public IList<NSXTLagType> Lags { get; set; }
        /// <summary>
        /// VLAN used for tagging Overlay traffic of associated HostSwitch
        /// </summary>
        public long? TransportVlan { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "teaming", Required = Required.AllowNull)]
        public NSXTTeamingPolicyType Teaming { get; set; }
        /// <summary>
        /// The protocol used to encapsulate overlay traffic
        /// </summary>
        public NSXTUplinkHostSwitchProfileOverlayEncapEnumType? OverlayEncap { get; set; }
        /// <summary>
        /// List of named uplink teaming policies that can be used by logical switches
        /// </summary>
        public IList<NSXTNamedTeamingPolicyType> NamedTeamings { get; set; }
        /// <summary>
        /// Maximum Transmission Unit used for uplinks
        /// </summary>
        public int? Mtu { get; set; }
    }
}
