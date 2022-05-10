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
    /// The Deployment Config contains settings that are applied during install time.
    /// </summary>
    [NSXTProperty(Description: @"The Deployment Config contains settings that are applied during install time.")]
    public class NSXTServiceDeploymentConfigType 
    {
        /// <summary>
        /// Moref of the datastore in VC. If it is to be taken from 'Agent VM Settings', then it should be empty.
        /// </summary>
        [JsonProperty(PropertyName = "storage_id")]
        public string? StorageId { get; set; }
        /// <summary>
        /// The service VM will be deployed on the specified host in the specified
        /// server within the cluster if host_id is specified.
        /// Note: You must ensure that storage and specified networks are accessible
        /// by this host.
        /// </summary>
        [JsonProperty(PropertyName = "host_id")]
        public string? HostId { get; set; }
        /// <summary>
        /// Resource Pool or cluster Id.
        /// </summary>
        [JsonProperty(PropertyName = "compute_collection_id", Required = Required.AllowNull)]
        public string ComputeCollectionId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "vm_nic_info")]
        public NSXTVmNicInfoType VmNicInfo { get; set; }
        /// <summary>
        /// Context Id or VCenter Id.
        /// </summary>
        [JsonProperty(PropertyName = "compute_manager_id", Required = Required.AllowNull)]
        public string ComputeManagerId { get; set; }
    }
}
