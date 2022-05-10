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
    /// Advanced load balancer AppLearningConfidenceOverride object
    /// </summary>
    [NSXTProperty(Description: @"Advanced load balancer AppLearningConfidenceOverride object")]
    public class NSXTALBAppLearningConfidenceOverrideType 
    {
        /// <summary>
        /// Confidence threshold for label CONFIDENCE_LOW.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 7500.
        /// </summary>
        [JsonProperty(PropertyName = "confid_low_value")]
        public long? ConfidLowValue { get; set; }
        /// <summary>
        /// Confidence threshold for label CONFIDENCE_PROBABLE.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 9000.
        /// </summary>
        [JsonProperty(PropertyName = "confid_probable_value")]
        public long? ConfidProbableValue { get; set; }
        /// <summary>
        /// Confidence threshold for label CONFIDENCE_VERY_HIGH.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 9999.
        /// </summary>
        [JsonProperty(PropertyName = "confid_very_high_value")]
        public long? ConfidVeryHighValue { get; set; }
        /// <summary>
        /// Confidence threshold for label CONFIDENCE_HIGH.
        /// Default value when not specified in API or module is
        /// interpreted by ALB Controller as 9500.
        /// </summary>
        [JsonProperty(PropertyName = "confid_high_value")]
        public long? ConfidHighValue { get; set; }
    }
}
