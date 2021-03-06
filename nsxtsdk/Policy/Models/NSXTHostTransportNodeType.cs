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
    public class NSXTHostTransportNodeType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "host_switch_spec")]
        public NSXTHostSwitchSpecType HostSwitchSpec { get; set; }
        /// <summary>
        /// The property is read-only, used for querying result. User could update transport node maintenance mode by
        /// UpdateTransportNodeMaintenanceMode call.
        /// </summary>
        [JsonProperty(PropertyName = "maintenance_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTHostTransportNodeMaintenanceModeEnumType? MaintenanceMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "node_deployment_info")]
        public NSXTFabricHostNodeType NodeDeploymentInfo { get; set; }
        /// <summary>
        /// This flag is relevant to only those hosts which are part of a
        /// compute collection which has transport node profile (TNP)
        /// applied on it. If you change the transport node configuration
        /// and it is different than cluster level TNP then this flag will
        /// be set to true.
        /// </summary>
        [JsonProperty(PropertyName = "is_overridden")]
        public bool? IsOverridden { get; set; }
        /// <summary>
        /// Specify discovered node id to create Host Transport Node for Discovered Node.
        /// This field is required during Host Transport Node create from vCenter server managing the ESXi type HostNode.
        /// No need to provide node_deployment_info while creating Host Transport Node for Discovered Node.
        /// If both node_deployment_info and discovered_node_id_for_create provided during Host TransportNode create payload
        /// then it will create Host Transport Node from the discovered node id provided in this field.
        /// </summary>
        [JsonProperty(PropertyName = "discovered_node_id_for_create")]
        public string? DiscoveredNodeIdForCreate { get; set; }
    }
}
