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
    public class NSXTIPSecVpnTransportStatusType : NSXTL2VPNSessionTransportTunnelStatusType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "session_status")]
        public NSXTIPSecVpnSessionStatusNsxTType SessionStatus { get; set; }
    }
}
