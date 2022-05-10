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
    /// Udp header stuffs for Antrea traceflow.
    /// </summary>
    [NSXTProperty(Description: @"Udp header stuffs for Antrea traceflow.")]
    public class NSXTAntreaTraceflowUdpHeaderType 
    {
        /// <summary>
        /// Destination port number in UdpHeader.
        /// </summary>
        [JsonProperty(PropertyName = "dstPort")]
        public long? DstPort { get; set; }
        /// <summary>
        /// Source port number in UdpHeader.
        /// </summary>
        [JsonProperty(PropertyName = "srcPort")]
        public long? SrcPort { get; set; }
    }
}
