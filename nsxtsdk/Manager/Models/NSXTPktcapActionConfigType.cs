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
    public class NSXTPktcapActionConfigType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "sampling_argument")]
        public NSXTSamplingArgumentType SamplingArgument { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "action_argument")]
        public NSXTPktcapActionArgumentType ActionArgument { get; set; }
    }
}
