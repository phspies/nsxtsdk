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
    public class NSXTSamplingArgumentType 
    {
        /// <summary>
        /// Sampling type
        /// </summary>
        [JsonProperty(PropertyName = "sampling_type", Required = Required.AllowNull)]
        [JsonConverter(typeof(StringEnumConverter))]
        public NSXTSamplingArgumentSamplingTypeEnumType SamplingType { get; set; }
    }
}
