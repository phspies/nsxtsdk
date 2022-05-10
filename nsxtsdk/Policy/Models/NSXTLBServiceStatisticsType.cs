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
    public class NSXTLBServiceStatisticsType : NSXTLBServiceStatisticsPerEPType
    {
        /// <summary>
        /// Statistics of load balancer pools
        /// </summary>
        [JsonProperty(PropertyName = "pools")]
        public IList<NSXTLBPoolStatisticsType> Pools { get; set; }
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// Statistics of load balancer virtual servers.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_servers")]
        public IList<NSXTLBVirtualServerStatisticsType> VirtualServers { get; set; }
        /// <summary>
        /// load balancer service identifier.
        /// </summary>
        [JsonProperty(PropertyName = "service_path")]
        public string? ServicePath { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public NSXTLBServiceStatisticsCounterType Statistics { get; set; }
    }
}
