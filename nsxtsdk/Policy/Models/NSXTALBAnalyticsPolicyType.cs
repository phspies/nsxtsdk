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
    /// Advanced load balancer AnalyticsPolicy object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AnalyticsPolicy object")]
    public class NSXTALBAnalyticsPolicyType 
    {
        /// <summary>
        /// Placeholder for description of property client_log_filters
        /// of obj type AnalyticsPolicy field type str  type array.
        /// </summary>
        [JsonProperty(PropertyName = "client_log_filters")]
        public IList<NSXTALBClientLogFilterType> ClientLogFilters { get; set; }
        /// <summary>
        /// This setting limits the total number of UDF logs generated
        /// per second for this VS on each SE.
        /// UDF logs are generated due to the configured client log
        /// filters or the rules with logging enabled.
        /// Default is 10 logs per second.
        /// Set it to zero (0) to deactivate throttling.
        /// Unit is PER_SECOND.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 10.
        /// </summary>
        [JsonProperty(PropertyName = "udf_log_throttle")]
        public long? UdfLogThrottle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "metrics_realtime_update")]
        public NSXTALBMetricsRealTimeUpdateType MetricsRealtimeUpdate { get; set; }
        /// <summary>
        /// This setting limits the number of significant logs
        /// generated per second for this VS on each SE.
        /// Default is 10 logs per second.
        /// Set it to zero (0) to deactivate throttling.
        /// Unit is PER_SECOND.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 10.
        /// </summary>
        [JsonProperty(PropertyName = "significant_log_throttle")]
        public long? SignificantLogThrottle { get; set; }
        /// <summary>
        /// Gain insights from sampled client to server HTTP requests
        /// and responses.
        /// Enum options - NO_INSIGHTS, PASSIVE, ACTIVE.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as NO_INSIGHTS.
        /// </summary>
        [JsonProperty(PropertyName = "client_insights")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbanalyticsPolicyClientInsightsEnumType? ClientInsights { get; set; }
        /// <summary>
        /// Log all headers.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as false.
        /// </summary>
        [JsonProperty(PropertyName = "all_headers")]
        public bool? AllHeaders { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "client_insights_sampling")]
        public NSXTALBClientInsightsSamplingType ClientInsightsSampling { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "full_client_logs")]
        public NSXTALBFullClientLogsType FullClientLogs { get; set; }
    }
}
