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
    public class NSXTControlClusterNodeStatusType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_connection_status")]
        public NSXTMgmtConnStatusType MgmtConnectionStatus { get; set; }
        /// <summary>
        /// Status of this node's connection to the control cluster
        /// </summary>
        [JsonProperty(PropertyName = "control_cluster_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTControlClusterNodeStatusControlClusterStatusEnumType? ControlClusterStatus { get; set; }
    }
}
