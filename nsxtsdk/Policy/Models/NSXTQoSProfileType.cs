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
    public class NSXTQoSProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Array of Rate limiter configurations to applied on Segment or Port.
        /// </summary>
        [JsonProperty(PropertyName = "shaper_configurations")]
        public IList<NSXTQoSBaseRateLimiterType> ShaperConfigurations { get; set; }
        /// <summary>
        /// Class of service groups similar types of traffic in the network and
        /// each type of traffic is treated as a class with its own level of service
        /// priority. The lower priority traffic is slowed down or in some cases
        /// dropped to provide better throughput for higher priority traffic.
        /// </summary>
        [JsonProperty(PropertyName = "class_of_service")]
        public int? ClassOfService { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dscp")]
        public NSXTQoSDscpType Dscp { get; set; }
    }
}
