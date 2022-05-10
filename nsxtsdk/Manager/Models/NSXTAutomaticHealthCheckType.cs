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
    /// Health check performed by system automatically on a specific transport zone.
        /// 
        /// For overlay based zone, health check is performed on corresponding N-VDS of
        /// each transport node with the VLAN and MTU specified by uplink profile of
        /// N-VDS for the node.
        /// 
        /// For VLAN based zone, health check is performed on corresponding N-VDS of each
        /// transport node with MTU specified by uplink profile of N-VDS for the node
        /// and VLAN specified by all logical switches in this zone.
    /// </summary>
    [NSXTProperty(Description: @"Health check performed by system automatically on a specific transport zone.For overlay based zone, health check is performed on corresponding N-VDS ofeach transport node with the VLAN and MTU specified by uplink profile ofN-VDS for the node.For VLAN based zone, health check is performed on corresponding N-VDS of each transport node with MTU specified by uplink profile of N-VDS for the node and VLAN specified by all logical switches in this zone.")]
    public class NSXTAutomaticHealthCheckType 
    {
        /// <summary>
        /// ID of the transport zone where this automatic health check is performed.
        /// </summary>
        [JsonProperty(PropertyName = "transport_zone_id")]
        public string? TransportZoneId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public NSXTHealthCheckResultType Result { get; set; }
    }
}
