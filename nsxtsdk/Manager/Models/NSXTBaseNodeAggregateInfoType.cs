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
    public class NSXTBaseNodeAggregateInfoType 
    {
        /// <summary>
        /// Array of Node interface statistic properties
        /// </summary>
        [JsonProperty(PropertyName = "node_interface_properties")]
        public IList<NSXTNodeInterfacePropertiesType> NodeInterfaceProperties { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "node_status")]
        public NSXTClusterNodeStatusType NodeStatus { get; set; }
        /// <summary>
        /// Array of Node network interface statistic properties
        /// </summary>
        [JsonProperty(PropertyName = "node_interface_statistics")]
        public IList<NSXTNodeInterfaceStatisticsPropertiesType> NodeInterfaceStatistics { get; set; }
        /// <summary>
        /// Defaults to ID if not set
        /// </summary>
        [JsonProperty(PropertyName = "display_name")]
        public string? DisplayName { get; set; }
        /// <summary>
        /// Time series of the node's system properties
        /// </summary>
        [JsonProperty(PropertyName = "node_status_properties")]
        public IList<NSXTNodeStatusPropertiesType> NodeStatusProperties { get; set; }
        /// <summary>
        /// Unique identifier of this resource
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
    }
}
