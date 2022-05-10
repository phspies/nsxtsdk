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
    public class NSXTTransportNodeStateType : NSXTConfigurationStateType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "deployment_progress_state")]
        public NSXTTransportNodeDeploymentProgressStateType DeploymentProgressState { get; set; }
        /// <summary>
        /// Unique Id of the TransportNode
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id")]
        public string? TransportNodeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "remote_tunnel_endpoint_state")]
        public NSXTRemoteTunnelEndpointConfigStateType RemoteTunnelEndpointState { get; set; }
        /// <summary>
        /// States of HostSwitches on the host
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_states")]
        public IList<NSXTHostSwitchStateType> HostSwitchStates { get; set; }
        /// <summary>
        /// the present realized maintenance mode state
        /// </summary>
        [JsonProperty(PropertyName = "maintenance_mode_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTTransportNodeStateMaintenanceModeStateEnumType? MaintenanceModeState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "node_deployment_state")]
        public NSXTConfigurationStateType NodeDeploymentState { get; set; }
    }
}
