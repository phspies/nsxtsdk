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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTL2VpnPeerCodesType : NSXTL2VpnPeerConfigPerEnforcementPointType
    {
        /// <summary>
        /// List of peer codes per transport tunnel.
        /// </summary>
        [JsonProperty(PropertyName = "peer_codes", Required = Required.AllowNull)]
        public IList<NSXTL2VpnTransportTunnelPeerCodeType> PeerCodes { get; set; }
    }
}
