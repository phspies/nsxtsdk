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
    public class NSXTManagementNodeAggregateInfoType : NSXTBaseNodeAggregateInfoType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "transport_nodes_connected")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        public long? TransportNodesConnected { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "role_config")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTManagementClusterRoleConfigType RoleConfig { get; set; }
    }
}