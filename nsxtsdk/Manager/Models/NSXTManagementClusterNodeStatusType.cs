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
    public class NSXTManagementClusterNodeStatusType 
    {
        /// <summary>
        /// Status of this node's connection to the management cluster
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_cluster_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTManagementClusterNodeStatusMgmtClusterStatusEnumType? MgmtClusterStatus { get; set; }
    }
}
