// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

namespace nsxtsdk.PolicyModels
{
    /// <summary>
    /// Aggregate of L3Vpn Statistics across Enforcement Points.
    /// </summary>
    [NSXTProperty(Description: @"Aggregate of L3Vpn Statistics across Enforcement Points.")]
    public class NSXTAggregateL3VpnStatisticsType 
    {
        /// <summary>
        /// List of L3Vpn Statistics per Enforcement Point.
        /// </summary>
        public IList<NSXTL3VpnStatisticsPerEnforcementPointType> L3vpnStatisticsPerEnforcementPoint { get; set; }
        /// <summary>
        /// Intent path of object, forward slashes must be escaped using %2F.
        /// </summary>
        [JsonProperty(PropertyName = "intent_path", Required = Required.AllowNull)]
        public string IntentPath { get; set; }
    }
}
