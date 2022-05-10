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
    public class NSXTLBServiceInstanceDetailPerTransportNodeType 
    {
        /// <summary>
        /// Load balancer instances details for each load balancer instance
        /// status type from the given transport node.
        /// </summary>
        [JsonProperty(PropertyName = "instance_detail_per_status")]
        public IList<NSXTLBServiceInstanceDetailPerStatusType> InstanceDetailPerStatus { get; set; }
        /// <summary>
        /// The UUID of the transport node.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id")]
        public string? TransportNodeId { get; set; }
    }
}
