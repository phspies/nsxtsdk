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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTCapacityThresholdType 
    {
        /// <summary>
        /// Set the maximum threshold percentage. Specify a value between 0 and
        /// 100. Usage percentage above this value is tagged as critical.
        /// </summary>
        [JsonProperty(PropertyName = "max_threshold_percentage", Required = Required.AllowNull)]
        public double MaxThresholdPercentage { get; set; }
        /// <summary>
        /// Indicate the object type for which threshold is to be set.
        /// </summary>
        [JsonProperty(PropertyName = "threshold_type", Required = Required.AllowNull)]
        public string ThresholdType { get; set; }
        /// <summary>
        /// Set the minimum threshold percentage. Specify a value between 0 and
        /// 100. Usage percentage above this value is tagged as warning.
        /// </summary>
        [JsonProperty(PropertyName = "min_threshold_percentage", Required = Required.AllowNull)]
        public double MinThresholdPercentage { get; set; }
    }
}
