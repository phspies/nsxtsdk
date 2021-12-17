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

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTLatencyStatProfileType : NSXTManagedResourceType
    {
        public NSXTLatencyStatProfileType()
        {
        }
        /// <summary>
        /// Event nth milliseconds packet is sampled. When a value less than
        /// 1000 is given, the realized sampling interval will be 1000 milliseconds.
        /// </summary>
        [JsonProperty(PropertyName = "sampling_interval")]
        [NSXTProperty(IsRequired: false, Description: @"Event nth milliseconds packet is sampled. When a value less than1000 is given, the realized sampling interval will be 1000 milliseconds.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        //[System.ComponentModel.DataAnnotations.MaxLength(1000000)]
        public long? SamplingInterval { get; set; }
        /// <summary>
        /// Event nth packet is sampled.
        /// </summary>
        [JsonProperty(PropertyName = "sampling_rate")]
        [NSXTProperty(IsRequired: false, Description: @"Event nth packet is sampled.")]
        //[System.ComponentModel.DataAnnotations.MinLength(100)]
        //[System.ComponentModel.DataAnnotations.MaxLength(1000000)]
        public long? SamplingRate { get; set; }
        /// <summary>
        /// Enable or Disable pnic latency.
        /// </summary>
        [JsonProperty(PropertyName = "pnic_latency_enabled")]
        [NSXTProperty(IsRequired: false, Description: @"Enable or Disable pnic latency.")]
        public bool? PnicLatencyEnabled { get; set; }
    }
}
