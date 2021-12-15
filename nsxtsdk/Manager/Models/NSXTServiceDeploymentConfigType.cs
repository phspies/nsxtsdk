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
    /// The Deployment Config contains settings that are applied during install time.
    /// </summary>
    [NSXTProperty(Description: @"The Deployment Config contains settings that are applied during install time.")]
    public class NSXTServiceDeploymentConfigType 
    {
        /// <summary>
        /// Moref of the datastore in VC. If it is to be taken from 'Agent VM Settings', then it should be empty.
        /// </summary>
        [JsonProperty(PropertyName = "storage_id")]
        [NSXTProperty(IsRequired: false, Description: @"Moref of the datastore in VC. If it is to be taken from &apos;Agent VM Settings&apos;, then it should be empty.")]
        public string? StorageId { get; set; }
        /// <summary>
        /// The service VM will be deployed on the specified host in the specified
        /// server within the cluster if host_id is specified.
        /// Note: You must ensure that storage and specified networks are accessible
        /// by this host.
        /// </summary>
        [JsonProperty(PropertyName = "host_id")]
        [NSXTProperty(IsRequired: false, Description: @"The service VM will be deployed on the specified host in the specifiedserver within the cluster if host_id is specified.Note: You must ensure that storage and specified networks are accessible      by this host.")]
        public string? HostId { get; set; }
        /// <summary>
        /// Resource Pool or cluster Id.
        /// </summary>
        [JsonProperty(PropertyName = "compute_collection_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Resource Pool or cluster Id.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ComputeCollectionId { get; set; }
        /// <summary>
        /// VM NIC information for VMs
        /// </summary>
        [JsonProperty(PropertyName = "vm_nic_info")]
        [NSXTProperty(IsRequired: false, Description: @"VM NIC information for VMs")]
        public NSXTVmNicInfoType VmNicInfo { get; set; }
        /// <summary>
        /// Context Id or VCenter Id.
        /// </summary>
        [JsonProperty(PropertyName = "compute_manager_id", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"Context Id or VCenter Id.")]
        [System.ComponentModel.DataAnnotations.Required]
        public string ComputeManagerId { get; set; }
    }
}
