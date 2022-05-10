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
    public class NSXTLiveTraceResultType 
    {
        /// <summary>
        /// PktCap action results
        /// </summary>
        [JsonProperty(PropertyName = "pktcap_results")]
        public IList<NSXTPktCapResultType> PktcapResults { get; set; }
        /// <summary>
        /// Trace action observation list results
        /// </summary>
        [JsonProperty(PropertyName = "trace_results")]
        public IList<NSXTTraceResultType> TraceResults { get; set; }
        /// <summary>
        /// The id is assigned by Livetrace and cannot be specified by user.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string? Id { get; set; }
    }
}
