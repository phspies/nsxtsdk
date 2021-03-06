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
    /// Get the peer_code for each tunnel to paste on the remote end of the tunnel. Currently only stand-along/unmanaged edge is
        /// supported on the remote end of the tunnel.
    /// </summary>
    [NSXTProperty(Description: @"Get the peer_code for each tunnel to paste on the remote end of the tunnel. Currently only stand-along/unmanaged edge is supported on the remote end of the tunnel.")]
    public class NSXTL2VpnSessionPeerCodesType 
    {
        /// <summary>
        /// List of peer codes per transport tunnel.
        /// </summary>
        [JsonProperty(PropertyName = "peer_codes", Required = Required.AllowNull)]
        public IList<NSXTL2VpnTunnelPeerCodeType> PeerCodes { get; set; }
    }
}
