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
    /// Aggregate of L2Vpn Statistics across Enforcement Points.
    /// </summary>
    [NSXTProperty(Description: @"Aggregate of L2Vpn Statistics across Enforcement Points.")]
    public class NSXTAggregateL2VpnStatisticsType 
    {
        /// <summary>
        /// List of L2Vpn Statistics per Enforcement Point.
        /// </summary>
        [JsonProperty(PropertyName = "l2vpn_statistics_per_enforcement_point")]
        public IList<NSXTL2VpnStatisticsPerEnforcementPointType> L2vpnStatisticsPerEnforcementPoint { get; set; }
        /// <summary>
        /// Intent path of object, forward slashes must be escaped using %2F.
        /// </summary>
        [JsonProperty(PropertyName = "intent_path", Required = Required.AllowNull)]
        public string IntentPath { get; set; }
    }
}
