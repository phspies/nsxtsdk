using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;
using Newtonsoft.Json.Converters;

namespace nsxtsdk.ManagerModels
{
    /// <summary>
    /// 
    /// </summary>
    [NSXTProperty(Description: @"")]
    public class NSXTDhcpIpPoolType : NSXTIpAllocationBaseType
    {
        /// <summary>
        /// Ip-ranges to define dynamic ip allocation ranges.
        /// </summary>
        [JsonProperty(PropertyName = "allocation_ranges", Required = Required.AllowNull)]
        public IList<NSXTIpPoolRangeType> AllocationRanges { get; set; }
        /// <summary>
        /// Warning threshold. Alert will be raised if the pool usage reaches the
        /// given threshold.
        /// </summary>
        [JsonProperty(PropertyName = "warning_threshold")]
        public long? WarningThreshold { get; set; }
        /// <summary>
        /// Error threshold. Alert will be raised if the pool usage reaches the
        /// given threshold.
        /// </summary>
        [JsonProperty(PropertyName = "error_threshold")]
        public long? ErrorThreshold { get; set; }
    }
}
