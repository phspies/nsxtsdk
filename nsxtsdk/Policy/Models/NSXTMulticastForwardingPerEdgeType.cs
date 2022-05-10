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
    /// Multicast Forwarding Per Edge.
    /// </summary>
    [NSXTProperty(Description: @"Multicast Forwarding Per Edge.")]
    public class NSXTMulticastForwardingPerEdgeType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mcast_forwarding")]
        public IList<NSXTMulticastForwardingType> McastForwarding { get; set; }
        /// <summary>
        /// Policy path to edge node.
        /// </summary>
        [JsonProperty(PropertyName = "edge_path", Required = Required.AllowNull)]
        public string EdgePath { get; set; }
    }
}
