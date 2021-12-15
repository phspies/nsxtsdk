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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTTransportNodeType : NSXTManagedResourceType
    {
        /// <summary>
        /// This property is used to either create standard host switches
        /// or to inform NSX about preconfigured host switches that already
        /// exist on the transport node.
        /// 
        /// Pass an array of either StandardHostSwitchSpec objects or
        /// PreconfiguredHostSwitchSpec objects. It is an error to pass
        /// an array containing different types of HostSwitchSpec objects.
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_spec")]
        [NSXTProperty(IsRequired: false, Description: @"This property is used to either create standard host switchesor to inform NSX about preconfigured host switches that alreadyexist on the transport node.Pass an array of either StandardHostSwitchSpec objects orPreconfiguredHostSwitchSpec objects. It is an error to passan array containing different types of HostSwitchSpec objects.")]
        public NSXTHostSwitchSpecType HostSwitchSpec { get; set; }
        /// <summary>
        /// Unique Id of the fabric node
        /// </summary>
        [JsonProperty(PropertyName = "node_id")]
        [NSXTProperty(IsRequired: false, Description: @"Unique Id of the fabric node")]
        public string? NodeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "node_deployment_info")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTNodeType NodeDeploymentInfo { get; set; }
        /// <summary>
        /// The property is read-only, used for querying result. User could update transport node maintenance mode by
        /// UpdateTransportNodeMaintenanceMode call.
        /// </summary>
        [JsonProperty(PropertyName = "maintenance_mode")]
        [NSXTProperty(IsRequired: false, Description: @"The property is read-only, used for querying result. User could update transport node maintenance mode by UpdateTransportNodeMaintenanceMode call.")]
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
        [NSXTProperty(IsRequired: false, Description: @"Set failure domain of edge transport node which will help inauto placement of TIER1 logical routers, DHCP Servers andMDProxies, if failure domain based allocation is enabled inedge cluster API. It is only supported for edge transport nodeand not for host transport node. In case failure domain is notset by user explicitly, it will be always assigned with defaultsystem created failure domain.")]
        public string? FailureDomainId { get; set; }
        /// <summary>
        /// This should be configured only on a single host switch. It is only
        /// supported for edge transport nodes and not for host transport nodes.
        /// This configuration will be used by overlay traffic that is meant to
        /// be sent between NSX intersite domains.
        /// </summary>
        [JsonProperty(PropertyName = "remote_tunnel_endpoint")]
        [NSXTProperty(IsRequired: false, Description: @"This should be configured only on a single host switch. It is onlysupported for edge transport nodes and not for host transport nodes.This configuration will be used by overlay traffic that is meant tobe sent between NSX intersite domains.")]
        public NSXTTransportNodeRemoteTunnelEndpointConfigType RemoteTunnelEndpoint { get; set; }
        /// <summary>
        /// This flag is relevant to only those hosts which are part of a
        /// compute collection which has transport node profile (TNP)
        /// applied on it. If you change the transport node configuration
        /// and it is different than cluster level TNP then this flag will
        /// be set to true
        /// </summary>
        [JsonProperty(PropertyName = "is_overridden")]
        [NSXTProperty(IsRequired: false, Description: @"This flag is relevant to only those hosts which are part of acompute collection which has transport node profile (TNP)applied on it. If you change the transport node configurationand it is different than cluster level TNP then this flag willbe set to true")]
        public bool? IsOverridden { get; set; }
        /// <summary>
        /// This is deprecated. TransportZoneEndPoints should be specified
        /// per host switch at StandardHostSwitch through Transport Node
        /// or Transport Node Profile configuration.
        /// This will ONLY include the TransportZoneEndpoints that were
        /// were specified here during the TransportNode configuration.
        /// If TransportZoneEndpoints are specified directly in
        /// {$ref: StandardHostSwitch}, such TransportZoneEndpoints
        /// will not be populated here.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_endpoints")]
        [NSXTProperty(IsRequired: false, Description: @"This is deprecated. TransportZoneEndPoints should be specifiedper host switch at StandardHostSwitch through Transport Nodeor Transport Node Profile configuration.This will ONLY include the TransportZoneEndpoints that werewere specified here during the TransportNode configuration.If TransportZoneEndpoints are specified directly in{$ref: StandardHostSwitch}, such TransportZoneEndpointswill not be populated here.")]
        public IList<NSXTTransportZoneEndPointType> TransportZoneEndpoints { get; set; }
    }
}
