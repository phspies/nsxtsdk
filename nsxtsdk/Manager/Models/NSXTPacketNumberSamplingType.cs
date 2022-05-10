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
    public class NSXTPacketNumberSamplingType : NSXTSamplingArgumentType
    {
        /// <summary>
        /// 1 out of how many packets is sampled
        /// </summary>
        [JsonProperty(PropertyName = "sampling_rate", Required = Required.AllowNull)]
        public long SamplingRate { get; set; }
    }
}
