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
    /// Local Egress is used on both server and client sites so that the gateway
        /// is used for N-S traffic and overhead on L2VPN tunnel is reduced.
    /// </summary>
    [NSXTProperty(Description: @"Local Egress is used on both server and client sites so that the gatewayis used for N-S traffic and overhead on L2VPN tunnel is reduced.")]
    public class NSXTLocalEgressType 
    {
        /// <summary>
        /// Gateway IP for Local Egress. Local egress is enabled only when this
        /// list is not empty.
        /// </summary>
        [JsonProperty(PropertyName = "optimized_ips")]
        public IList<string> OptimizedIps { get; set; }
    }
}
