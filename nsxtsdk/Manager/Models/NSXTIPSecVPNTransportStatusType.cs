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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIPSecVPNTransportStatusType : NSXTL2VPNTransportTunnelStatusType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public NSXTIPSecVPNSessionStatusType Status { get; set; }
    }
}
