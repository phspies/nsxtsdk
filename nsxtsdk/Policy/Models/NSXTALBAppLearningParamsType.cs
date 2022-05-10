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
    /// Advanced load balancer AppLearningParams object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AppLearningParams object")]
    public class NSXTALBAppLearningParamsType 
    {
        /// <summary>
        /// Learn the params per URI path.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as true.
        /// </summary>
        [JsonProperty(PropertyName = "enable_per_uri_learning")]
        public bool? EnablePerUriLearning { get; set; }
        /// <summary>
        /// Maximum number of URI paths to learn for an application.
        /// Allowed values are 10-10000.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 500.
        /// </summary>
        [JsonProperty(PropertyName = "max_uris")]
        public long? MaxUris { get; set; }
        /// <summary>
        /// Minimum number of occurances required for a Param to
        /// qualify for learning.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 10000.
        /// </summary>
        [JsonProperty(PropertyName = "min_hits_to_learn")]
        public long? MinHitsToLearn { get; set; }
        /// <summary>
        /// Maximum number of params to learn for an application.
        /// Allowed values are 10-1000.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 100.
        /// </summary>
        [JsonProperty(PropertyName = "max_params")]
        public long? MaxParams { get; set; }
        /// <summary>
        /// Frequency with which SE publishes Application learning data
        /// to controller.
        /// Allowed values are 1-60.
        /// Unit is MIN.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 30.
        /// </summary>
        [JsonProperty(PropertyName = "update_interval")]
        public long? UpdateInterval { get; set; }
        /// <summary>
        /// Percent of the requests subjected to Application learning.
        /// Allowed values are 1-100.
        /// Unit is PERCENT.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 1.
        /// </summary>
        [JsonProperty(PropertyName = "sampling_percent")]
        public long? SamplingPercent { get; set; }
    }
}
