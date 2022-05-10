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
    public class NSXTLogicalSwitchType : NSXTManagedResourceType
    {
        /// <summary>
        /// This field indicates purpose of a LogicalSwitch. It is set by manager internally
        /// or user can provide this field. If not set, DEFAULT type is assigned.
        /// NSX components can use this field to create LogicalSwitch that provides component
        /// specific functionality.
        /// DEFAULT type LogicalSwitches are created for basic L2 connectivity by API users.
        /// SERVICE_PLANE type LogicalSwitches are system created service plane LogicalSwitches for
        /// Service Insertion service. User can not create SERVICE_PLANE type of LogicalSwitch.
        /// DHCP_RELAY type LogicalSwitches are created by external user like Policy with special
        /// permissions or by system and will be treated as internal LogicalSwitches. Such
        /// LogicalSwitch will not be exposed to vSphere user.
        /// GLOBAL type LogicalSwitches are created to span multiple NSX domains to connect multiple
        /// remote sites.
        /// INTER_ROUTER type LogicalSwitches are policy-created LogicalSwitches which
        /// provide inter-router connectivity.
        /// DVPG type LogicalSwitches are NSX-created based on DVPGs found in VC which are used
        /// as shadow objects in NSX on DVPG.
        /// </summary>
        [JsonProperty(PropertyName = "switch_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLogicalSwitchSwitchTypeEnumType? SwitchType { get; set; }
        /// <summary>
        /// Each manager ID represents the NSX Local Manager the logical switch connects. This will be populated by the manager.
        /// </summary>
        [JsonProperty(PropertyName = "span")]
        public IList<string> Span { get; set; }
        /// <summary>
        /// This property could be used for vendor specific configuration in key value
        /// string pairs, the setting in extra_configs will be automatically inheritted
        /// by logical ports in the logical switch.
        /// </summary>
        [JsonProperty(PropertyName = "extra_configs")]
        public IList<NSXTExtraConfigType> ExtraConfigs { get; set; }
        /// <summary>
        /// This name has to be one of the switching uplink teaming policy names listed inside the logical switch's TransportZone.
        /// If this field is not specified, the logical switch will not have a teaming policy associated with it and the host
        /// switch's default teaming policy will be used.
        /// </summary>
        [JsonProperty(PropertyName = "uplink_teaming_policy_name")]
        public string? UplinkTeamingPolicyName { get; set; }
        /// <summary>
        /// Address bindings for the Logical switch
        /// </summary>
        [JsonProperty(PropertyName = "address_bindings")]
        public IList<NSXTPacketAddressClassifierType> AddressBindings { get; set; }
        /// <summary>
        /// IP pool id that associated with a LogicalSwitch.
        /// </summary>
        [JsonProperty(PropertyName = "ip_pool_id")]
        public string? IpPoolId { get; set; }
        /// <summary>
        /// This property is dedicated to VLAN based network, to set VLAN of logical
        /// network. It is mutually exclusive with 'vlan_trunk_spec'.
        /// </summary>
        [JsonProperty(PropertyName = "vlan")]
        public long? Vlan { get; set; }
        /// <summary>
        /// If this flag is set to true, then all the logical switch ports attached to
        /// this logical switch will behave in a hybrid fashion. The hybrid logical switch port
        /// indicates to NSX that the VM intends to operate in underlay mode,
        /// but retains the ability to forward egress traffic to the NSX overlay network.
        /// This flag can be enabled only for the logical switches in the overlay type transport zone which has
        /// host switch mode as STANDARD and also has either CrossCloud or CloudScope tag scopes.
        /// Only the NSX public cloud gateway (PCG) uses this flag, other host agents like ESX, KVM and Edge
        /// will ignore it. This property cannot be modified once the logical switch is created.
        /// </summary>
        [JsonProperty(PropertyName = "hybrid")]
        public bool? Hybrid { get; set; }
        /// <summary>
        /// Mac pool id that associated with a LogicalSwitch.
        /// </summary>
        [JsonProperty(PropertyName = "mac_pool_id")]
        public string? MacPoolId { get; set; }
        /// <summary>
        /// Only for OVERLAY network. A VNI will be auto-allocated from the
        /// default VNI pool if not given; otherwise the given VNI has to be
        /// inside the default pool and not used by any other LogicalSwitch.
        /// </summary>
        [JsonProperty(PropertyName = "vni")]
        public int? Vni { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "vlan_trunk_spec")]
        public NSXTVlanTrunkSpecType VlanTrunkSpec { get; set; }
        /// <summary>
        /// Represents Desired state of the Logical Switch
        /// </summary>
        [JsonProperty(PropertyName = "admin_state", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLogicalSwitchAdminStateEnumType AdminState { get; set; }
        /// <summary>
        /// A flag to prevent BUM (broadcast, unknown-unicast and multicast) traffic from reaching the other spanned edges.
        /// </summary>
        [JsonProperty(PropertyName = "node_local_switch")]
        public bool? NodeLocalSwitch { get; set; }
        /// <summary>
        /// Id of the TransportZone to which this LogicalSwitch is associated
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_id", Required = Required.AllowNull)]
        public string TransportZoneId { get; set; }
        /// <summary>
        /// Replication mode of the Logical Switch
        /// </summary>
        [JsonProperty(PropertyName = "replication_mode")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLogicalSwitchReplicationModeEnumType? ReplicationMode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "switching_profile_ids")]
        public IList<NSXTSwitchingProfileTypeIdEntryType> SwitchingProfileIds { get; set; }
        /// <summary>
        /// ID populated by NSX when NSX on DVPG is used to indicate the source DVPG.
        /// </summary>
        [JsonProperty(PropertyName = "origin_id")]
        public string? OriginId { get; set; }
        /// <summary>
        /// The type of source from which the DVPG is discovered
        /// </summary>
        [JsonProperty(PropertyName = "origin_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTLogicalSwitchOriginTypeEnumType? OriginType { get; set; }
        /// <summary>
        /// The VNI is used for intersite traffic and the global logical switch ID. The global VNI pool is agnostic of the local VNI
        /// pool, and there is no need to have an exclusive VNI range. For example, VNI x can be the global VNI for logical switch B
        /// and the local VNI for logical switch A.
        /// </summary>
        [JsonProperty(PropertyName = "global_vni")]
        public int? GlobalVni { get; set; }
    }
}
