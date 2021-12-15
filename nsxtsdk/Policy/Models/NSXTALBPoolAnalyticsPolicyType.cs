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
    /// Advanced load balancer PoolAnalyticsPolicy object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer PoolAnalyticsPolicy object")]
    public class NSXTALBPoolAnalyticsPolicyType 
    {
        /// <summary>
        /// Enable real time metrics for server and pool metrics eg.
        /// l4_server.xxx, l7_server.xxx.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enable_realtime_metrics")]
        [NSXTProperty(IsRequired: false, Description: @"Enable real time metrics for server and pool metrics eg.l4_server.xxx, l7_server.xxx.Default value when not specified in API or module isinterpreted by ALB Controller as false.")]
        public bool? EnableRealtimeMetrics { get; set; }
    }
}
