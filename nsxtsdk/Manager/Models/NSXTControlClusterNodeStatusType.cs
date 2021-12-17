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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTControlClusterNodeStatusType 
    {
        public NSXTControlClusterNodeStatusType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_connection_status")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTMgmtConnStatusType MgmtConnectionStatus { get; set; }
        /// <summary>
        /// Status of this node's connection to the control cluster
        /// </summary>
        [JsonProperty(PropertyName = "control_cluster_status")]
        [NSXTProperty(IsRequired: false, Description: @"Status of this node&apos;s connection to the control cluster")]
        public NSXTControlClusterNodeStatusControlClusterStatusEnumType? ControlClusterStatus { get; set; }
    }
}
