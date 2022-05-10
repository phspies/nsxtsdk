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
    /// Status for IPSec VPN IKE session UP, DOWN, NEGOTIATING and fail reason if IKE session is down.
    /// </summary>
    [NSXTProperty(Description: @"Status for IPSec VPN IKE session UP, DOWN, NEGOTIATING and fail reason if IKE session is down.")]
    public class NSXTIPSecVPNIKESessionStatusType 
    {
        /// <summary>
        /// Transport Node identifier where session is present.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id")]
        public string? TransportNodeId { get; set; }
        /// <summary>
        /// Reason for failure.
        /// </summary>
        [JsonProperty(PropertyName = "fail_reason")]
        public string? FailReason { get; set; }
        /// <summary>
        /// IKE session service status UP, DOWN and NEGOTIATING.
        /// </summary>
        [JsonProperty(PropertyName = "ike_session_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpnikesessionStatusIkeSessionStateEnumType? IkeSessionState { get; set; }
    }
}
