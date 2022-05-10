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
    public class NSXTL2ForwarderStatusType 
    {
        /// <summary>
        /// Timestamp when the service router status was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Logical switch id on which the L2 forwarder is created.
        /// </summary>
        [JsonProperty(PropertyName = "logical_switch_id")]
        public string? LogicalSwitchId { get; set; }
        /// <summary>
        /// L2 forwarder status per node.
        /// </summary>
        [JsonProperty(PropertyName = "status_per_node")]
        public IList<NSXTL2ForwarderStatusPerNodeType> StatusPerNode { get; set; }
    }
}
