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
    public class NSXTEdgeClusterType : NSXTManagedResourceType
    {
        /// <summary>
        /// Edge cluster is homogenous collection of transport nodes.
        /// Hence all transport nodes of the cluster must be of same type.
        /// This readonly field shows the type of transport nodes.
        /// </summary>
        [JsonProperty(PropertyName = "member_node_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTEdgeClusterMemberNodeTypeEnumType? MemberNodeType { get; set; }
        /// <summary>
        /// EdgeCluster only supports homogeneous members.
        /// These member should be backed by either EdgeNode or PublicCloudGatewayNode.
        /// TransportNode type of these nodes should be the same.
        /// DeploymentType (VIRTUAL_MACHINE|PHYSICAL_MACHINE) of these EdgeNodes is
        /// recommended to be the same. EdgeCluster supports members of different
        /// deployment types.
        /// </summary>
        [JsonProperty(PropertyName = "members")]
        public IList<NSXTEdgeClusterMemberType> Members { get; set; }
        /// <summary>
        /// List of remote tunnel endpoint ipaddress configured on edge cluster for each transport node.
        /// </summary>
        [JsonProperty(PropertyName = "node_rtep_ips")]
        public IList<NSXTNodeRtepIpsConfigType> NodeRtepIps { get; set; }
        /// <summary>
        /// Edge cluster profile bindings
        /// </summary>
        [JsonProperty(PropertyName = "cluster_profile_bindings")]
        public IList<NSXTClusterProfileTypeIdEntryType> ClusterProfileBindings { get; set; }
        /// <summary>
        /// Flag should be only use in federation for inter site l2 and l3 forwarding.
        /// Before enabling this flag, all the edge cluster members must have remote
        /// tunnel endpoint configured. TIER0/TIER1 logical routers managed by GM
        /// must be associated with edge cluster which has inter-site forwarding
        /// enabled.
        /// </summary>
        [JsonProperty(PropertyName = "enable_inter_site_forwarding")]
        public bool? EnableInterSiteForwarding { get; set; }
        /// <summary>
        /// Set of allocation rules and respected action for auto placement of
        /// logical router, DHCP and MDProxy on edge cluster members.
        /// </summary>
        [JsonProperty(PropertyName = "allocation_rules")]
        public IList<NSXTAllocationRuleType> AllocationRules { get; set; }
        /// <summary>
        /// This field is a readonly field which shows the deployment_type of members.
        /// It returns UNKNOWN if there are no members, and returns VIRTUAL_MACHINE|
        /// PHYSICAL_MACHINE if all edge members are VIRTUAL_MACHINE|PHYSICAL_MACHINE.
        /// It returns HYBRID if the cluster contains edge members of both types
        /// VIRTUAL_MACHINE and PHYSICAL_MACHINE.
        /// </summary>
        [JsonProperty(PropertyName = "deployment_type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTEdgeClusterDeploymentTypeEnumType? DeploymentType { get; set; }
    }
}
