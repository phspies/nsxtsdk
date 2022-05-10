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
    public class NSXTL2VPNSessionPeerConfigNsxTType : NSXTL2VPNSessionPeerConfigPerEPType
    {
        /// <summary>
        /// List of peer codes per transport tunnel.
        /// </summary>
        [JsonProperty(PropertyName = "peer_codes")]
        public IList<NSXTL2VPNSessionTransportTunnelPeerCodeType> PeerCodes { get; set; }
    }
}
