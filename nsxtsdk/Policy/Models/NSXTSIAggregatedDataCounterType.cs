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
    public class NSXTSIAggregatedDataCounterType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tx_bytes")]
        public NSXTSIDataCounterType TxBytes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rx_packets")]
        public NSXTSIDataCounterType RxPackets { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tx_packets")]
        public NSXTSIDataCounterType TxPackets { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "rx_bytes")]
        public NSXTSIDataCounterType RxBytes { get; set; }
    }
}
