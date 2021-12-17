// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using NJsonSchema.Converters;
using System.ComponentModel;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTL2ForwarderRemoteMacsType 
    {
        public NSXTL2ForwarderRemoteMacsType()
        {
        }
        /// <summary>
        /// Timestamp when the l2 forwarder remote mac addresses was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp when the l2 forwarder remote mac addresses was last updated.")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Logical switch id on which the L2 forwarder is created.
        /// </summary>
        [JsonProperty(PropertyName = "logical_switch_id")]
        [NSXTProperty(IsRequired: false, Description: @"Logical switch id on which the L2 forwarder is created.")]
        public string? LogicalSwitchId { get; set; }
        /// <summary>
        /// L2 forwarder remote mac addresses per site for logical switch.
        /// </summary>
        [JsonProperty(PropertyName = "remote_macs_per_site")]
        [NSXTProperty(IsRequired: false, Description: @"L2 forwarder remote mac addresses per site for logical switch.")]
        public IList<NSXTL2ForwarderRemoteMacsPerSiteType> RemoteMacsPerSite { get; set; }
        /// <summary>
        /// Inter-site forwarder status per node.
        /// </summary>
        [JsonProperty(PropertyName = "inter_site_forwarder_status")]
        [NSXTProperty(IsRequired: false, Description: @"Inter-site forwarder status per node.")]
        public IList<NSXTL2ForwarderStatusPerNodeType> InterSiteForwarderStatus { get; set; }
    }
}
