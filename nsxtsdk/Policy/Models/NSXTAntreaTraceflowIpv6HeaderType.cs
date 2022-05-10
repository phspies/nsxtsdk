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
    /// Ipv6 header stuffs for Antrea traceflow.
    /// </summary>
    [NSXTProperty(Description: @"Ipv6 header stuffs for Antrea traceflow.")]
    public class NSXTAntreaTraceflowIpv6HeaderType 
    {
        /// <summary>
        /// Source ip address in Ipv6Header.
        /// </summary>
        [JsonProperty(PropertyName = "srcIp")]
        public string? SrcIp { get; set; }
        /// <summary>
        /// Destination ip address in Ipv6Header.
        /// </summary>
        [JsonProperty(PropertyName = "dstIp")]
        public string? DstIp { get; set; }
        /// <summary>
        /// Next header setting in Ipv6Header.
        /// </summary>
        [JsonProperty(PropertyName = "nextHeader")]
        public long? NextHeader { get; set; }
        /// <summary>
        /// Hop limit setting in Ipv6Header.
        /// </summary>
        [JsonProperty(PropertyName = "hopLimit")]
        public long? HopLimit { get; set; }
    }
}
