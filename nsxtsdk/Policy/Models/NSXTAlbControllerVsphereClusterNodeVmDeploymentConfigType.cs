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
    public class NSXTAlbControllerVsphereClusterNodeVmDeploymentConfigType : NSXTALBControllerNodeVMDeploymentConfigType
    {
        /// <summary>
        /// List of DNS servers.
        /// </summary>
        [JsonProperty(PropertyName = "dns_servers")]
        public IList<string> DnsServers { get; set; }
        /// <summary>
        /// Desired display name for Advanced Load Balancer controller VM to be deployed.
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// The cluster node VM will be deployed with the specified storage policy
        /// on the specified datastore in the specified VC server. User must ensure
        /// that the storage policy is applicable on the given datastore.
        /// </summary>
        [JsonProperty(PropertyName = "storage_policy_id")]
        public string? StoragePolicyId { get; set; }
        /// <summary>
        /// List of NTP servers.
        /// </summary>
        [JsonProperty(PropertyName = "ntp_servers")]
        public IList<string> NtpServers { get; set; }
        /// <summary>
        /// Distributed portgroup identifier to which the management vnic of
        /// Advanced Load Balancer controller node VM will be connected.
        /// </summary>
        [JsonProperty(PropertyName = "management_network_id", Required = Required.AllowNull)]
        public string ManagementNetworkId { get; set; }
        /// <summary>
        /// The Advanced Load Balancer controller node VM will be deployed on the specified cluster or
        /// resourcepool for specified VC server.
        /// </summary>
        [JsonProperty(PropertyName = "compute_id", Required = Required.AllowNull)]
        public string ComputeId { get; set; }
        /// <summary>
        /// Specifies the disk provisioning type of the VM.
        /// </summary>
        [JsonProperty(PropertyName = "disk_provisioning")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbControllerVsphereClusterNodeVmDeploymentConfigDiskProvisioningEnumType? DiskProvisioning { get; set; }
        /// <summary>
        /// The VC-specific identifiers will be resolved on this VC, so all other
        /// identifiers specified in the config must belong to this vCenter server.
        /// </summary>
        [JsonProperty(PropertyName = "vc_id", Required = Required.AllowNull)]
        public string VcId { get; set; }
        /// <summary>
        /// The Advanced Load Balancer controller node VM will be deployed on the specified datastore in
        /// the specified VC server. User must ensure that storage is accessible
        /// by the specified cluster/host.
        /// </summary>
        [JsonProperty(PropertyName = "storage_id", Required = Required.AllowNull)]
        public string StorageId { get; set; }
        /// <summary>
        /// The default gateway for the VM to be deployed must be specified if all
        /// the other VMs it communicates with are not in the same subnet.
        /// Do not specify this field and management_port_subnets to use DHCP.
        /// Note: only single IPv4 default gateway address is supported and it
        /// must belong to management network.
        /// </summary>
        [JsonProperty(PropertyName = "default_gateway_addresses")]
        public IList<string> DefaultGatewayAddresses { get; set; }
        /// <summary>
        /// IP Address and subnet configuration for the management port.
        /// Do not specify this field and default_gateway_addresses to use DHCP.
        /// Note: only one IPv4 address is supported for the management port.
        /// </summary>
        [JsonProperty(PropertyName = "management_port_subnets")]
        public IList<NSXTIPSubnetType> ManagementPortSubnets { get; set; }
        /// <summary>
        /// The Advanced Load Balancer controller node VM will be deployed on the specified host in the
        /// specified VC server within the cluster if host_id is specified.
        /// Note: User must ensure that storage and specified networks are
        /// accessible by this host.
        /// </summary>
        [JsonProperty(PropertyName = "host_id")]
        public string? HostId { get; set; }
        /// <summary>
        /// Desired host name/FQDN for the VM to be deployed.
        /// </summary>
        [JsonProperty(PropertyName = "hostname", Required = Required.AllowNull)]
        public string Hostname { get; set; }
    }
}
