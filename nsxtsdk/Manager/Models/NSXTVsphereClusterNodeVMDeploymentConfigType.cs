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
    public class NSXTVsphereClusterNodeVMDeploymentConfigType : NSXTClusterNodeVMDeploymentConfigType
    {
        public NSXTVsphereClusterNodeVMDeploymentConfigType()
        {
            DiskProvisioning = test
        }
        /// <summary>
        /// List of DNS servers.
        /// If DHCP is used, the default DNS servers associated with
        /// the DHCP server will be used instead.
        /// Required if using static IP.
        /// </summary>
        [JsonProperty(PropertyName = "dns_servers")]
        [NSXTProperty(IsRequired: false, Description: @"List of DNS servers.If DHCP is used, the default DNS servers associated withthe DHCP server will be used instead.Required if using static IP.")]
        public IList<string> DnsServers { get; set; }
        /// <summary>
        /// List of domain names that are used to complete unqualified host names.
        /// </summary>
        [JsonProperty(PropertyName = "search_domains")]
        [NSXTProperty(IsRequired: false, Description: @"List of domain names that are used to complete unqualified host names.")]
        public IList<string> SearchDomains { get; set; }
        /// <summary>
        /// Distributed portgroup identifier to which the management vnic of
        /// cluster node VM will be connected.
        /// </summary>
        [JsonProperty(PropertyName = "management_network_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Distributed portgroup identifier to which the management vnic ofcluster node VM will be connected.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ManagementNetworkId { get; set; }
        /// <summary>
        /// If true, the SSH service will automatically be started on the VM.
        /// Enabling SSH service is not recommended for security reasons.
        /// </summary>
        [JsonProperty(PropertyName = "enable_ssh")]
        [NSXTProperty(IsRequired: false, Description: @"If true, the SSH service will automatically be started on the VM.Enabling SSH service is not recommended for security reasons.")]
        public bool? EnableSsh { get; set; }
        /// <summary>
        /// If true, the root user will be allowed to log into the VM.
        /// Allowing root SSH logins is not recommended for security reasons.
        /// </summary>
        [JsonProperty(PropertyName = "allow_ssh_root_login")]
        [NSXTProperty(IsRequired: false, Description: @"If true, the root user will be allowed to log into the VM.Allowing root SSH logins is not recommended for security reasons.")]
        public bool? AllowSshRootLogin { get; set; }
        /// <summary>
        /// The cluster node VM will be deployed on the specified cluster or
        /// resourcepool for specified VC server.
        /// </summary>
        [JsonProperty(PropertyName = "compute_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The cluster node VM will be deployed on the specified cluster orresourcepool for specified VC server.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ComputeId { get; set; }
        /// <summary>
        /// List of NTP servers.
        /// To use hostnames, a DNS server must be defined. If not using DHCP,
        /// a DNS server should be specified under dns_servers.
        /// </summary>
        [JsonProperty(PropertyName = "ntp_servers")]
        [NSXTProperty(IsRequired: false, Description: @"List of NTP servers.To use hostnames, a DNS server must be defined. If not using DHCP,a DNS server should be specified under dns_servers.")]
        public IList<string> NtpServers { get; set; }
        /// <summary>
        /// Specifies the disk provisioning type of the VM.
        /// </summary>
        [JsonProperty(PropertyName = "disk_provisioning")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies the disk provisioning type of the VM.")]
        public NSXTVsphereClusterNodeVmdeploymentConfigDiskProvisioningEnumType? DiskProvisioning { get; set; }
        /// <summary>
        /// Specifies the folder in which the VM should be placed.
        /// </summary>
        [JsonProperty(PropertyName = "folder_id")]
        [NSXTProperty(IsRequired: false, Description: @"Specifies the folder in which the VM should be placed.")]
        public string? FolderId { get; set; }
        /// <summary>
        /// The VC-specific identifiers will be resolved on this VC, so all other
        /// identifiers specified in the config must belong to this vCenter server.
        /// </summary>
        [JsonProperty(PropertyName = "vc_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The VC-specific identifiers will be resolved on this VC, so all otheridentifiers specified in the config must belong to this vCenter server.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string VcId { get; set; }
        /// <summary>
        /// The cluster node VM will be deployed on the specified datastore in
        /// the specified VC server. User must ensure that storage is accessible
        /// by the specified cluster/host.
        /// </summary>
        [JsonProperty(PropertyName = "storage_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"The cluster node VM will be deployed on the specified datastore inthe specified VC server. User must ensure that storage is accessibleby the specified cluster/host.")]
        [System.ComponentModel.DataAnnotations.Required]
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
        [NSXTProperty(IsRequired: false, Description: @"The default gateway for the VM to be deployed must be specified if allthe other VMs it communicates with are not in the same subnet.Do not specify this field and management_port_subnets to use DHCP.Note: only single IPv4 default gateway address is supported and itmust belong to management network.IMPORTANT: VMs deployed using DHCP are currently not supported,so this parameter should be specified.")]
        public IList<string> DefaultGatewayAddresses { get; set; }
        /// <summary>
        /// IP Address and subnet configuration for the management port.
        /// Do not specify this field and default_gateway_addresses to use DHCP.
        /// Note: only one IPv4 address is supported for the management port.
        /// IMPORTANT: VMs deployed using DHCP are currently not supported,
        /// so this parameter should be specified.
        /// </summary>
        [JsonProperty(PropertyName = "management_port_subnets")]
        [NSXTProperty(IsRequired: false, Description: @"IP Address and subnet configuration for the management port.Do not specify this field and default_gateway_addresses to use DHCP.Note: only one IPv4 address is supported for the management port.IMPORTANT: VMs deployed using DHCP are currently not supported,so this parameter should be specified.")]
        public IList<NSXTIPSubnetType> ManagementPortSubnets { get; set; }
        /// <summary>
        /// The cluster node VM will be deployed on the specified host in the
        /// specified VC server within the cluster if host_id is specified.
        /// Note: User must ensure that storage and specified networks are
        /// accessible by this host.
        /// </summary>
        [JsonProperty(PropertyName = "host_id")]
        [NSXTProperty(IsRequired: false, Description: @"The cluster node VM will be deployed on the specified host in thespecified VC server within the cluster if host_id is specified.Note: User must ensure that storage and specified networks areaccessible by this host.")]
        public string? HostId { get; set; }
        /// <summary>
        /// Desired host name/FQDN for the VM to be deployed
        /// </summary>
        [JsonProperty(PropertyName = "hostname", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Desired host name/FQDN for the VM to be deployed")]
        [System.ComponentModel.DataAnnotations.Required]
        public string Hostname { get; set; }
    }
}
