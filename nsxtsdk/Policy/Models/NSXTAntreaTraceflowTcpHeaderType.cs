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
    /// Tcp header stuffs for Antrea traceflow.
    /// </summary>
    [NSXTProperty(Description: @"Tcp header stuffs for Antrea traceflow.")]
    public class NSXTAntreaTraceflowTcpHeaderType 
    {
        /// <summary>
        /// Tcp flags in TcpHeader. SYN flag must be set for traceflow.
        /// </summary>
        [JsonProperty(PropertyName = "tcpFlags")]
        public long? TcpFlags { get; set; }
        /// <summary>
        /// Destination port number in TcpHeader.
        /// </summary>
        [JsonProperty(PropertyName = "dstPort")]
        public long? DstPort { get; set; }
        /// <summary>
        /// Source port number in TcpHeader.
        /// </summary>
        [JsonProperty(PropertyName = "srcPort")]
        public long? SrcPort { get; set; }
    }
}
