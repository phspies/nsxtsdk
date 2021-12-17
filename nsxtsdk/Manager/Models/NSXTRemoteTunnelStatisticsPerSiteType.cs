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
    public class NSXTRemoteTunnelStatisticsPerSiteType 
    {
        public NSXTRemoteTunnelStatisticsPerSiteType()
        {
        }
        /// <summary>
        /// Statistics per remote tunnel.
        /// </summary>
        [JsonProperty(PropertyName = "stats_per_tunnel")]
        [NSXTProperty(IsRequired: false, Description: @"Statistics per remote tunnel.")]
        public IList<NSXTRemoteTunnelStatisticsType> StatsPerTunnel { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "remote_site")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTResourceReferenceType RemoteSite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rx")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTInterSitePortCountersType Rx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tx")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTInterSitePortCountersType Tx { get; set; }
    }
}
