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
    public class NSXTL2ForwarderRemoteMacsType 
    {
        /// <summary>
        /// Timestamp when the l2 forwarder remote mac addresses was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Logical switch id on which the L2 forwarder is created.
        /// </summary>
        [JsonProperty(PropertyName = "logical_switch_id")]
        public string? LogicalSwitchId { get; set; }
        /// <summary>
        /// L2 forwarder remote mac addresses per site for logical switch.
        /// </summary>
        [JsonProperty(PropertyName = "remote_macs_per_site")]
        public IList<NSXTL2ForwarderRemoteMacsPerSiteType> RemoteMacsPerSite { get; set; }
        /// <summary>
        /// Inter-site forwarder status per node.
        /// </summary>
        [JsonProperty(PropertyName = "inter_site_forwarder_status")]
        public IList<NSXTL2ForwarderStatusPerNodeType> InterSiteForwarderStatus { get; set; }
    }
}
