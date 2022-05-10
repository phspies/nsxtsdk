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
    /// Transport header stuffs for Antrea traceflow.
    /// </summary>
    [NSXTProperty(Description: @"Transport header stuffs for Antrea traceflow.")]
    public class NSXTAntreaTraceflowTransportHeaderType 
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "tcpHeader")]
        public NSXTAntreaTraceflowTcpHeaderType TcpHeader { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "icmpEchoRequestHeader")]
        public NSXTAntreaTraceflowIcmpEchoRequestHeaderType IcmpEchoRequestHeader { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "udpHeader")]
        public NSXTAntreaTraceflowUdpHeaderType UdpHeader { get; set; }
    }
}
