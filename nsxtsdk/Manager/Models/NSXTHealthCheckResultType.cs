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
    /// Result of health check.
    /// </summary>
    [NSXTProperty(Description: @"Result of health check.")]
    public class NSXTHealthCheckResultType 
    {
        /// <summary>
        /// Overall status of VLAN-MTU health check result.
        /// </summary>
        [JsonProperty(PropertyName = "vlan_mtu_status")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTHealthCheckResultVlanMtuStatusEnumType? VlanMtuStatus { get; set; }
        /// <summary>
        /// List of health check results on specific transport node.
        /// </summary>
        [JsonProperty(PropertyName = "results_per_transport_node")]
        public IList<NSXTHealthCheckResultPerTransportNodeType> ResultsPerTransportNode { get; set; }
        /// <summary>
        /// Timestamp of check result updated.
        /// </summary>
        [JsonProperty(PropertyName = "updated_time")]
        public long? UpdatedTime { get; set; }
    }
}
