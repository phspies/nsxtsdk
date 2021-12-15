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
    public class NSXTLBServiceStatisticsType : NSXTLBServiceStatisticsPerEPType
    {
        /// <summary>
        /// Statistics of load balancer pools
        /// </summary>
        [JsonProperty(PropertyName = "pools")]
        [NSXTProperty(IsRequired: false, Description: @"Statistics of load balancer pools")]
        public IList<NSXTLBPoolStatisticsType> Pools { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        [NSXTProperty(IsRequired: false, Description: @"Timestamp when the data was last updated.")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Statistics of load balancer virtual servers.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_servers")]
        [NSXTProperty(IsRequired: false, Description: @"Statistics of load balancer virtual servers.")]
        public IList<NSXTLBVirtualServerStatisticsType> VirtualServers { get; set; }
        /// <summary>
        /// load balancer service identifier.
        /// </summary>
        [JsonProperty(PropertyName = "service_path")]
        [NSXTProperty(IsRequired: false, Description: @"load balancer service identifier.")]
        public string? ServicePath { get; set; }
        /// <summary>
        /// Load balancer service statistics counter.
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        [NSXTProperty(IsRequired: false, Description: @"Load balancer service statistics counter.")]
        public NSXTLBServiceStatisticsCounterType Statistics { get; set; }
    }
}
