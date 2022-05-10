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
    public class NSXTClusterNodeStatusType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "system_status")]
        public NSXTNodeStatusPropertiesType SystemStatus { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_cluster_status")]
        public NSXTManagementClusterNodeStatusType MgmtClusterStatus { get; set; }
        /// <summary>
        /// Software version running on node
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string? Version { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "control_cluster_status")]
        public NSXTControlClusterNodeStatusType ControlClusterStatus { get; set; }
    }
}
