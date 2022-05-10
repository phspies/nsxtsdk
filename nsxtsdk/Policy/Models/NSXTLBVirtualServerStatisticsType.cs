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
    public class NSXTLBVirtualServerStatisticsType : NSXTLBVirtualServerStatisticsPerEPType
    {
        /// <summary>
        /// Timestamp when the data was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "statistics")]
        public NSXTLBStatisticsCounterType Statistics { get; set; }
        /// <summary>
        /// load balancer virtual server object path.
        /// </summary>
        [JsonProperty(PropertyName = "virtual_server_path")]
        public string? VirtualServerPath { get; set; }
    }
}
