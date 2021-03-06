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
    /// The Instance Deployment Config contains settings that is applied during install time.
    /// </summary>
    [NSXTProperty(Description: @"The Instance Deployment Config contains settings that is applied during install time.")]
    public class NSXTInstanceDeploymentConfigType 
    {
        /// <summary>
        /// Context Id or VCenter Id.
        /// </summary>
        [JsonProperty(PropertyName = "context_id", Required = Required.AllowNull)]
        public string ContextId { get; set; }
        /// <summary>
        /// List of NIC information for VMs
        /// </summary>
        [JsonProperty(PropertyName = "vm_nic_infos", Required = Required.AllowNull)]
        public IList<NSXTVmNicInfoType> VmNicInfos { get; set; }
        /// <summary>
        /// Storage Id.
        /// </summary>
        [JsonProperty(PropertyName = "storage_id", Required = Required.AllowNull)]
        public string StorageId { get; set; }
        /// <summary>
        /// The service VM will be deployed on the specified host in the
        /// specified server within the cluster if host_id is specified.
        /// Note: You must ensure that storage and specified networks are
        /// accessible by this host.
        /// </summary>
        [JsonProperty(PropertyName = "host_id")]
        public string? HostId { get; set; }
        /// <summary>
        /// Resource Pool or Compute Id.
        /// </summary>
        [JsonProperty(PropertyName = "compute_id", Required = Required.AllowNull)]
        public string ComputeId { get; set; }
    }
}
