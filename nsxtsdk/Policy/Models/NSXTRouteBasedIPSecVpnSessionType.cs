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
    public class NSXTRouteBasedIPSecVpnSessionType : NSXTIPSecVpnSessionType
    {
        /// <summary>
        /// If true the default firewall rule Action is set to DROP, otherwise set to ALLOW.
        /// This field is deprecated and recommended to change Rule action field. Note that this
        /// field is not synchornied with default rule field.
        /// </summary>
        [JsonProperty(PropertyName = "force_whitelisting")]
        public bool? ForceWhitelisting { get; set; }
        /// <summary>
        /// IP Tunnel interfaces. This property is mandatory on LM. It is required on GM only in case of site_overrides property not
        /// provided.
        /// </summary>
        [JsonProperty(PropertyName = "tunnel_interfaces")]
        public IList<NSXTIPSecVpnTunnelInterfaceType> TunnelInterfaces { get; set; }
    }
}
