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
    public class NSXTIntervalSamplingType : NSXTSamplingArgumentType
    {
        /// <summary>
        /// Time interval in ms between two sampling actions.
        /// </summary>
        [JsonProperty(PropertyName = "sampling_interval", Required = Required.AllowNull)]
        public long SamplingInterval { get; set; }
    }
}
