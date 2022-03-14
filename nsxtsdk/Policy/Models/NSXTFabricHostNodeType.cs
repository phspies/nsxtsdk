// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTFabricHostNodeType 
    {
        /// <summary>
        /// Id of discovered node which was converted to create this node.
        /// </summary>
        public string? DiscoveredNodeId { get; set; }
        /// <summary>
        /// Specify an installation folder to install the NSX kernel modules for Windows Server. By default, it is C:\Program
        /// Files\VMware\NSX\.
        /// </summary>
        public string? WindowsInstallLocation { get; set; }
        /// <summary>
        /// IP Addresses of the Node, version 4 or 6.
        /// </summary>
        [JsonProperty(PropertyName = "ip_addresses", Required = Required.AllowNull)]
        public IList<string> IpAddresses { get; set; }
        /// <summary>
        /// Id of the compute collection to which discovered node belongs.
        /// </summary>
        public string? ComputeCollectionId { get; set; }
        /// <summary>
        /// Indicates host node's maintenance mode state. The state is ENTERING
        /// when a task to put the host in maintenance-mode is in progress.
        /// </summary>
        public NSXTFabricHostNodeMaintenanceModeStateEnumType? MaintenanceModeState { get; set; }
        /// <summary>
        /// Fully qualified domain name of the transport node
        /// </summary>
        public string? Fqdn { get; set; }
        /// <summary>
        /// Version of the hypervisor operating system
        /// </summary>
        public string? OsVersion { get; set; }
        /// <summary>
        /// The id of the vCenter server managing the ESXi type HostNode
        /// </summary>
        public string? ManagedByServer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTHostNodeLoginCredentialType HostCredential { get; set; }
        /// <summary>
        /// Hypervisor type, for example ESXi or RHEL KVM
        /// </summary>
        [JsonProperty(PropertyName = "os_type", Required = Required.AllowNull)]
        public NSXTFabricHostNodeOsTypeEnumType OsType { get; set; }
        /// <summary>
        /// Discovered IP Addresses of the transport node, version 4 or 6
        /// </summary>
        public IList<string> DiscoveredIpAddresses { get; set; }
    }
}
