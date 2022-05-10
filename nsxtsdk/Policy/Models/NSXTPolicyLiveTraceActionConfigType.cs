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
    /// Livetrace action configuration
    /// </summary>
    [NSXTProperty(Description: @"Livetrace action configuration")]
    public class NSXTPolicyLiveTraceActionConfigType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "trace_config")]
        public NSXTLiveTracePacketGranularActionConfigType TraceConfig { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "pktcap_config")]
        public NSXTLiveTracePacketGranularActionConfigType PktcapConfig { get; set; }
    }
}
