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
        public bool? EnableRealtimeMetrics { get; set; }
    }
}
