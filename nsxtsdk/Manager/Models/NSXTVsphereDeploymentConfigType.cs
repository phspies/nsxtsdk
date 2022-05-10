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
    public class NSXTVsphereDeploymentConfigType : NSXTDeploymentConfigType
    {
        /// <summary>
        /// List of distributed portgroups, VLAN logical switch identifiers or segment
        /// paths to which the datapath serving vnics of edge node vm will be connected.
        /// If a VM network interface is not configured, it is disconnected and
        /// represented as an empty string. Edge node supports three datapath vnics
        /// only; other values are for internal use.
        /// </summary>
        [JsonProperty(PropertyName = "data_network_ids", Required = Required.AllowNull)]
        public IList<string> DataNetworkIds { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "resource_allocation")]
        public NSXTResourceAssignmentType ResourceAllocation { get; set; }
        /// <summary>
        /// The edge node vm will be deployed on the specified compute folder created in a datacenter,
        /// if compute folder is specified.
        /// Note - User must ensure that compute folder is accessible by specified cluster/host.
        /// </summary>
        [JsonProperty(PropertyName = "compute_folder_id")]
        public string? ComputeFolderId { get; set; }
        /// <summary>
        /// Distributed portgroup identifier to which the management vnic of edge node vm
        /// will be connected. This portgroup must have connectivity with MP and CCP. A
        /// VLAN logical switch identifier may also be specified.
        /// If VM network interface is not connected, it is represented as an empty string.
        /// </summary>
        [JsonProperty(PropertyName = "management_network_id", Required = Required.AllowNull)]
        public string ManagementNetworkId { get; set; }
        /// <summary>
        /// The edge node vm will be deployed on the specified cluster or resourcepool.
        /// Note - all the hosts must have nsx fabric prepared in the specified cluster.
        /// </summary>
        [JsonProperty(PropertyName = "compute_id", Required = Required.AllowNull)]
        public string ComputeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "reservation_info")]
        public NSXTReservationInfoType ReservationInfo { get; set; }
        /// <summary>
        /// The vc specific identifiers will be resolved on this VC.
        /// So all other identifiers specified here must belong to this vcenter server.
        /// </summary>
        [JsonProperty(PropertyName = "vc_id", Required = Required.AllowNull)]
        public string VcId { get; set; }
        /// <summary>
        /// The edge node vm will be deployed on the specified datastore. User must ensure
        /// that storage is accessible by the specified cluster/host.
        /// </summary>
        [JsonProperty(PropertyName = "storage_id", Required = Required.AllowNull)]
        public string StorageId { get; set; }
        /// <summary>
        /// The default gateway for edge node must be specified if all the nodes it
        /// communicates with are not in the same subnet.
        /// Note: Only single IPv4 default gateway address is supported and it must
        /// belong to management network.
        /// </summary>
        [JsonProperty(PropertyName = "default_gateway_addresses")]
        public IList<string> DefaultGatewayAddresses { get; set; }
        /// <summary>
        /// IP Address and subnet configuration for the management port. Note:
        /// only one IPv4 address is supported for the management port.
        /// </summary>
        [JsonProperty(PropertyName = "management_port_subnets")]
        public IList<NSXTIPSubnetType> ManagementPortSubnets { get; set; }
        /// <summary>
        /// The edge node vm will be deployed on the specified Host within the cluster
        /// if host_id is specified.
        /// Note - User must ensure that storage and specified networks are accessible by this host.
        /// </summary>
        [JsonProperty(PropertyName = "host_id")]
        public string? HostId { get; set; }
        /// <summary>
        /// This field is deprecated. EdgeNodeSettings field 'advanced_configuration'
        /// must be used instead. Array of additional specific properties for
        /// advanced or cloud-specific deployments in key-value format.
        /// </summary>
        [JsonProperty(PropertyName = "advanced_configuration")]
        public IList<NSXTKeyValuePairType> AdvancedConfiguration { get; set; }
    }
}
