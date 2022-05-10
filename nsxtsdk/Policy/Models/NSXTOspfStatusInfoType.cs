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
    public class NSXTOspfStatusInfoType 
    {
        /// <summary>
        /// Retransmit request counter.
        /// </summary>
        [JsonProperty(PropertyName = "retransmit_counter")]
        public long? RetransmitCounter { get; set; }
        /// <summary>
        /// request counter.
        /// </summary>
        [JsonProperty(PropertyName = "request_counter")]
        public long? RequestCounter { get; set; }
        /// <summary>
        /// OSPF neighbor state.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string? State { get; set; }
        /// <summary>
        /// Tier0 interface name.
        /// </summary>
        [JsonProperty(PropertyName = "interface_name")]
        public string? InterfaceName { get; set; }
        /// <summary>
        /// Time remaining in before considering OSPF neighbor dead.
        /// </summary>
        [JsonProperty(PropertyName = "dead_time")]
        public string? DeadTime { get; set; }
        /// <summary>
        /// Multicast source address.
        /// </summary>
        [JsonProperty(PropertyName = "source_address")]
        public string? SourceAddress { get; set; }
        /// <summary>
        /// Database summary counter.
        /// </summary>
        [JsonProperty(PropertyName = "database_summary_counter")]
        public long? DatabaseSummaryCounter { get; set; }
        /// <summary>
        /// Time since last change in state.
        /// </summary>
        [JsonProperty(PropertyName = "last_state_change")]
        public string? LastStateChange { get; set; }
        /// <summary>
        /// Priority of the neighbor.
        /// </summary>
        [JsonProperty(PropertyName = "priority")]
        public long? Priority { get; set; }
    }
}
