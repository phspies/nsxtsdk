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
    /// IcmpEchoRequest header stuffs for Antrea traceflow.
    /// </summary>
    [NSXTProperty(Description: @"IcmpEchoRequest header stuffs for Antrea traceflow.")]
    public class NSXTAntreaTraceflowIcmpEchoRequestHeaderType 
    {
        /// <summary>
        /// Id of IcmpEchoRequest.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public long? Id { get; set; }
        /// <summary>
        /// Sequence number of IcmpEchoRequest.
        /// </summary>
        [JsonProperty(PropertyName = "sequence")]
        public long? Sequence { get; set; }
    }
}
