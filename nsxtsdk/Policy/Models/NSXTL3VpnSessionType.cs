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
    /// Contains information about L3Vpn session.
    /// </summary>
    [NSXTProperty(Description: @"Contains information about L3Vpn session.")]
    public class NSXTL3VpnSessionType 
    {
        /// <summary>
        /// - A Policy Based L3Vpn is a configuration in which protect rules to match local
        /// and remote subnet needs to be defined. Tunnel is established for each pair of
        /// local and remote subnet defined in protect rules.
        /// - A Route Based L3Vpn is more flexible, more powerful and recommended over policy
        /// based. IP Tunnel subnet is created and all traffic routed through tunnel subnet
        /// (commonly known as VTI) is sent over tunnel. Routes can be learned through BGP.
        /// A route based L3Vpn is required when using redundant L3Vpn.
        /// </summary>
        [JsonProperty(PropertyName = "resource_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTL3VpnSessionResourceTypeEnumType ResourceType { get; set; }
    }
}
