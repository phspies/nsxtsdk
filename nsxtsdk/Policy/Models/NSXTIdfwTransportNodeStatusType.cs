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
    /// ID and status of the Identity Firewall enabled Compute collection's
        /// transport node.
    /// </summary>
    [NSXTProperty(Description: @"ID and status of the Identity Firewall enabled Compute collection&apos;stransport node.")]
    public class NSXTIdfwTransportNodeStatusType 
    {
        /// <summary>
        /// Status of the IDFW transport node.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_status", Required = Required.AllowNull)]
        public IList<NSXTIdfwTransportNodeConditionType> TransportNodeStatus { get; set; }
        /// <summary>
        /// TransportNode ID of the Identity Firewall enabled Compute
        /// collection's transport node.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id", Required = Required.AllowNull)]
        public string TransportNodeId { get; set; }
    }
}
