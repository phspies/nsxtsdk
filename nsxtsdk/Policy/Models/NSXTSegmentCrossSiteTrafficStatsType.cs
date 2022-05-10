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
    public class NSXTSegmentCrossSiteTrafficStatsType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tx_stats")]
        public NSXTInterSitePortCountersType TxStats { get; set; }
        /// <summary>
        /// Timestamp when the l2 forwarder statistics was last updated.
        /// </summary>
        [JsonProperty(PropertyName = "last_update_timestamp")]
        public long? LastUpdateTimestamp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rx_stats")]
        public NSXTInterSitePortCountersType RxStats { get; set; }
        /// <summary>
        /// Policy path of Segment to attach interface.
        /// </summary>
        [JsonProperty(PropertyName = "segment_path")]
        public string? SegmentPath { get; set; }
    }
}
