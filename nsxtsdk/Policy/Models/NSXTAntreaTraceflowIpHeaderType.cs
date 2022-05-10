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
    /// Ip header stuffs for Antrea traceflow.
    /// </summary>
    [NSXTProperty(Description: @"Ip header stuffs for Antrea traceflow.")]
    public class NSXTAntreaTraceflowIpHeaderType 
    {
        /// <summary>
        /// Source ip address in IpHeader.
        /// </summary>
        [JsonProperty(PropertyName = "srcIp")]
        public string? SrcIp { get; set; }
        /// <summary>
        /// Protocol setting in IpHeader.
        /// </summary>
        [JsonProperty(PropertyName = "protocol")]
        public long? Protocol { get; set; }
        /// <summary>
        /// Destination ip address in IpHeader.
        /// </summary>
        [JsonProperty(PropertyName = "dstIp")]
        public string? DstIp { get; set; }
        /// <summary>
        /// Protocol setting in IpHeader.
        /// </summary>
        [JsonProperty(PropertyName = "flags")]
        public long? Flags { get; set; }
        /// <summary>
        /// TTL value in IpHeader. Default is 64.
        /// </summary>
        [JsonProperty(PropertyName = "ttl")]
        public long? Ttl { get; set; }
    }
}
