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
        public string? DiskStoreId { get; set; }
        /// <summary>
        /// The IP address (or domain name) of the cluster node
        /// </summary>
        [JsonProperty(PropertyName = "host_address")]
        public string? HostAddress { get; set; }
    }
}
