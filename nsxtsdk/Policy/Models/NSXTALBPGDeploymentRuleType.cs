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
    /// Advanced load balancer PGDeploymentRule object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer PGDeploymentRule object")]
    public class NSXTALBPGDeploymentRuleType 
    {
        /// <summary>
        /// Enum options - CO_EQ, CO_GT, CO_GE, CO_LT, CO_LE, CO_NE.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as CO_GE.
        /// </summary>
        [JsonProperty(PropertyName = "operator")]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTAlbpgdeploymentRuleOperatorEnumType? OperatorProperty { get; set; }
        /// <summary>
        /// metric threshold that is used as the pass fail.
        /// If it is not provided then it will simply compare it with
        /// current pool vs new pool.
        /// </summary>
        [JsonProperty(PropertyName = "threshold")]
        public double? Threshold { get; set; }
        /// <summary>
        /// metric_id of PGDeploymentRule.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as health.health_score_value.
        /// </summary>
        [JsonProperty(PropertyName = "metric_id")]
        public string? MetricId { get; set; }
    }
}
