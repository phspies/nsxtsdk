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
    public class NSXTNodeInterSiteStatisticsType 
    {
        public NSXTNodeInterSiteStatisticsType()
        {
        }
        /// <summary>
        /// Timestamp when the remote tunnel port statistics was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp when the remote tunnel port statistics was last updated.")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Remote tunnel statistics per site.
        /// </summary>
        [JsonProperty(PropertyName = "stats_per_site")]
        [NSXTProperty(IsRequired: false, Description: @"Remote tunnel statistics per site.")]
        public IList<NSXTRemoteTunnelStatisticsPerSiteType> StatsPerSite { get; set; }
        /// <summary>
        /// Edge node id whose statistics is being reported.
        /// </summary>
        [JsonProperty(PropertyName = "transport_node_id")]
        [NSXTProperty(IsRequired: false, Description: @"Edge node id whose statistics is being reported.")]
        public string? TransportNodeId { get; set; }
    }
}
