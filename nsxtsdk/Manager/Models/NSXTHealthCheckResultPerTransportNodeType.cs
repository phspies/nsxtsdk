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
    /// Health check result on specific transport node
    /// </summary>
    [NSXTProperty(Description: @"Health check result on specific transport node")]
    public class NSXTHealthCheckResultPerTransportNodeType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "result_on_host_switch")]
        public NSXTHealthCheckResultOnHostSwitchType ResultOnHostSwitch { get; set; }
        /// <summary>
        /// ID of the Transport Node.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id")]
        public string? TransportNodeId { get; set; }
    }
}
