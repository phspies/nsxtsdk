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
    public class NSXTIPSecVpnTunnelInterfaceType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// IP Tunnel interface (commonly referred as VTI) subnet.
        /// </summary>
        [JsonProperty(PropertyName = "ip_subnets", Required = Required.AllowNull)]
        public IList<NSXTTunnelInterfaceIPSubnetType> IpSubnets { get; set; }
    }
}
