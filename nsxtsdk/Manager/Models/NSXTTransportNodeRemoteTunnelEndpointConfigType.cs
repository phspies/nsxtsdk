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
        [NSXTProperty(IsRequired: false, Description: @"Specifying this field will override the default teaming policy of the host switch and will be used by remote tunnel endpoint traffic.")]
        public string? NamedTeamingPolicy { get; set; }
        /// <summary>
        /// The host switch name should reference an existing host switch specified in the transport node configuration. The name
        /// will be used to identify the host switch responsible for processing remote tunnel endpoint traffic.
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_name", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The host switch name should reference an existing host switch specified in the transport node configuration. The name will be used to identify the host switch responsible for processing remote tunnel endpoint traffic.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string HostSwitchName { get; set; }
        /// <summary>
        /// The transport VLAN id used for tagging intersite overlay traffic between remote tunnel endpoints.
        /// </summary>
        [JsonProperty(PropertyName = "rtep_vlan", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The transport VLAN id used for tagging intersite overlay traffic between remote tunnel endpoints.")]
        [System.ComponentModel.DataAnnotations.Required]
        public long RtepVlan { get; set; }
        /// <summary>
        /// IPs can come from either a static IP pool or an explicitly specified IP list. Therefore, specifying any other IP
        /// assignment type will result in error. In case a list of IPs is specified, the number of IPs provided should be
        /// sufficient as per the teaming policy associated with the host switch uplink profile used by the remote tunnel endpoint.
        /// </summary>
        [JsonProperty(PropertyName = "ip_assignment_spec", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"IPs can come from either a static IP pool or an explicitly specified IP list. Therefore, specifying any other IP assignment type will result in error. In case a list of IPs is specified, the number of IPs provided should be sufficient as per the teaming policy associated with the host switch uplink profile used by the remote tunnel endpoint.")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTIpAssignmentSpecType IpAssignmentSpec { get; set; }
    }
}
