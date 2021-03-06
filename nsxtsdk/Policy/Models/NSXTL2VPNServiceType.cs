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
    public class NSXTL2VPNServiceType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// IP Pool to allocate local and peer endpoint IPs for
        /// L2VpnSession logical tap.
        /// </summary>
        [JsonProperty(PropertyName = "encap_ip_pool")]
        public IList<string> EncapIpPool { get; set; }
        /// <summary>
        /// Specify an L2VPN service mode as SERVER or CLIENT.
        /// </summary>
        [JsonProperty(PropertyName = "mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL2VpnserviceModeEnumType? Mode { get; set; }
        /// <summary>
        /// This property applies only in SERVER mode. If set to true,
        /// traffic from any client will be replicated to all other clients.
        /// If set to false, traffic received from clients is only replicated
        /// to the local VPN endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "enable_hub")]
        public bool? EnableHub { get; set; }
    }
}
