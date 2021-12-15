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
    /// Port Connection Entities (to help draw a visual picture of entities between two ports)
    /// </summary>
    [NSXTProperty(Description: @"Port Connection Entities (to help draw a visual picture of entities between two ports)")]
    public class NSXTPortConnectionEntitiesType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "containers", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public NSXTPortConnectionContainersEntitiesType Containers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "hypervisors", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTPortConnectionHypervisorType> Hypervisors { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "errors", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTPortConnectionErrorType> Errors { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "logical_switches", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTPortConnectionLogicalSwitchType> LogicalSwitches { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "edge_node_groups")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public IList<NSXTPortConnectionEdgeNodeGroupType> EdgeNodeGroups { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "routers")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public IList<NSXTPortConnectionRouterType> Routers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "vms", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTVirtualMachineType> Vms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tunnels", Required = Required.AllowNull)]
        [NSXTProperty(IsRequired: true, Description: @"")]
        [System.ComponentModel.DataAnnotations.Required]
        public IList<NSXTPortConnectionTunnelType> Tunnels { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "physical_hosts")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTPortConnectionBMEntitiesType PhysicalHosts { get; set; }
    }
}
