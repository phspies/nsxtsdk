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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTL2VPNServiceType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// IP Pool to allocate local and peer endpoint IPs for
        /// L2VpnSession logical tap.
        /// </summary>
        [JsonProperty(PropertyName = "encap_ip_pool")]
        [NSXTProperty(IsRequired: false, Description: @"IP Pool to allocate local and peer endpoint IPs forL2VpnSession logical tap.")]
        public IList<string> EncapIpPool { get; set; }
        /// <summary>
        /// Specify an L2VPN service mode as SERVER or CLIENT.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [NSXTProperty(IsRequired: false, Description: @"Specify an L2VPN service mode as SERVER or CLIENT.")]
        [NSXTDefaultProperty(Default: "SERVER")]
        public NSXTL2VpnserviceModeEnumType? Mode { get; set; }
        /// <summary>
        /// This property applies only in SERVER mode. If set to true,
        /// traffic from any client will be replicated to all other clients.
        /// If set to false, traffic received from clients is only replicated
        /// to the local VPN endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "enable_hub")]
        [NSXTProperty(IsRequired: false, Description: @"This property applies only in SERVER mode. If set to true,traffic from any client will be replicated to all other clients.If set to false, traffic received from clients is only replicatedto the local VPN endpoint.")]
        public bool? EnableHub { get; set; }
    }
}