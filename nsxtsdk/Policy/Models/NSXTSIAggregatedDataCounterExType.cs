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
    public class NSXTSIAggregatedDataCounterExType : NSXTSIAggregatedDataCounterType
    {
        public NSXTSIAggregatedDataCounterExType()
        {
        }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "mac_learning")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTSIMacLearningCountersType MacLearning { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dropped_by_security_packets")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTSIPacketsDroppedBySecurityType DroppedBySecurityPackets { get; set; }
    }
}
