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
    /// All the network interfaces of the discovered node
    /// </summary>
    [NSXTProperty(Description: @"All the network interfaces of the discovered node")]
    public class NSXTDiscoveredNodeNetworkInterfacesType 
    {
        /// <summary>
        /// Id of the discovered node
        /// </summary>
        [JsonProperty(PropertyName = "discovered_node_id", Required = Required.AllowNull)]
        public string DiscoveredNodeId { get; set; }
        /// <summary>
        /// Network interfaces of the node
        /// </summary>
        [JsonProperty(PropertyName = "network_interfaces")]
        public IList<NSXTDiscoveredNodeInterfacePropertiesType> NetworkInterfaces { get; set; }
    }
}
