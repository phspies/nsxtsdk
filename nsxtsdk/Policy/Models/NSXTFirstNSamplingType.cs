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
    public class NSXTFirstNSamplingType : NSXTSamplingArgumentType
    {
        /// <summary>
        /// Number of packets to be sampled
        /// </summary>
        [JsonProperty(PropertyName = "match_number", Required = Required.AllowNull)]
        public long MatchNumber { get; set; }
    }
}
