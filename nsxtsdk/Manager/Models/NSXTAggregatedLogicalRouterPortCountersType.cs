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
    public class NSXTAggregatedLogicalRouterPortCountersType 
    {
        /// <summary>
        /// Timestamp when the data was last updated; unset if data source has never updated the data.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rx")]
        public NSXTLogicalRouterPortCountersType Rx { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tx")]
        public NSXTLogicalRouterPortCountersType Tx { get; set; }
    }
}
