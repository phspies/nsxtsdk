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
    /// The basic node info of management plane node
    /// </summary>
    [NSXTProperty(Description: @"The basic node info of management plane node")]
    public class NSXTManagementPlaneBaseNodeInfoType 
    {
        /// <summary>
        /// Management plane node UUID
        /// </summary>
        [JsonProperty(PropertyName = "uuid")]
        public string? Uuid { get; set; }
        /// <summary>
        /// The IP address of MP node
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_cluster_listen_ip_address")]
        public string? MgmtClusterListenIpAddress { get; set; }
    }
}
