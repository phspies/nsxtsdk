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
    public class NSXTHostNodeType : NSXTNodeType
    {
        /// <summary>
        /// Id of discovered node which was converted to create this node
        /// </summary>
        [JsonProperty(PropertyName = "discovered_node_id")]
        public string? DiscoveredNodeId { get; set; }
        /// <summary>
        /// Specify an installation folder to install the NSX kernel modules for Windows Server. By default, it is C:\Program
        /// Files\VMware\NSX\.
        /// </summary>
        [JsonProperty(PropertyName = "windows_install_location")]
        public string? WindowsInstallLocation { get; set; }
        /// <summary>
        /// The id of the vCenter server managing the ESXi type HostNode
        /// </summary>
        [JsonProperty(PropertyName = "managed_by_server")]
        public string? ManagedByServer { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "host_credential")]
        public NSXTHostNodeLoginCredentialType HostCredential { get; set; }
        /// <summary>
        /// Version of the hypervisor operating system
        /// </summary>
        [JsonProperty(PropertyName = "os_version")]
        public string? OsVersion { get; set; }
        /// <summary>
        /// Hypervisor type, for example ESXi or RHEL KVM
        /// </summary>
        [JsonProperty(PropertyName = "os_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTHostNodeOsTypeEnumType OsType { get; set; }
        /// <summary>
        /// Id of the compute collection to which discovered node belongs.
        /// </summary>
        [JsonProperty(PropertyName = "compute_collection_id")]
        public string? ComputeCollectionId { get; set; }
        /// <summary>
        /// Indicates host node's maintenance mode state. The state is ENTERING
        /// when a task to put the host in maintenance-mode is in progress.
        /// </summary>
        [JsonProperty(PropertyName = "maintenance_mode_state")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTHostNodeMaintenanceModeStateEnumType? MaintenanceModeState { get; set; }
    }
}
