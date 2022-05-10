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
    /// Advanced load balancer MetricsRealTimeUpdate object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer MetricsRealTimeUpdate object")]
    public class NSXTALBMetricsRealTimeUpdateType 
    {
        /// <summary>
        /// Real time metrics collection duration in minutes.
        /// 0 for infinite.
        /// Special values are 0 - 'infinite'.
        /// Unit is MIN.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 30.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public long? Duration { get; set; }
        /// <summary>
        /// Enables real time metrics collection.
        /// When deactivated, 6 hour view is the most granular the
        /// system will track.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "enabled", Required = Required.AllowNull)]
        public bool Enabled { get; set; }
    }
}
