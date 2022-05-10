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
    public class NSXTLogicalRouterLoopbackPortType : NSXTLogicalRouterPortType
    {
        /// <summary>
        /// Loopback port subnets
        /// </summary>
        [JsonProperty(PropertyName = "subnets", Required = Required.AllowNull)]
        public IList<NSXTIPSubnetType> Subnets { get; set; }
        /// <summary>
        /// Member index of the edge node on the cluster
        /// </summary>
        [JsonProperty(PropertyName = "edge_cluster_member_index", Required = Required.AllowNull)]
        public long EdgeClusterMemberIndex { get; set; }
    }
}
