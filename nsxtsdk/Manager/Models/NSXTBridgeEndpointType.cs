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
    public class NSXTBridgeEndpointType : NSXTManagedResourceType
    {
        /// <summary>
        /// This field will not be used if an edge cluster is being used for the
        /// bridge endpoint
        /// </summary>
        [JsonProperty(PropertyName = "ha_enable")]
        public bool? HaEnable { get; set; }
        /// <summary>
        /// This field will not be used if an edge cluster is being used for the
        /// bridge endpoint
        /// </summary>
        [JsonProperty(PropertyName = "bridge_cluster_id")]
        public string? BridgeClusterId { get; set; }
        /// <summary>
        /// This field will not be used if a bridge cluster is being used for the
        /// bridge endpoint
        /// </summary>
        [JsonProperty(PropertyName = "vlan_transport_zone_id")]
        public string? VlanTransportZoneId { get; set; }
        /// <summary>
        /// This field will not be used if a bridge cluster is being used for the
        /// bridge endpoint
        /// </summary>
        [JsonProperty(PropertyName = "bridge_endpoint_profile_id")]
        public string? BridgeEndpointProfileId { get; set; }
        /// <summary>
        /// This name has to be one of the switching uplink teaming policy names listed inside the TransportZone. If this field is
        /// not specified, bridge will use the first pnic in host-switch config. This field will not be used if a bridge cluster is
        /// being used for the bridge endpoint
        /// </summary>
        [JsonProperty(PropertyName = "uplink_teaming_policy_name")]
        public string? UplinkTeamingPolicyName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "vlan_trunk_spec")]
        public NSXTVlanTrunkSpecType VlanTrunkSpec { get; set; }
        /// <summary>
        /// This property is used for VLAN specification of bridge endpoint.
        /// It's mutually exclusive with 'vlan_trunk_spec', either 'vlan' or 'vlan_trunk_spec'
        /// should be specified.
        /// </summary>
        [JsonProperty(PropertyName = "vlan")]
        public long? Vlan { get; set; }
    }
}
