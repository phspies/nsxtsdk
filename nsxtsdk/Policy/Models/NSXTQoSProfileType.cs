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
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTQoSProfileType : NSXTPolicyConfigResourceType
    {
        public NSXTQoSProfileType()
        {
            ClassOfService = test
        }
        /// <summary>
        /// Array of Rate limiter configurations to applied on Segment or Port.
        /// </summary>
        [JsonProperty(PropertyName = "shaper_configurations")]
        [NSXTProperty(IsRequired: false, Description: @"Array of Rate limiter configurations to applied on Segment or Port.")]
        public IList<NSXTQoSBaseRateLimiterType> ShaperConfigurations { get; set; }
        /// <summary>
        /// Class of service groups similar types of traffic in the network and
        /// each type of traffic is treated as a class with its own level of service
        /// priority. The lower priority traffic is slowed down or in some cases
        /// dropped to provide better throughput for higher priority traffic.
        /// </summary>
        [JsonProperty(PropertyName = "class_of_service")]
        [NSXTProperty(IsRequired: false, Description: @"Class of service groups similar types of traffic in the network andeach type of traffic is treated as a class with its own level of servicepriority. The lower priority traffic is slowed down or in some casesdropped to provide better throughput for higher priority traffic.")]
        //[System.ComponentModel.DataAnnotations.MinLength(0)]
        //[System.ComponentModel.DataAnnotations.MaxLength(7)]
        public int? ClassOfService { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dscp")]
        [NSXTProperty(IsRequired: false, Description: @"")]
        public NSXTQoSDscpType Dscp { get; set; }
    }
}
