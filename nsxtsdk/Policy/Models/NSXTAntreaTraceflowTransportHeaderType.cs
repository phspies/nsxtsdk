// <auto-generated>
// Changes may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
using nsxtsdk.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.ComponentModel;
using NJsonSchema.Converters;

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
        public NSXTAntreaTraceflowTcpHeaderType TcpHeader { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTAntreaTraceflowIcmpEchoRequestHeaderType IcmpEchoRequestHeader { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public NSXTAntreaTraceflowUdpHeaderType UdpHeader { get; set; }
    }
}
