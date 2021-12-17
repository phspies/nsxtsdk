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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// Status for IPSec VPN IKE session UP, DOWN, NEGOTIATING and fail reason if IKE session is down.
    /// </summary>
    [NSXTProperty(Description: @"Status for IPSec VPN IKE session UP, DOWN, NEGOTIATING and fail reason if IKE session is down.")]
    public class NSXTIPSecVPNIKESessionStatusType 
    {
        public NSXTIPSecVPNIKESessionStatusType()
        {
        }
        /// <summary>
        /// Transport Node identifier where session is present.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id")]
        [NSXTProperty(IsRequired: false, Description: @"Transport Node identifier where session is present.")]
        public string? TransportNodeId { get; set; }
        /// <summary>
        /// Reason for failure.
        /// </summary>
        [JsonProperty(PropertyName = "fail_reason")]
        [NSXTProperty(IsRequired: false, Description: @"Reason for failure.")]
        public string? FailReason { get; set; }
        /// <summary>
        /// IKE session service status UP, DOWN and NEGOTIATING.
        /// </summary>
        [JsonProperty(PropertyName = "ike_session_state")]
        [NSXTProperty(IsRequired: false, Description: @"IKE session service status UP, DOWN and NEGOTIATING.")]
        public NSXTIpsecVpnikesessionStatusIkeSessionStateEnumType? IkeSessionState { get; set; }
    }
}
