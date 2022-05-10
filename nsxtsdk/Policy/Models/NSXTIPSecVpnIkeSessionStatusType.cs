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
    /// Status for IPSec VPN Ike session UP, DOWN, NEGOTIATING and fail reason if Ike session
        /// is down.
    /// </summary>
    [NSXTProperty(Description: @"Status for IPSec VPN Ike session UP, DOWN, NEGOTIATING and fail reason if Ike sessionis down.")]
    public class NSXTIPSecVpnIkeSessionStatusType 
    {
        /// <summary>
        /// Reason for failure.
        /// </summary>
        [JsonProperty(PropertyName = "fail_reason")]
        public string? FailReason { get; set; }
        /// <summary>
        /// Ike session service status UP, DOWN and NEGOTIATING.
        /// </summary>
        [JsonProperty(PropertyName = "ike_session_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIpsecVpnIkeSessionStatusIkeSessionStateEnumType? IkeSessionState { get; set; }
    }
}
