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

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTSegmentL2ForwarderSiteSpanInfoType 
    {
        public NSXTSegmentL2ForwarderSiteSpanInfoType()
        {
        }
        /// <summary>
        /// Timestamp when the L2 forwarder remote mac addresses was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp when the L2 forwarder remote mac addresses was last updated.")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Inter-site forwarder status per node.
        /// </summary>
        [JsonProperty(PropertyName = "inter_site_forwarder_status")]
        [NSXTProperty(IsRequired: false, Description: @"Inter-site forwarder status per node.")]
        public IList<NSXTL2ForwarderStatusPerNodeType> InterSiteForwarderStatus { get; set; }
        /// <summary>
        /// L2 forwarder remote mac addresses per site for logical switch.
        /// </summary>
        [JsonProperty(PropertyName = "remote_macs_per_site")]
        [NSXTProperty(IsRequired: false, Description: @"L2 forwarder remote mac addresses per site for logical switch.")]
        public IList<NSXTL2ForwarderRemoteMacsPerSiteType> RemoteMacsPerSite { get; set; }
        /// <summary>
        /// Policy path of a segment.
        /// </summary>
        [JsonProperty(PropertyName = "segment_path")]
        [NSXTProperty(IsRequired: false, Description: @"Policy path of a segment.")]
        public string? SegmentPath { get; set; }
    }
}
