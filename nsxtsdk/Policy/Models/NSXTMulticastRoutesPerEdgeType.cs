using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTMulticastRoutesPerEdgeType : NSXTListResultType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mcast_routes")]
        public IList<NSXTMulticastRouteType> McastRoutes { get; set; }
        /// <summary>
        /// Policy path to edge node.
        /// </summary>
        [JsonProperty(PropertyName = "edge_path", Required = Required.AllowNull)]
        public string EdgePath { get; set; }
    }
}
