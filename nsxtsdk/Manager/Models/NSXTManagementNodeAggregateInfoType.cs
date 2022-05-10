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
    public class NSXTManagementNodeAggregateInfoType : NSXTBaseNodeAggregateInfoType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "transport_nodes_connected")]
        public long? TransportNodesConnected { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "role_config")]
        public NSXTManagementClusterRoleConfigType RoleConfig { get; set; }
    }
}
