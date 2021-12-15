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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTIPSecVPNTransportStatusType : NSXTL2VPNTransportTunnelStatusType
    {
        /// <summary>
        /// VPN session status provides IKE session status and aggregate of traffic across all tunnel.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [NSXTProperty(IsRequired: false, Description: @"VPN session status provides IKE session status and aggregate of traffic across all tunnel.")]
        public NSXTIPSecVPNSessionStatusType Status { get; set; }
    }
}