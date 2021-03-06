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
    /// Remote tunnel endpoint configuration
    /// </summary>
    [NSXTProperty(Description: @"Remote tunnel endpoint configuration")]
    public class NSXTTransportNodeRemoteTunnelEndpointConfigType 
    {
        /// <summary>
        /// Specifying this field will override the default teaming policy of the host switch and will be used by remote tunnel
        /// endpoint traffic.
        /// </summary>
        [JsonProperty(PropertyName = "named_teaming_policy")]
        public string? NamedTeamingPolicy { get; set; }
        /// <summary>
        /// The host switch name should reference an existing host switch specified in the transport node configuration. The name
        /// will be used to identify the host switch responsible for processing remote tunnel endpoint traffic.
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_name", Required = Required.AllowNull)]
        public string HostSwitchName { get; set; }
        /// <summary>
        /// The transport VLAN id used for tagging intersite overlay traffic between remote tunnel endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "rtep_vlan", Required = Required.AllowNull)]
        public long RtepVlan { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "ip_assignment_spec", Required = Required.AllowNull)]
        public NSXTIpAssignmentSpecType IpAssignmentSpec { get; set; }
    }
}
