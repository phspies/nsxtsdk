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
    public class NSXTLbVirtualServerStatisticsType 
    {
        /// <summary>
        /// Timestamp when the data was last updated
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "statistics", Required = Required.AllowNull)]
        public NSXTLbStatisticsCounterType Statistics { get; set; }
        /// <summary>
        /// load balancer virtual server identifier
        /// </summary>
        [JsonProperty(PropertyName = "virtual_server_id", Required = Required.AllowNull)]
        public string VirtualServerId { get; set; }
    }
}
