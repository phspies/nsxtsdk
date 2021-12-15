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
    /// The type provides the information of a non-running cluster node required for the initialization of a management cluster.
        /// The administrator needs to start this node for management cluster to initialize properly (or decommission it
        /// explicitly).
    /// </summary>
    [NSXTProperty(Description: @"The type provides the information of a non-running cluster node required for the initialization of a management cluster. The administrator needs to start this node for management cluster to initialize properly (or decommission it explicitly).")]
    public class NSXTClusterInitializationNodeInfoType 
    {
        /// <summary>
        /// The (internal) disk-store ID of the member
        /// </summary>
        [JsonProperty(PropertyName = "disk_store_id")]
        [NSXTProperty(IsRequired: false, Description: @"The (internal) disk-store ID of the member")]
        public string? DiskStoreId { get; set; }
        /// <summary>
        /// The IP address (or domain name) of the cluster node
        /// </summary>
        [JsonProperty(PropertyName = "host_address")]
        [NSXTProperty(IsRequired: false, Description: @"The IP address (or domain name) of the cluster node")]
        public string? HostAddress { get; set; }
    }
}
