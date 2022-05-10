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
    /// Aggregate of DNS forwarder statistics across enforcement points.
    /// </summary>
    [NSXTProperty(Description: @"Aggregate of DNS forwarder statistics across enforcement points.")]
    public class NSXTAggregateDNSForwarderStatisticsType 
    {
        /// <summary>
        /// List of DNS forwarder statistics per enforcement point.
        /// </summary>
        [JsonProperty(PropertyName = "statistics_per_enforcement_point")]
        public IList<NSXTDNSForwarderStatisticsPerEnforcementPointType> StatisticsPerEnforcementPoint { get; set; }
        /// <summary>
        /// String path of the DNS forwarder intent.
        /// </summary>
        [JsonProperty(PropertyName = "intent_path", Required = Required.AllowNull)]
        public string IntentPath { get; set; }
    }
}
