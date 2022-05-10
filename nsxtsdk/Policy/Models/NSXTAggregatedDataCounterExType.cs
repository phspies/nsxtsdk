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
    public class NSXTAggregatedDataCounterExType : NSXTAggregatedDataCounterType
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mac_learning")]
        public NSXTMacLearningCountersType MacLearning { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dropped_by_security_packets")]
        public NSXTPacketsDroppedBySecurityType DroppedBySecurityPackets { get; set; }
    }
}
