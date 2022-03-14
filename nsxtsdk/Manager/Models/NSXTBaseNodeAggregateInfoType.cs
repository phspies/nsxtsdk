// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public IList<NSXTNodeInterfacePropertiesType> NodeInterfaceProperties { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTClusterNodeStatusType NodeStatus { get; set; }
        /// <summary>
        /// Array of Node network interface statistic properties
        /// </summary>
        public IList<NSXTNodeInterfaceStatisticsPropertiesType> NodeInterfaceStatistics { get; set; }
        /// <summary>
        /// Defaults to ID if not set
        /// </summary>
        public string? DisplayName { get; set; }
        /// <summary>
        /// Time series of the node's system properties
        /// </summary>
        public IList<NSXTNodeStatusPropertiesType> NodeStatusProperties { get; set; }
        /// <summary>
        /// Unique identifier of this resource
        /// </summary>
        public string? Id { get; set; }
    }
}
