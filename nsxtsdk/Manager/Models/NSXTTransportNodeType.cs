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
    public class NSXTTransportNodeType : NSXTManagedResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_spec")]
        public NSXTHostSwitchSpecType HostSwitchSpec { get; set; }
        /// <summary>
        /// Unique Id of the fabric node
        /// </summary>
        [JsonProperty(PropertyName = "node_id")]
        public string? NodeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "node_deployment_info")]
        public NSXTNodeType NodeDeploymentInfo { get; set; }
        /// <summary>
        /// The property is read-only, used for querying result. User could update transport node maintenance mode by
        /// UpdateTransportNodeMaintenanceMode call.
        /// </summary>
        [JsonProperty(PropertyName = "maintenance_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTransportNodeMaintenanceModeEnumType? MaintenanceMode { get; set; }
        /// <summary>
        /// Set failure domain of edge transport node which will help in
        /// auto placement of TIER1 logical routers, DHCP Servers and
        /// MDProxies, if failure domain based allocation is enabled in
        /// edge cluster API. It is only supported for edge transport node
        /// and not for host transport node. In case failure domain is not
        /// set by user explicitly, it will be always assigned with default
        /// system created failure domain.
        /// </summary>
        [JsonProperty(PropertyName = "failure_domain_id")]
        public string? FailureDomainId { get; set; }
        /// <summary>
        /// This flag is relevant to only those hosts which are part of a
        /// compute collection which has transport node profile (TNP)
        /// applied on it. If you change the transport node configuration
        /// and it is different than cluster level TNP then this flag will
        /// be set to true
        /// </summary>
        [JsonProperty(PropertyName = "is_overridden")]
        public bool? IsOverridden { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "remote_tunnel_endpoint")]
        public NSXTTransportNodeRemoteTunnelEndpointConfigType RemoteTunnelEndpoint { get; set; }
    }
}
