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
    /// Neighbor properties
    /// </summary>
    [NSXTProperty(Description: @"Neighbor properties")]
    public class NSXTNeighborPropertiesType 
    {
        /// <summary>
        /// System name
        /// </summary>
        [JsonProperty(PropertyName = "system_name")]
        public string? SystemName { get; set; }
        /// <summary>
        /// System description
        /// </summary>
        [JsonProperty(PropertyName = "system_desc")]
        public string? SystemDesc { get; set; }
        /// <summary>
        /// System port number
        /// </summary>
        [JsonProperty(PropertyName = "system_port_number")]
        public long? SystemPortNumber { get; set; }
        /// <summary>
        /// Interface name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string? Name { get; set; }
        /// <summary>
        /// Object identifier
        /// </summary>
        [JsonProperty(PropertyName = "oid")]
        public string? Oid { get; set; }
        /// <summary>
        /// Management address
        /// </summary>
        [JsonProperty(PropertyName = "mgmt_addr")]
        public string? MgmtAddr { get; set; }
        /// <summary>
        /// Capabilities
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public string? Capabilities { get; set; }
        /// <summary>
        /// True if currently in aggregation
        /// </summary>
        [JsonProperty(PropertyName = "link_aggregation_status")]
        public bool? LinkAggregationStatus { get; set; }
        /// <summary>
        /// Interface index
        /// </summary>
        [JsonProperty(PropertyName = "ifindex")]
        public long? Ifindex { get; set; }
        /// <summary>
        /// Interface MAC address
        /// </summary>
        [JsonProperty(PropertyName = "mac")]
        public string? Mac { get; set; }
        /// <summary>
        /// Aggregation Capability
        /// </summary>
        [JsonProperty(PropertyName = "link_aggregation_capable")]
        public bool? LinkAggregationCapable { get; set; }
        /// <summary>
        /// Port description
        /// </summary>
        [JsonProperty(PropertyName = "port_desc")]
        public string? PortDesc { get; set; }
        /// <summary>
        /// Enabled capabilities
        /// </summary>
        [JsonProperty(PropertyName = "enabled_capabilities")]
        public string? EnabledCapabilities { get; set; }
        /// <summary>
        /// Aggregation port id
        /// </summary>
        [JsonProperty(PropertyName = "link_aggregation_port_id")]
        public string? LinkAggregationPortId { get; set; }
    }
}
