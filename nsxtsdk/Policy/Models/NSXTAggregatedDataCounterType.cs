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
    public class NSXTAggregatedDataCounterType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tx_bytes")]
        public NSXTDataCounterType TxBytes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rx_packets")]
        public NSXTDataCounterType RxPackets { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tx_packets")]
        public NSXTDataCounterType TxPackets { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rx_bytes")]
        public NSXTDataCounterType RxBytes { get; set; }
    }
}
