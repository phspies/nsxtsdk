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
    public class NSXTWaveFrontGlobalCollectorType : NSXTGlobalCollectorConfigType
    {
        /// <summary>
        /// Port for the Wavefront tracing.
        /// </summary>
        [JsonProperty(PropertyName = "tracing_port")]
        public int? TracingPort { get; set; }
    }
}
