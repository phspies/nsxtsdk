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
    public class NSXTGatewayQosProfileType : NSXTPolicyConfigResourceType
    {
        /// <summary>
        /// Burst size in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "burst_size")]
        [NSXTProperty(IsRequired: false, Description: @"Burst size in bytes.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        [NSXTDefaultProperty(Default: "")]
        public long? BurstSize { get; set; }
        /// <summary>
        /// Action on traffic exceeding bandwidth.
        /// </summary>
        [JsonProperty(PropertyName = "excess_action")]
        [NSXTProperty(IsRequired: false, Description: @"Action on traffic exceeding bandwidth.")]
        public NSXTGatewayQosProfileExcessActionEnumType? ExcessAction { get; set; }
        /// <summary>
        /// Committed bandwidth in both directions specified in Mbps.
        /// Bandwidth is limited to line rate when the value configured is greater
        /// than line rate.
        /// This property is deprecated, use committed_bandwidth instead.
        /// </summary>
        [JsonProperty(PropertyName = "committed_bandwitdth")]
        [NSXTProperty(IsRequired: false, Description: @"Committed bandwidth in both directions specified in Mbps.Bandwidth is limited to line rate when the value configured is greaterthan line rate.This property is deprecated, use committed_bandwidth instead.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        [NSXTDefaultProperty(Default: "")]
        public long? CommittedBandwitdth { get; set; }
        /// <summary>
        /// Committed bandwidth in both directions specified in Mbps.
        /// Bandwidth is limited to line rate when the value configured is greater
        /// than line rate.
        /// </summary>
        [JsonProperty(PropertyName = "committed_bandwidth")]
        [NSXTProperty(IsRequired: false, Description: @"Committed bandwidth in both directions specified in Mbps.Bandwidth is limited to line rate when the value configured is greaterthan line rate.")]
        //[System.ComponentModel.DataAnnotations.MinLength(1)]
        [NSXTDefaultProperty(Default: "")]
        public long? CommittedBandwidth { get; set; }
    }
}