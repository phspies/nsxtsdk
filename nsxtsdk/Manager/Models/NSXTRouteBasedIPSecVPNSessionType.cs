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
    public class NSXTRouteBasedIPSecVPNSessionType : NSXTIPSecVPNSessionType
    {
        /// <summary>
        /// IP Tunnel ports.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_ports", Required = Required.AllowNull)]
        public IList<NSXTTunnelPortConfigType> TunnelPorts { get; set; }
    }
}
