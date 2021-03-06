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
    /// Port Connection Entities (to help draw a visual picture of entities between two ports)
    /// </summary>
    [NSXTProperty(Description: @"Port Connection Entities (to help draw a visual picture of entities between two ports)")]
    public class NSXTPortConnectionEntitiesType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "containers", Required = Required.AllowNull)]
        public NSXTPortConnectionContainersEntitiesType Containers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "hypervisors", Required = Required.AllowNull)]
        public IList<NSXTPortConnectionHypervisorType> Hypervisors { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "errors", Required = Required.AllowNull)]
        public IList<NSXTPortConnectionErrorType> Errors { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "logical_switches", Required = Required.AllowNull)]
        public IList<NSXTPortConnectionLogicalSwitchType> LogicalSwitches { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "edge_node_groups")]
        public IList<NSXTPortConnectionEdgeNodeGroupType> EdgeNodeGroups { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "routers")]
        public IList<NSXTPortConnectionRouterType> Routers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "vms", Required = Required.AllowNull)]
        public IList<NSXTVirtualMachineType> Vms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tunnels", Required = Required.AllowNull)]
        public IList<NSXTPortConnectionTunnelType> Tunnels { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "physical_hosts")]
        public NSXTPortConnectionBMEntitiesType PhysicalHosts { get; set; }
    }
}
