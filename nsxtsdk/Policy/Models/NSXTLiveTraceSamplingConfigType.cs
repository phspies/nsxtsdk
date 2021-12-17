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
    /// Sampling parameter for a livetrace action
    /// </summary>
    [NSXTProperty(Description: @"Sampling parameter for a livetrace action")]
    public class NSXTLiveTraceSamplingConfigType 
    {
        public NSXTLiveTraceSamplingConfigType()
        {
        }
        /// <summary>
        /// A packet is sampled for every given time interval in ms.
        /// </summary>
        [JsonProperty(PropertyName = "sampling_interval")]
        [NSXTProperty(IsRequired: false, Description: @"A packet is sampled for every given time interval in ms.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(30000)]
        public long? SamplingInterval { get; set; }
        /// <summary>
        /// First N packets are sampled. The upper limits of sampling number for trace and packet capture actions
        /// are 50 and 500, respectively.
        /// </summary>
        [JsonProperty(PropertyName = "match_number")]
        [NSXTProperty(IsRequired: false, Description: @"First N packets are sampled. The upper limits of sampling number for trace and packet capture actionsare 50 and 500, respectively.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(500)]
        public long? MatchNumber { get; set; }
        /// <summary>
        /// 1 out of N packets is sampled on average.
        /// </summary>
        [JsonProperty(PropertyName = "sampling_rate")]
        [NSXTProperty(IsRequired: false, Description: @"1 out of N packets is sampled on average.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(65535)]
        public long? SamplingRate { get; set; }
    }
}
