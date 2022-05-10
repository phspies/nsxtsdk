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
    public class NSXTManagementClusterStatusType 
    {
        /// <summary>
        /// The current status of the management cluster
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTManagementClusterStatusStatusEnumType? Status { get; set; }
        /// <summary>
        /// Current missing management plane nodes
        /// </summary>
        [JsonProperty(PropertyName = "offline_nodes")]
        public IList<NSXTManagementPlaneBaseNodeInfoType> OfflineNodes { get; set; }
        /// <summary>
        /// The details of the cluster nodes required for cluster initialization
        /// </summary>
        [JsonProperty(PropertyName = "required_members_for_initialization")]
        public IList<NSXTClusterInitializationNodeInfoType> RequiredMembersForInitialization { get; set; }
        /// <summary>
        /// Current alive management plane nodes
        /// </summary>
        [JsonProperty(PropertyName = "online_nodes")]
        public IList<NSXTManagementPlaneBaseNodeInfoType> OnlineNodes { get; set; }
    }
}
