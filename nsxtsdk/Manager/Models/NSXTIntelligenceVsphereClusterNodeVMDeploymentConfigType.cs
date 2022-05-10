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
    public class NSXTIntelligenceVsphereClusterNodeVMDeploymentConfigType : NSXTIntelligenceClusterNodeVMDeploymentConfigType
    {
        /// <summary>
        /// The NSX-Intelligence cluster node VM OVF URL to download and install the OVF file.
        /// This field is deprecated now. Please upload OVA file using "/repository/bundles" API
        /// and then try deployment without providing this field.
        /// </summary>
        [JsonProperty(PropertyName = "ovf_url")]
        public string? OvfUrl { get; set; }
        /// <summary>
        /// List of DNS servers.
        /// If DHCP is used, the default DNS servers associated with
        /// the DHCP server will be used instead.
        /// Required if using static IP.
        /// </summary>
        [JsonProperty(PropertyName = "dns_servers")]
        public IList<string> DnsServers { get; set; }
        /// <summary>
        /// Desired display name for NSX-Intelligence VM to be deployed
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// List of NTP servers.
        /// To use hostnames, a DNS server must be defined. If not using DHCP,
        /// a DNS server should be specified under dns_servers.
        /// </summary>
        [JsonProperty(PropertyName = "ntp_servers")]
        public IList<string> NtpServers { get; set; }
        /// <summary>
        /// Distributed portgroup identifier to which the management vnic of
        /// NSX-Intelligence cluster node VM will be connected.
        /// </summary>
        [JsonProperty(PropertyName = "management_network_id", Required = Required.AllowNull)]
        public string ManagementNetworkId { get; set; }
        /// <summary>
        /// If true, the SSH service will automatically be started on the VM.
        /// Enabling SSH service is not recommended for security reasons.
        /// </summary>
        [JsonProperty(PropertyName = "enable_ssh")]
        public bool? EnableSsh { get; set; }
        /// <summary>
        /// If true, the root user will be allowed to log into the VM.
        /// Allowing root SSH logins is not recommended for security reasons.
        /// </summary>
        [JsonProperty(PropertyName = "allow_ssh_root_login")]
        public bool? AllowSshRootLogin { get; set; }
        /// <summary>
        /// The NSX-Intelligence cluster node VM will be deployed on the specified cluster or
        /// resourcepool for specified VC server.
        /// </summary>
        [JsonProperty(PropertyName = "compute_id", Required = Required.AllowNull)]
        public string ComputeId { get; set; }
        /// <summary>
        /// Specifies the disk provisioning type of the VM.
        /// </summary>
        [JsonProperty(PropertyName = "disk_provisioning")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTIntelligenceVsphereClusterNodeVmdeploymentConfigDiskProvisioningEnumType? DiskProvisioning { get; set; }
        /// <summary>
        /// The VC-specific identifiers will be resolved on this VC, so all other
        /// identifiers specified in the config must belong to this vCenter server.
        /// </summary>
        [JsonProperty(PropertyName = "vc_id", Required = Required.AllowNull)]
        public string VcId { get; set; }
        /// <summary>
        /// The NSX-Intelligence cluster node VM will be deployed on the specified datastore in
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
        /// IMPORTANT: VMs deployed using DHCP are currently not supported,
        /// so this parameter should be specified.
        /// </summary>
        [JsonProperty(PropertyName = "default_gateway_addresses")]
        public IList<string> DefaultGatewayAddresses { get; set; }
        /// <summary>
        /// IP Address and subnet configuration for the management port.
        /// Do not specify this field and default_gateway_addresses to use DHCP.
        /// Note: only one IPv4 address is supported for the management port.
        /// IMPORTANT: VMs deployed using DHCP are currently not supported,
        /// so this parameter should be specified.
        /// </summary>
        [JsonProperty(PropertyName = "management_port_subnets")]
        public IList<NSXTIPSubnetType> ManagementPortSubnets { get; set; }
        /// <summary>
        /// The NSX-Intelligence cluster node VM will be deployed on the specified host in the
        /// specified VC server within the cluster if host_id is specified.
        /// Note: User must ensure that storage and specified networks are
        /// accessible by this host.
        /// </summary>
        [JsonProperty(PropertyName = "host_id")]
        public string? HostId { get; set; }
        /// <summary>
        /// Desired host name/FQDN for the VM to be deployed
        /// </summary>
        [JsonProperty(PropertyName = "hostname", Required = Required.AllowNull)]
        public string Hostname { get; set; }
    }
}
