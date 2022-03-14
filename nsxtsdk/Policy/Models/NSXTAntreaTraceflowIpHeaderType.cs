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
    /// Ip header stuffs for Antrea traceflow.
    /// </summary>
    [NSXTProperty(Description: @"Ip header stuffs for Antrea traceflow.")]
    public class NSXTAntreaTraceflowIpHeaderType 
    {
        /// <summary>
        /// Source ip address in IpHeader.
        /// </summary>
        public string? SrcIp { get; set; }
        /// <summary>
        /// Protocol setting in IpHeader.
        /// </summary>
        public long? Protocol { get; set; }
        /// <summary>
        /// Destination ip address in IpHeader.
        /// </summary>
        public string? DstIp { get; set; }
        /// <summary>
        /// Protocol setting in IpHeader.
        /// </summary>
        public long? Flags { get; set; }
        /// <summary>
        /// TTL value in IpHeader. Default is 64.
        /// </summary>
        public long? Ttl { get; set; }
    }
}
